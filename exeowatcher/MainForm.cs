using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;


using DiffMatchPatch;
using CsQuery;
using exeowatcher.classes;
using Newtonsoft.Json;

namespace exeowatcher
{
    public partial class MainForm : Form
    {
        private List<Site> sites = new List<Site>();
        public List<string> tags = new List<string>();
        public string twoFileSuffix = "_2";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new ColorMenuStrip());
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

        private void fillSiteHtmlToFile(string urlAddress, int indexList)
        {
            List<string> content = getHTML(urlAddress);

            int index = sites[indexList].pages.FindIndex(x => x.pageName == urlAddress);
            string fileName = deleteInvalidChars(sites[indexList].pages[index].pageName);
            string parentDir = deleteInvalidChars(sites[indexList].site);


            if (content == null)
            {
                MessageBox.Show("Site: " + urlAddress + "\terror scan");
                return;
            }


            switch (checkEmptyFile(fileName, parentDir))
            {
                case "NotExist":
                    writeToFile(content, fileName, parentDir);
                    updateStatusSite(indexList, index);
                    break;

                case "Empty":
                    writeToFile(content, fileName, parentDir);
                    updateStatusSite(indexList, index);
                    break;

                case "TwoFileNotExist":
                    writeToFile(content, fileName + twoFileSuffix, parentDir);
                    compareCode(parentDir, fileName, index, indexList);
                    break;

                case "TwoFileEmpty":
                    writeToFile(content, fileName + twoFileSuffix, parentDir);
                    compareCode(parentDir, fileName, index, indexList);
                    break;

                case "TwoFileNotEmpty":
                    writeToFile(readFromFile(fileName + twoFileSuffix, parentDir), fileName, parentDir);
                    writeToFile(content, fileName + twoFileSuffix, parentDir);
                    compareCode(parentDir, fileName, index, indexList);
                    break;
            }
        }

        public void updateStatusSite(int indexList, int indexSite)
        {
            listViewSites.Items[indexList] = (new ListViewItem(new string[] { sites[indexList].site, DateTime.Now.ToString(), sites[indexList].pages.Count.ToString(), "X", "X", "X", "X", "X", "X", "X", }));
        }

        public string checkEmptyFile(string fileName, string parentDir)
        {
            string result = "";

            if (!(new FileInfo(parentDir + "/" + fileName + ".txt").Exists))
            {
                result = "NotExist";
                return result;
            }

            if (new FileInfo(parentDir + "/" + fileName + ".txt").Length == 0)
            {
                result = "Empty";
                return result;
            }

            if (!(new FileInfo(parentDir + "/" + fileName + twoFileSuffix + ".txt").Exists))
            {
                result = "TwoFileNotExist";
                return result;
            }

            if (new FileInfo(parentDir + "/" + fileName + twoFileSuffix + ".txt").Length == 0)
            {
                result = "TwoFileEmpty";
                return result;
            }
            else
            {
                result = "TwoFileNotEmpty";
                return result;
            }
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

        public void compareCode(string parentDir, string fileName, int indexPage, int indexList)
        {


            string prevText = ListToStr(readFromFile(fileName, parentDir));
            string currText = ListToStr(readFromFile(fileName + twoFileSuffix, parentDir));

            string tags_prevText = "", tags_currText = "";
            int countChanges = 0;

            tags_prevText = parseHTML(prevText);
            tags_currText = parseHTML(currText);

            compare(null, ref countChanges, tags_prevText, tags_currText);

            sites[indexList].pages[indexPage].countChanges = countChanges;
            updateStatusSite(indexList, indexPage);

        }

        public string parseHTML(string text)
        {
            string tagsText = "";

            for (int i = 0; i < tags.Count; i++)
            {
                CQ dom = text;
                CQ tg = dom[tags[i]];

                tagsText += tags[i] + ":\n";
                for (int j = 0; j < tg.ToList().Count(); j++)
                {
                    tagsText += tg[j].FirstChild + "\n";
                }
            }

            return tagsText;
        }

        public void compare(RichTextBox rtbx, ref int countChanges, string tags_prevText, string tags_currText)
        {
            var dmp = new diff_match_patch();
            var d = dmp.diff_main(tags_prevText, tags_currText);
            List<Diff> dl = d;


            if(rtbx != null)
            {
                for (int i = 0; i < dl.Count; i++)
                {
                    switch (dl[i].operation)
                    {
                        case DiffMatchPatch.Operation.EQUAL:
                            AppendText(rtbx, Color.Empty, dl[i].text);
                            break;
                        case DiffMatchPatch.Operation.INSERT:
                            countChanges++;
                            AppendText(rtbx, Color.Green, dl[i].text);
                            break;
                        case DiffMatchPatch.Operation.DELETE:
                            countChanges++;
                            AppendText(rtbx, Color.Red, dl[i].text);
                            break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dl.Count; i++)
                {
                    switch (dl[i].operation)
                    {
                        case DiffMatchPatch.Operation.EQUAL:
                            break;
                        case DiffMatchPatch.Operation.INSERT:
                            countChanges++;
                            break;
                        case DiffMatchPatch.Operation.DELETE:
                            countChanges++;
                            break;
                    }
                }
            }
            
        }

        private void AppendText(RichTextBox box, Color color, string text)
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

        private void writeToFile(List<string> content, string fileName, string parentDir)
        {
            if (!Directory.Exists(parentDir))
            {
                Directory.CreateDirectory(parentDir);
            }
            File.WriteAllLines(parentDir + "/" + fileName + ".txt", content);
        }

        public string ListToStr(List<string> array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('\n');
            }
            return builder.ToString();
        }

        public List<string> readFromFile(string fileName, string parentDir)
        {

            List<string> listLines = new List<string>();

            if (parentDir != null)
            {
                using (StreamReader sr = new StreamReader(File.Open(parentDir + "/" + fileName + ".txt", FileMode.Open)))
                {
                    while (!sr.EndOfStream)
                        listLines.Add(sr.ReadLine());
                }
            }
            else
            {
                using (StreamReader sr = new StreamReader(File.Open(fileName + ".txt", FileMode.Open)))
                {
                    while (!sr.EndOfStream)
                        listLines.Add(sr.ReadLine());
                }
            }

            return listLines;
        }

        private DateTime getLatestScan(int index)
        {
            DateTime result;

            result = sites[index].latestScan;

            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSiteForm addSiteForm = new AddSiteForm();
            addSiteForm.Owner = this;
            addSiteForm.Show();
        }

        internal void AddSite(string site, List<Page> pages)
        {
            if (!Directory.Exists(deleteInvalidChars(site)))
            {
                Directory.CreateDirectory(deleteInvalidChars(site));
            }
            sites.Add(new Site(site, new DateTime(1990, 01, 01), pages.Count, pages));
            listViewSites.Items.Add(new ListViewItem(new string[] { site, "не сканировался", pages.Count.ToString(), "X", "X", "X", "X", "X", "X", "X", }));
        }

        internal void EditSite(string site, List<Page> pages, int indexSites, int indexListView)
        {
            if (site != sites[indexSites].site && !Directory.Exists(deleteInvalidChars(site)))
            {
                string newDir = deleteInvalidChars(site);
                string prevDir = deleteInvalidChars(sites[indexSites].site);

                Directory.CreateDirectory(newDir);
                copyFilesTo(prevDir, newDir);
                deleteDirectory(prevDir);
                //Directory.Delete(prevDir);
            }
            sites[indexSites] = new Site(site, new DateTime(1990, 01, 01), pages.Count, pages);
            listViewSites.Items[indexListView] = (new ListViewItem(new string[] { site, "не сканировался", pages.Count.ToString(), "X", "X", "X", "X", "X", "X", "X", }));
        }

        private void deleteDirectory(string directory)
        {
            DirectoryInfo dir = new DirectoryInfo(directory);

            foreach (var item in dir.GetFiles())
            {
                item.Delete();
            }
            Directory.Delete(directory);
        }

        private void copyFilesTo(string prevDir, string newDir)
        {
            DirectoryInfo source = new DirectoryInfo(prevDir);
            DirectoryInfo destin = new DirectoryInfo(newDir);

            foreach(var item in source.GetFiles())
            {
                item.CopyTo(destin + "/" + item.Name, true);
            }
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
            if(tags.Count == 0)
            {
                MessageBox.Show("Вы не выбрали теги для проверки. Закройте это окно, чтобы выбрать.");
                SettingsForm sf = new SettingsForm();
                sf.Owner = this;
                sf.Show();
                return;
            }


            for (int i = 0; i < listViewSites.Items.Count; i++)
            {
                if(!listViewSites.Items[i].Checked)
                {
                    continue;
                }
                for (int j = 0; j < sites[i].pages.Count; j++)
                {
                    var indexItemList = listViewSites.FindItemWithText(sites[i].site);
                    if (indexItemList != null)
                        fillSiteHtmlToFile(sites[i].pages[j].pageName, indexItemList.Index);
                }
            }



            string json = JsonConvert.SerializeObject(sites, Formatting.Indented);
            File.WriteAllText("info.json",json);


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


                            AddSiteForm addSiteForm = new AddSiteForm(sites[j].site, sites[j].pages, indexSites, indexListView);
                            addSiteForm.Owner = this;
                            addSiteForm.Show();
                        }
                    }
                    
                }
            }

        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Owner = this;
            sf.Show();
        }

        private void showCompareToolStripMenuItem_Click(object sender, EventArgs e)
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
                    string fileName = deleteInvalidChars(sites[i].pages[0].pageName);
                    string dirName = deleteInvalidChars(sites[i].site);

                    if (File.Exists(dirName + "/" + fileName + ".txt") && File.Exists(dirName + "/" + fileName + twoFileSuffix + ".txt"))
                    {
                        CompareForm cf = new CompareForm(sites[i].site);
                        cf.Owner = this;
                        cf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Сначала просканируйте сайт, чтобы посмотреть различия");
                        return;
                    }

                }
            }         
        }
    }
}
