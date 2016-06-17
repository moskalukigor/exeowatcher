using System;
using System.Windows.Forms;

namespace exeowatcher
{
    public partial class AddSite : Form
    {

        MainForm main;

        public AddSite()
        {
            InitializeComponent();
        }
        private void AddSite_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
        }

        private void txtBoxSite_TextChanged(object sender, EventArgs e)
        {
            txtBoxPage.Text = txtBoxSite.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            if (listBoxPages.Items.Count == 0)
            {
                if (checkValidUrl(txtBoxPage.Text))
                { 
                    listBoxPages.Items.Add(txtBoxPage.Text);
                    return;
                }
                else
                { 
                    MessageBox.Show("Некорректный адрес страницы. Пример: http://site.com/page");
                    return;
                }      
            }

            for (int i = 0; i < listBoxPages.Items.Count; i++)
            {
                if (listBoxPages.Items[i].ToString() == txtBoxPage.Text)
                {
                    MessageBox.Show("Такая страница уже существует");
                }
                else
                {
                    if (checkValidUrl(txtBoxPage.Text))
                    {
                        listBoxPages.Items.Add(txtBoxPage.Text);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Некорректный адрес страницы. Пример: http://site.com/page");
                        return;
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(!checkValidUrl(txtBoxPage.Text))
            {
                MessageBox.Show("Некорректный адрес сайта. Пример: http://site.com");
                return;
            }
            if(listBoxPages.Items.Count == 0)
            {
                MessageBox.Show("Вы должны добавить хотя бы одну страницу.");
                return;
            }

            if (main != null)
                main.AddSite(txtBoxPage.Text);
            else
                MessageBox.Show("NULL main form");
        }

        private bool checkValidUrl(string uri)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(uri, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result;
        }


    }
}
