using exeowatcher.classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using xNet;

namespace exeowatcher
{
    public partial class SettingsForm : Form
    {

        private List<string> tags = new List<string>();
        private List<Proxy> proxys = new List<Proxy>();
        private string typeProxy;
        MainForm main;


        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(List<string> tags, List<Proxy> proxys, string typeProxy)
        {
            this.proxys = proxys;
            this.tags = tags;
            this.typeProxy = typeProxy;
            InitializeComponent();
            

        }


    private void SettingsForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            fillCheckBoxList();
            fillProxyList();
            lblProxyType.Visible = false;
            radioBtnHTTP.Visible = false;
            radioBtnNo.Visible = false;
            radioBtnSocks4.Visible = false;
            radioBtnSocks5.Visible = false;
        }

        private void fillCheckBoxList()
        {
            List<int> indexs = new List<int>();
            for(int i = 0; i < tags.Count; i++)
            {
                for(int j = 0; j < checkedListBoxTags.Items.Count; j++)
                {
                    if(checkedListBoxTags.Items[j].ToString() == tags[i])
                    {
                        checkedListBoxTags.SetItemChecked(j, true);
                    }
                }
            }


        }

        private void fillProxyList()
        {
            List<int> indexs = new List<int>();
            for (int i = 0; i < proxys.Count; i++)
            {
                listViewProxy.Items.Add(new ListViewItem(new string[] { proxys[i].ip, proxys[i].port.ToString(), proxys[i].login, proxys[i].password }));
            }

            switch(typeProxy)
            {
                case "HTTP": radioBtnHTTP.Checked = true;
                    break;
                case "Socks4": radioBtnSocks4.Checked = true;
                    break;
                case "Socks5": radioBtnSocks5.Checked = true;
                    break;
            }
        }

        private void addProxy(string host, string port, string username, string password)
        {
            if (host == "")
                return;

            if (listViewProxy.Items.Count == 0)
            {
                proxys.Add(new Proxy(host, Convert.ToInt32(port), username, password, ""));
                listViewProxy.Items.Add(new ListViewItem(new string[] { host, port, username, password }));
                return;
            }

            for (int i = 0; i < listViewProxy.Items.Count; i++)
            {
                if (listViewProxy.Items[i].Text == host)
                {
                    return;
                }

            }
            proxys.Add(new Proxy(host, Convert.ToInt32(port), username, password, ""));
            listViewProxy.Items.Add(new ListViewItem(new string[] { host, port, username, password }));

        }


        private void btnSettingsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettingsOk_Click(object sender, EventArgs e)
        {
            if (checkedListBoxTags.CheckedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одного тега");
                return;
            }

            if (radioBtnHTTP.Checked || radioBtnSocks4.Checked || radioBtnSocks5.Checked)
            {
                if (listViewProxy.Items.Count == 0)
                {
                    MessageBox.Show("Вы не добавили в список ни одного прокси-сервера");
                    return;
                }

                string type = "";

                if (radioBtnHTTP.Checked)
                    type = "HTTP";

                if (radioBtnSocks4.Checked)
                    type = "Socks4";

                if (radioBtnSocks5.Checked)
                    type = "Socks5";
                

                if (!checkAllProxyOfType())
                {
                    setTypeProxy(type);
                }

                main.proxys = new List<Proxy>();
                main.proxys = proxys;

            }
            else if( listViewProxy.Items.Count > 0 )
            {

                const string message =
                            "Вы не отметили тип проксей, все добавленные прокси-сервера сохранены не будут. Продолжить?";
                const string caption = "Предупреждение!";

                var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    main.typeProxy = "none";
                    main.proxys = new List<Proxy>();
                }
            }
            else
            {
                main.proxys = new List<Proxy>();
                main.proxys = proxys;
            }

            main.tags = new List<string>();
            foreach (string s in checkedListBoxTags.CheckedItems)
            {
                main.tags.Add(s);
            }



            Settings settings = new Settings(main.tags, main.proxys, main.typeProxy);
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText("settings.json", json);

            this.Close();
        }

        private void btnSettingsRemoveAll_Click(object sender, EventArgs e)
        {
            radioBtnNo.Checked = true;
            proxys = new List<Proxy>();
            listViewProxy.Items.Clear();
        }

        private void btnSettingsOfFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (.txt)|*.txt";
            openFileDialog.FilterIndex = 0;
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName == "")
                return;


            using (StreamReader reader = new StreamReader(openFileDialog.FileName))
            {
                while (!reader.EndOfStream)
                {
                    string s = reader.ReadLine();
                    HttpProxyClient http = HttpProxyClient.Parse(s);
                    addProxy(http.Host, http.Port.ToString(), http.Username, http.Password);
                }
            }
        }

        private void btnSettingsOfBuffer_Click(object sender, EventArgs e)
        {


            List<string> result = Clipboard.GetText().Split('\n').ToList();
            for(int i = 0; i < result.Count; i++)
            {
                if ( !Regex.IsMatch(result[i],"[a-zA-Z0-9]"))
                    continue;
                HttpProxyClient http = HttpProxyClient.Parse(result[i]);
                addProxy(http.Host, http.Port.ToString(), http.Username, http.Password);
            }
        }


        private void tabCntrlSettings_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabCntrlSettings.SelectedIndex == 1)
            {
                lblProxyType.Visible = true;
                radioBtnHTTP.Visible = true;
                radioBtnNo.Visible = true;
                radioBtnSocks4.Visible = true;
                radioBtnSocks5.Visible = true;
            }
            else
            {
                lblProxyType.Visible = false;
                radioBtnHTTP.Visible = false;
                radioBtnNo.Visible = false;
                radioBtnSocks4.Visible = false;
                radioBtnSocks5.Visible = false;
            }
        }

        public bool checkAllProxyOfType()
        {
            bool result = true;

            for(int i = 0; i < proxys.Count; i++)
            {
                if (proxys[i].type == "")
                    result = false;
            }

            return result;
        }

        public void setTypeProxy(string type)
        {
            for(int i = 0; i < proxys.Count; i++)
            {
                proxys[i].type = type;
            }
            main.typeProxy = type;
        }

        private void radioBtnSocks4_CheckedChanged(object sender, EventArgs e)
        {
            setTypeProxy("Socks4");
        }

        private void radioBtnSocks5_CheckedChanged(object sender, EventArgs e)
        {
            setTypeProxy("Socks5");
        }

        private void radioBtnHTTP_CheckedChanged(object sender, EventArgs e)
        {
            setTypeProxy("HTTP");
        }
    }
}
