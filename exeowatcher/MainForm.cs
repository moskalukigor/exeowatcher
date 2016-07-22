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
using System.Runtime.InteropServices;
using System.Threading;
using xNet;

namespace exeowatcher
{
    public partial class MainForm : Form
    {
        public List<Thread> thread = new List<Thread>();


        List<Site> sites = new List<Site>();
        public List<Proxy> proxys = new List<Proxy>();
        public List<string> tags = new List<string>();
        public string typeProxy;
        public string twoFileSuffix = "_2";
        public string saveDir = "saved";
        private string nameLastSave = "";
        public int countSource = 0;
        public int counterAcc = -1;
        public int counterProxy = 0;
        private bool isRunning = false;
        public Point mouse_offset;


        //Анимация цвета кнопок
        Color oldColor;
        Color newColor = Color.FromArgb(0, Color.Black);
        int alpha = 0;

        public MainForm()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(816, 561);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new ColorMenuStrip());

            if (File.Exists("settings.json"))
            {
                string json = "";

                using (StreamReader sr = new StreamReader(File.Open("settings.json", FileMode.Open)))
                {
                    json += sr.ReadToEnd();
                }

                Settings settings;
                settings = JsonConvert.DeserializeObject<Settings>(json);

                tags = settings.tags;
                proxys = settings.proxys;
                typeProxy = settings.typeProxy;
                
            }

            listViewSites.Visible = false;
            btnImgStart.Enabled = false;
            btnImgStop.Enabled = false;
            btnImgAdd.Enabled = false;
            btnImgDelete.Enabled = false;
            btnImgEdit.Enabled = false;
        }

        public ListView getListViewSites()
        {
            return listViewSites;
        }

        private string getHTML(string urlAddress)
        {
            using (var request = new HttpRequest())
            {
                request.UserAgent = Http.ChromeUserAgent();

                if (typeProxy != "none" && proxys.Count > 0)
                {
                    string proxy = "";
                    if (proxys[counterProxy].login != null)
                        proxy = String.Format("{0}:{1}:{2}:{3}", proxys[counterProxy].ip, proxys[counterProxy].port, proxys[counterProxy].login, proxys[counterProxy].password);
                    else
                        proxy = String.Format("{0}:{1}", proxys[counterProxy].ip, proxys[counterProxy].port);

                    switch (typeProxy)
                    {
                        case "HTTP": request.Proxy = HttpProxyClient.Parse(proxy); counterProxy++;      break;
                        case "Socks4": request.Proxy = Socks4ProxyClient.Parse(proxy); counterProxy++;  break;
                        case "Socks5": request.Proxy = Socks5ProxyClient.Parse(proxy); counterProxy++;  break;
                    }
                    if (counterProxy == proxys.Count)
                        counterProxy = 0;
                }

                HttpResponse response;
                string content = "";
                try
                {
                    if (request.Proxy != null)
                        MessageBox.Show("(TEST, потом уберётся)Используется прокси: " + proxys[counterProxy-1].ip + ":" + proxys[counterProxy-1].port);
                    response = request.Get(urlAddress);
                    content = response.ToString();
                    return content;
                }
                catch(HttpException ex)
                {
                    MessageBox.Show(urlAddress + "\tНе отвечает");
                    return null;
                }

            }   
            return null;
        }

        public void preparationToWrite(string urlAddress, int indexList)
        {
            string content = getHTML(urlAddress);

            if (content == null)
            {
                return;
            }

            int index = sites[indexList].pages.FindIndex(x => x.pageName == urlAddress);
            string fileName = deleteInvalidChars(sites[indexList].pages[index].pageName);
            string parentDir = deleteInvalidChars(sites[indexList].site);

            writeSiteToFile( fileName, parentDir, index, indexList, content);
           
        }

        public void writeSiteToFile(string fileName, string parentDir, int index, int indexList, string content)
        {
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
            sites[indexList].latestScan = DateTime.Now;
            //sites[indexList].tags.
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
            if(parentDir == null && fileName == "")
            {
                return;
            }

            string prevText = readFromFile(fileName, parentDir);
            string currText = readFromFile(fileName + twoFileSuffix, parentDir);

            string tags_prevText = "", tags_currText = "";
            int countChanges = 0;

            tags_prevText = parseHTML(prevText);
            tags_currText = parseHTML(currText);

            compare(null, ref countChanges, tags_prevText, tags_currText);

            //Tags tags = new Tags(sd);

            sites[indexList].pages[indexPage].countChanges = countChanges;
            updateStatusSite(indexList, indexPage);

        }

        public string parseHTML(string text)
        {

            if(text == "")
            {
                return null;
            }

            string tagsText = "";
            CQ dom = text;
            CQ tg = null;

            //string test = "";

            for (int i = 0; i < tags.Count; i++)
            {
                

                switch (tags[i])
                {
                    case "Description":
                            tg = dom["meta[name=description]"];
                        break;

                    case "Keywords":
                            tg = dom["meta[name=keywords]"];
                        break;

                    default:
                            tg = dom[tags[i]];
                        break;

                }


                

                tagsText += tags[i] + ":\n";
                for (int j = 0; j < tg.ToList().Count(); j++)
                {
                    switch (tags[i])
                    {
                        case "Description": tagsText += tg[j].GetAttribute("content") + "\n";  break;
                        case "Keywords": tagsText += tg[j].GetAttribute("content") + "\n"; break;
                        default: tagsText += tg[j].FirstChild + "\n"; break;
                    }
                    
                }
            }

            return tagsText;
        }

        public void compare(RichTextBox rtbx, ref int countChanges, string tags_prevText, string tags_currText)
        {

            if (rtbx == null || tags_prevText == "" || tags_currText == "")
            {
                return;
            }

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
            if (box == null)
                return;

            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;

            box.Select(start, end - start);
            {
                box.SelectionColor = color;
            }
            box.SelectionLength = 0; // clear
        }

        private void writeToFile(string content, string fileName, string parentDir)
        {
            if(content == null || fileName == null || parentDir == null)
            {
                return;
            }

            if (!Directory.Exists(parentDir))
            {
                Directory.CreateDirectory(parentDir);
            }
            File.WriteAllText(parentDir + "/" + fileName + ".txt", content);
        }

        public string ListToStr(List<string> array)
        {
            if(array == null)
            {
                return null;
            }

            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('\n');
            }
            return builder.ToString();
        }

        public string readFromFile(string fileName, string parentDir)
        {

            string text = "";

            if (parentDir != null)
            {
                try
                { 
                    using (StreamReader sr = new StreamReader(File.Open(parentDir + "/" + fileName + ".txt", FileMode.Open)))
                    {
                        while (!sr.EndOfStream)
                            text += sr.ReadLine() + "\n";
                    }
                }
                catch(FileNotFoundException ex)
                {
                    MessageBox.Show(System.String.Format("Файл с именем {0}.txt не найден. Пересканируйте или удалите сайт/страницу из списка.", fileName));
                    return null;
                }
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(File.Open(fileName + ".txt", FileMode.Open)))
                    {
                        while (!sr.EndOfStream)
                            text += sr.ReadLine() + "\n";
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(System.String.Format("Файл с именем {0}.txt не найден. Пересканируйте или удалите сайт/страницу из списка.", fileName));
                    return null;
                }
            }
            return text;
        }

        private DateTime getLatestScan(int index)
        {
            DateTime result;

            result = sites[index].latestScan;

            return result;
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

        internal void AddSiteOfFile(Site site)
        {
            if (!Directory.Exists(deleteInvalidChars(site.site)))
            {
                Directory.CreateDirectory(deleteInvalidChars(site.site));
            }
            listViewSites.Items.Add(new ListViewItem(new string[] { site.site, site.latestScan.ToString() , site.pages.Count.ToString(), "X", "X", "X", "X", "X", "X", "X", }));
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
            if (dir == null)
            {
                return;
            }

            foreach (var item in dir.GetFiles())
            {
                item.Delete();
            }
            Directory.Delete(directory);
        }

        //Когда переименовывается название сайта, данные перемещаются в другую папку
        private void copyFilesTo(string prevDir, string newDir)
        {
            DirectoryInfo source = new DirectoryInfo(prevDir);
            DirectoryInfo destin = new DirectoryInfo(newDir);

            foreach(var item in source.GetFiles())
            {
                item.CopyTo(destin + "/" + item.Name, true);
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(tags, proxys, typeProxy);
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



            int indexList = 0;
            string fileName = "";

            for (int i = 0; i < listViewSites.Items.Count; i++)
            {
                if (!listViewSites.Items[i].Checked)
                {
                    continue;
                }
                for (int j = 0; j < sites[i].pages.Count; j++)
                {
                    var indexItemList = listViewSites.FindItemWithText(sites[i].site);
                    indexList = indexItemList.Index;
                    int index = sites[indexList].pages.FindIndex(x => x.pageName == sites[i].pages[j].pageName);
                    fileName = deleteInvalidChars(sites[indexList].pages[index].pageName);
                    string parentDir = deleteInvalidChars(sites[indexList].site);


                    string json = JsonConvert.SerializeObject(sites, Formatting.Indented);
                    File.WriteAllText("info.json", json);


                    fileName = deleteInvalidChars(sites[indexList].pages[0].pageName);
                    string dirName = deleteInvalidChars(sites[indexList].site);

                    if (File.Exists(dirName + "/" + fileName + ".txt") && File.Exists(dirName + "/" + fileName + twoFileSuffix + ".txt"))
                    {
                        if (indexItemList != null)
                            compareCode(parentDir, fileName, index, indexList);

                        CompareForm cf = new CompareForm(sites[indexList].site);
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        void DoWork(object data)
        {
            Data dt = (Data)data;


            //------------------------------------------WARNING----------------------------------------
            //------------------------------------------WARNING----------------------------------------
            //------------------------------------------WARNING----------------------------------------
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false; //ВОТ ЭТУ ЗАГЛУШКУ ОБЯЗАТЕЛЬНО ПОТОМ УБРАТЬ и ЗАМЕНИТЬ
            //------------------------------------------WARNING----------------------------------------
            //------------------------------------------WARNING----------------------------------------
            //------------------------------------------WARNING----------------------------------------


            var indexItemList = listViewSites.FindItemWithText(sites[dt.i].site);
            if (indexItemList != null)
                preparationToWrite(sites[dt.i].pages[dt.j].pageName, indexItemList.Index);
        }


        #region Buttons

        private void btnImgStart_Click(object sender, EventArgs e)
        {
            if (isRunning == true)
            {
                for (int i = 0; i < thread.Count; i++)
                {
                    thread[i].Abort();
                }
                isRunning = false;
                return;
            }


            if (listViewSites.Items.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один сайт.");
                return;
            }

            if (listViewSites.CheckedItems.Count == 0)
            {
                MessageBox.Show("Отметьте галочкой сайты, которые хотите просканировать");
                return;
            }
            if (tags.Count == 0)
            {
                MessageBox.Show("Вы не выбрали теги для проверки. Закройте это окно, чтобы выбрать.");
                SettingsForm sf = new SettingsForm();
                sf.Owner = this;
                sf.Show();
                return;
            }


            if (isRunning == false)
            {
                btnImgStart.Image = Properties.Resources.stop;
                isRunning = true;
            }

            

            thread = new List<Thread>();


            for (int i = 0; i < listViewSites.Items.Count; i++)
            {
                if (!listViewSites.Items[i].Checked)
                {
                    continue;
                }
                for (int j = 0; j < sites[i].pages.Count; j++)
                {
                    Data dt = new Data();
                    dt.i = i;
                    dt.j = j;

                    thread.Add(new Thread(new ParameterizedThreadStart(DoWork)));
                    if (thread[j] != null && thread[j].IsAlive == false)
                        thread[j].Start(dt);
                }
            }

                    
              

            



            if (backgroundWorkerWaitThread.IsBusy == false)
                backgroundWorkerWaitThread.RunWorkerAsync();



        }

        private void btnImgStop_Click(object sender, EventArgs e)
        {

        }

        private void btnImgAdd_Click(object sender, EventArgs e)
        {
            AddSiteForm addSiteForm = new AddSiteForm();
            addSiteForm.Owner = this;
            addSiteForm.Show();
        }

        private void btnImgDelete_Click(object sender, EventArgs e)
        {
            if (listViewSites.CheckedItems.Count == 0)
            {
                MessageBox.Show("Отметьте галочкой один сайт");
                return;
            }

            for (int i = 0; i < listViewSites.Items.Count; i++)
            {
                if (listViewSites.Items[i].Checked)
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

        private void btnImgEdit_Click(object sender, EventArgs e)
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
                    for (int j = 0; j < sites.Count; j++)
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

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void обратнаяСвязьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback feedBackForm = new Feedback();
            feedBackForm.Show();
        }

        private void помощьПроектуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donate donateForm = new Donate();
            donateForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewSites.Items.Count == 0)
            {
                MessageBox.Show("В списке нету сайтов для сохранения");
                return;
            }

            if (!Directory.Exists(saveDir))
            {
                Directory.CreateDirectory(saveDir);
            }

            if (nameLastSave == "")
            {
                nameLastSave = saveDir + "/" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + "_" +
                                                DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".exeo";
            }

            string file = nameLastSave;

            string json = JsonConvert.SerializeObject(sites, Formatting.Indented);
            File.WriteAllText(file, json);

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewSites.Items.Count == 0)
            {
                MessageBox.Show("В списке нету сайтов для сохранения");
                return;
            }


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Exeo Files |*.exeo";
            saveFileDialog.InitialDirectory = saveDir;
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.ShowDialog();


            if (saveFileDialog.FileName == "")
                return;

            string file = saveFileDialog.FileName;

            string json = JsonConvert.SerializeObject(sites, Formatting.Indented);
            File.WriteAllText(file, json);
        }

        private void openPicBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exeo Files |*.exeo";
            openFileDialog.InitialDirectory = saveDir;
            openFileDialog.FilterIndex = 0;
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName == "")
                return;

            nameLastSave = openFileDialog.FileName;

            createPicBox.Visible = false;
            openPicBox.Visible = false;
            listViewSites.Visible = true;
            btnImgStart.Enabled = true;
            btnImgStop.Enabled = true;
            btnImgAdd.Enabled = true;
            btnImgDelete.Enabled = true;
            btnImgEdit.Enabled = true;


            string json = "";
            using (StreamReader sr = new StreamReader(File.Open(openFileDialog.FileName, FileMode.Open)))
            {
                json += sr.ReadToEnd();
            }

            List<Site> sitesJson = JsonConvert.DeserializeObject<List<Site>>(json);

            sites = sitesJson;
            listViewSites.Items.Clear();

            for (int i = 0; i < sitesJson.Count; i++)
            {
                AddSiteOfFile(sitesJson[i]);
            }
        }

        #endregion

        #region Timers
        private void timerStop(System.Windows.Forms.Timer tm, PictureBox btn)
        {
            tm.Stop();
            btn.BackColor = oldColor;
            btn.ForeColor = Color.Black;
        }
        private void timerStart(System.Windows.Forms.Timer tm)
        {
            alpha = 0;
            tm.Interval = 15;
            tm.Start();
        }
        private void timerTick(System.Windows.Forms.Timer tm, PictureBox btn)
        {
            alpha += 17;
            btn.BackColor = Color.FromArgb(alpha, newColor);
            if (alpha >= 255) tm.Stop();
            if (btn.BackColor.GetBrightness() < 0.3) btn.ForeColor = Color.White;
        }
        private void btnImgAdd_MouseEnter(object sender, EventArgs e) { timerStart(timerBtnAdd); }
        private void btnImgStart_MouseEnter(object sender, EventArgs e) { timerStart(timerBtnStart); }
        private void btnImgDelete_MouseEnter(object sender, EventArgs e) { timerStart(timerBtnDelete); }
        private void btnImgEdit_MouseEnter(object sender, EventArgs e) { timerStart(timerBtnEdit); }
        private void btnImgStop_MouseEnter(object sender, EventArgs e) { timerStart(timerBtnStop); }
        private void btnImgStop_MouseLeave(object sender, EventArgs e) { timerStop(timerBtnStop, btnImgStop); }
        private void btnImgDelete_MouseLeave(object sender, EventArgs e) { timerStop(timerBtnDelete, btnImgDelete); }
        private void btnImgAdd_MouseLeave(object sender, EventArgs e) { timerStop(timerBtnAdd,btnImgAdd); }
        private void btnImgStart_MouseLeave(object sender, EventArgs e) { timerStop(timerBtnStart, btnImgStart); }
        private void btnImgEdit_MouseLeave(object sender, EventArgs e) { timerStop(timerBtnEdit, btnImgEdit); }
        private void timerBtnStart_Tick(object sender, EventArgs e) { timerTick(timerBtnStart, btnImgStart); }
        private void timerBtnStop_Tick(object sender, EventArgs e) { timerTick(timerBtnStop, btnImgStop); }
        private void timerBtnAdd_Tick(object sender, EventArgs e) { timerTick(timerBtnAdd, btnImgAdd); }
        private void timerBtnDelete_Tick(object sender, EventArgs e) { timerTick(timerBtnDelete, btnImgDelete); }
        private void timerBtnEdit_Tick(object sender, EventArgs e) { timerTick(timerBtnEdit, btnImgEdit); }
        #endregion

        private void createBicBox_Click(object sender, EventArgs e)
        {
            createPicBox.Visible = false;
            openPicBox.Visible = false;
            listViewSites.Visible = true;
            btnImgStart.Enabled = true;
            btnImgStop.Enabled = true;
            btnImgAdd.Enabled = true;
            btnImgDelete.Enabled = true;
            btnImgEdit.Enabled = true;

            sites = new List<Site>();
            listViewSites.Items.Clear();
        }

        private void backgroundWorkerWaitThread_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            while (true)
            {
                if (thread == null)
                    continue;

                int WorkCount = 0;

                for (int i = 0; i < thread.Count; i++)
                {
                    WorkCount += (thread[i].IsAlive) ? 0 : 1;
                }

                if (WorkCount == thread.Count)
                    break;

                Thread.Sleep(1000);
            }
            //MessageBox.Show("Потоки завершили свою работу, можно менять кнопку");
            btnImgStart.Image = Properties.Resources.play; // Смена кнопки стоп на плэй
            isRunning = false;
        }

        private void materialFlatBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialFlatBtnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                  Point mousePos = Control.MousePosition;
                  mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                  Location = mousePos;
            }
        }

        private void materialFlatBtnMax_Click(object sender, EventArgs e)
        {
            if (materialFlatBtnMax.Text == "❐")
            {
                this.WindowState = FormWindowState.Maximized;
                materialFlatBtnMax.Text = "◱";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                materialFlatBtnMax.Text = "❐";
            }
        }

        private void listViewSites_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewSites.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listViewSites.SelectedItems;

                ListViewItem lvItem = items[0];
                string what = lvItem.Text;
                MessageBox.Show(what);
            }
        }

    }

    class Data //класс, который передаётся потокам при запуске сканирования
    {
        public int i;
        public int j;
    }
}
