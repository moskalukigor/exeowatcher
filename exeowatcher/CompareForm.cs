
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

        private string site;
        private List<Site> sitesInfo;
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

            sitesInfo = JsonConvert.DeserializeObject<List<Site>>(json);
            int index = sitesInfo.FindIndex(x => x.site == site);

            for (int i = 0; i < sitesInfo[index].pages.Count; i++)
            {
                listViewSites.Items.Add(new ListViewItem(new string[] { sitesInfo[index].pages[i].pageName, sitesInfo[index].pages[i].countChanges.ToString()}));
            }

            
        }

        private void listViewSites_DoubleClick(object sender, EventArgs e)
        {
            tabControlCompare.SelectedIndex = 3; //tabCompare - вкладка сравнения
            fillTabs(listViewSites.SelectedItems[0].Text);
        }

        private void fillTabs(string page)
        {
            int countChanges = 0;
            string fileName = main.deleteInvalidChars(page);
            string dirName = main.deleteInvalidChars(site);
            List<string> textPrevList = main.readFromFile(fileName, dirName);
            List<string> textCurrList = main.readFromFile(fileName + main.twoFileSuffix, dirName);
            string textPrev = main.ListToStr(textPrevList);
            string textCurr = main.ListToStr(textCurrList);
            string tags_prevText = "";
            string tags_currText = "";

            tags_prevText = main.parseHTML(textPrev);
            tags_currText = main.parseHTML(textCurr);

            richTextBoxPrev.Text = main.ListToStr(textPrevList);
            richTextBoxCurrent.Text = main.ListToStr(textCurrList);
            richTextBoxCompare.Text = "";

            main.compare(this.richTextBoxCompare,ref countChanges, tags_prevText, tags_currText);
        }
    }
}
