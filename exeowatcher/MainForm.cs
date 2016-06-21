using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Windows.Forms;


using DiffMatchPatch;


namespace exeowatcher
{
    public partial class MainForm : Form
    {


        private List<classes.Site> sites = new List<classes.Site>();
        private string twoFileSuffix = "_2";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new classes.ColorMenuStrip());
        }

        private List<string> getHTML(string urlAddress)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                List<string> data = new List<string>();
                while (!readStream.EndOfStream)
                { 
                    data.Add(readStream.ReadLine());
                }

                response.Close();
                readStream.Close();

                return data;
            }
            return null;
        }

        private void fillSiteHtmlToFile(string urlAddress)
        {
            List<string> content = getHTML(urlAddress);

            int index = sites.FindIndex(x => x.site == urlAddress);
            string fileName = deleteInvalidChars(sites[index].site);


            if (content == null)
            {
                MessageBox.Show("Site: " + urlAddress + "\terror scan");
                return;
            }


            switch(checkEmptyFile(fileName))
            {
                case "NotExist":
                        writeToFile(content, fileName);
                    break;

                case "Empty":
                        writeToFile(content, fileName);
                    break;

                case "TwoFileNotExist":
                        writeToFile(content, fileName + twoFileSuffix);
                        compareCode(fileName);
                    break;

                case "TwoFileEmpty":
                        writeToFile(content, fileName + twoFileSuffix);
                        compareCode(fileName);
                    break;

                case "TwoFileNotEmpty":
                        writeToFile(readFromFile(fileName + twoFileSuffix), fileName);
                        writeToFile(content, fileName + twoFileSuffix);
                        compareCode(fileName);
                    break;
            }
        }


        public void updateStatusSite(int indexList, int indexSite)
        {
            listViewSites.Items[indexList] = (new ListViewItem(new string[] { sites[indexSite].site, DateTime.Now.ToString() , sites[indexSite].pages.Count.ToString(), "X", "X", "X", "X", "X", "X", "X", }));
        }

        public string checkEmptyFile(string fileName)
        {
            string result = "";

            if (!(new FileInfo(fileName + ".txt").Exists))
            {
                result = "NotExist";
                return result;
            }

            if (new FileInfo(fileName + ".txt").Length == 0)
            {
                result = "Empty";
                return result;
            }

            if (!(new FileInfo(fileName + twoFileSuffix + ".txt").Exists))
            {
                result = "TwoFileNotExist";
                return result;
            }

            if (new FileInfo(fileName + twoFileSuffix + ".txt").Length == 0)
            {
                result = "TwoFileEmpty";
                return result;
            }
            else
            {
                result = "TwoFileNotEmpty";
                return result;
            }

            return result;
        }

        public string deleteInvalidChars(string fileName)
        {
            char[] charInvalidFileChars = Path.GetInvalidFileNameChars();
            foreach (char charInvalid in charInvalidFileChars)
            {
                fileName = fileName.Replace(charInvalid, ' ');
            }

            return fileName;
        }

        public void compareCode(string fileName)
        {

            List<string> prevText = readFromFile(fileName);
            List<string> currText = readFromFile(fileName + twoFileSuffix);

          
            var dmp = new diff_match_patch();
            var d = dmp.diff_main(ListToStr(prevText), ListToStr(currText));
            List<DiffMatchPatch.Diff> dl = d;

            richTxtResult.Text = "";
            for(int i = 0; i < dl.Count; i++)
            {
                switch(dl[i].operation)
                {
                    /*case DiffMatchPatch.Operation.EQUAL:
                            AppendText(this.richTxtResult, Color.Empty, dl[i].text);
                        break;*/
                    case DiffMatchPatch.Operation.INSERT:
                            AppendText(this.richTxtResult, Color.Green, dl[i].text);
                        break;
                    case DiffMatchPatch.Operation.DELETE:
                            AppendText(this.richTxtResult, Color.Red, dl[i].text);
                        break;
                }
            }
            
        }

        void AppendText(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;

            box.Select(start, end - start);
            {
                box.SelectionColor = color;
            }
            box.SelectionLength = 0; // clear
        }

        private void writeToFile(List<string> content, string fileName)
        {
            File.WriteAllLines(fileName + ".txt", content);
        }

        private static string ListToStr(List<string> array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('\n');
            }
            return builder.ToString();
        }


        private static List<string> readFromFile(string fileName)
        {

            List<string> listLines = new List<string>();

            using (StreamReader sr = new StreamReader(File.Open(fileName + ".txt", FileMode.Open)))
            {
                while (!sr.EndOfStream)
                    listLines.Add(sr.ReadLine());
            }
           
            return listLines;
        }

        private DateTime getFileName(int index)
        {
            DateTime result;

            result = sites[index].latestScan;

            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSite addSiteForm = new AddSite();
            addSiteForm.Owner = this;
            addSiteForm.Show(); 
        }


        public void AddSite(string site, List<string> pages)
        {
            sites.Add(new classes.Site(site, new DateTime(1990, 01, 01), pages.Count, pages));
            listViewSites.Items.Add(new ListViewItem(new string[] { site, "не сканировался", pages.Count.ToString(), "X", "X", "X", "X", "X", "X", "X", }));
        }

        public void EditSite(string site, List<string> pages, int indexSites, int indexListView)
        {
            sites[indexSites] = new classes.Site(site, new DateTime(1990, 01, 01), pages.Count, pages);
            listViewSites.Items[indexListView] = (new ListViewItem(new string[] { site, "не сканировался", pages.Count.ToString(), "X", "X", "X", "X", "X", "X", "X", }));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(listViewSites.Items.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один сайт.");
                return;
            }

            if(listViewSites.CheckedItems.Count == 0)
            {
                MessageBox.Show("Отметьте галочкой сайты, которые хотите просканировать");
                return;
            }



            for(int i = 0; i < sites.Count; i++)
            {
                for(int j = 0; j < sites[i].pages.Count; j++)
                {
                    fillSiteHtmlToFile(sites[i].pages[j]);
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewSites.CheckedItems.Count == 0)
            {
                MessageBox.Show("Отметьте галочкой один сайт");
                return;
            }

            for (int i = 0; i < listViewSites.Items.Count; i++)
            {
                if(listViewSites.Items[i].Checked)
                {

                    for (int j = 0; j < sites.Count; j++)
                    {
                        if (sites[j].site == listViewSites.Items[i].Text)
                        {
                            sites.RemoveAt(j);
                        }
                    }

                    listViewSites.Items[i].Remove();
                }       
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewSites.CheckedItems.Count == 0)
            {
                MessageBox.Show("Отметьте галочкой один сайт");
                return;
            }
            if (listViewSites.CheckedItems.Count > 1)
            {
                MessageBox.Show("Отметьте галочкой всего лишь один сайт");
                return;
            }

            for (int i = 0; i < listViewSites.Items.Count; i++)
            {
                if (listViewSites.Items[i].Checked)
                {
                    for(int j = 0; j < sites.Count; j++)
                    {
                        if (sites[j].site == listViewSites.Items[i].Text)
                        {

                            int indexSites = j;
                            int indexListView = i;


                            AddSite addSiteForm = new AddSite(sites[j].site, sites[j].pages, indexSites, indexListView);
                            addSiteForm.Owner = this;
                            addSiteForm.Show();
                        }
                    }
                    
                }
            }

        }


    }
}
