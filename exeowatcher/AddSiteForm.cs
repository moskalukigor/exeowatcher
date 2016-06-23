using exeowatcher.classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace exeowatcher
{
    public partial class AddSiteForm : Form
    {

        private MainForm main;
        private string site;
        private List<Page> pages;
        private bool typeForm;          // 0(false) - add , 1(true) - edit

        int indexSites;
        int indexListView;

        public AddSiteForm()
        {
            typeForm = false;
            pages = new List<Page>();
            InitializeComponent();
        }
        internal AddSiteForm(string site, List<Page> pages,int indexSites, int indexListView)
        {
            typeForm = true;
            this.site = site;
            this.pages = pages;
            this.indexSites = indexSites;
            this.indexListView = indexListView;
            InitializeComponent();
        }

        private void AddSite_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            if(typeForm)
            {
                txtBoxSite.Text = site;
                for(int i = 0; i < pages.Count; i++)
                {
                    listBoxPages.Items.Add(pages[i].pageName);
                }
                pages = new List<Page>();
            }
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


            for(int i = 0; i < listBoxPages.Items.Count; i++)
            {
                pages.Add(new Page(listBoxPages.Items[i].ToString(), 0));
            }


            if (main == null)
            {
                MessageBox.Show("NULL main form");
                return;
            }

            if (!typeForm)
            {
                main.AddSite(txtBoxSite.Text, pages);
            }
            else
            {
                main.EditSite(txtBoxSite.Text, pages, indexSites, indexListView);
            }
            this.Close();
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
