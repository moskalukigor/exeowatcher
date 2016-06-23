using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace exeowatcher
{
    public partial class SettingsForm : Form
    {

        private List<string> tags = new List<string>();
        MainForm main;


        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(List<string> tags)
        {
            this.tags = tags;
            InitializeComponent();
            fillCheckBoxList();
        }


        private void SettingsForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;

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

            main.tags = new List<string>();
            foreach (string s in checkedListBoxTags.CheckedItems)
            {
                main.tags.Add(s);
            }

            string json = JsonConvert.SerializeObject(main.tags, Formatting.Indented);
            File.WriteAllText("settings.json", json);

            this.Close();
        }


    }
}
