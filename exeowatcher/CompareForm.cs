
using exeowatcher.classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace exeowatcher
{
    public partial class CompareForm : Form
    {
        //private string prevText;
        //private string currText;
        //private string compareText;
        private string site;
        private List<Site> sites;
        private MainForm main;

        public CompareForm()
        {
            InitializeComponent();
        }

        internal CompareForm(string site)
        {
            this.site = site;
            InitializeComponent();
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            string json = "";

            using (StreamReader sr = new StreamReader(File.Open("info.json", FileMode.Open)))
            {
                    json += sr.ReadToEnd();
            }

            sites = JsonConvert.DeserializeObject<List<Site>>(json);
            int index = sites.FindIndex(x => x.site == site);

            for (int i = 0; i < sites[index].pages.Count; i++)
            {
                listViewSites.Items.Add(new ListViewItem(new string[] { sites[index].pages[i].pageName, sites[index].pages[i].countChanges.ToString()}));
            }
        }
    }
}
