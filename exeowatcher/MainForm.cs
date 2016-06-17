﻿using System;
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

        const bool prevScanB = false;
        const bool currScanB = true;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new classes.ColorMenuStrip());
        }

        private List<string> getHTML()
        {
            string urlAddress = txtBoxSite.Text;

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


        private void btnScan_Click(object sender, EventArgs e)
        {
            List<string> content = getHTML();
            if(content == null)
            {
                MessageBox.Show("Error");
                return;
            }
                

            if (txtBoxPrevScan.Text == "")
            {
                writeToFile(content, prevScanB);
                txtBoxPrevScan.Text = ListToStr(readFromFile(prevScanB));                        //TextBox
                
            }
            else if (txtBoxCurrScan.Text != "")
            {
                writeToFile(readFromFile(currScanB), prevScanB);
                writeToFile(content, currScanB);

                txtBoxPrevScan.Text = ListToStr(readFromFile(currScanB));              //TextBox
                txtBoxCurrScan.Text = ListToStr(readFromFile(prevScanB));                          //TextBox

                
            }
            else
            {
                writeToFile(content, currScanB);
                txtBoxCurrScan.Text = ListToStr(readFromFile(currScanB));                          //TextBox
            }
        }

        public void compareCode(string originalText, string verifiableText)
        {

            List<string> prevText = readFromFile(prevScanB);
            List<string> currText = readFromFile(currScanB);




          
            var dmp = new diff_match_patch();
            var d = dmp.diff_main(ListToStr(prevText), ListToStr(currText));
            List<DiffMatchPatch.Diff> dl = d;

            richTxtResult.Text = "";
            for(int i = 0; i < dl.Count; i++)
            {
                switch(dl[i].operation)
                {
                    case DiffMatchPatch.Operation.EQUAL:
                            AppendText(this.richTxtResult, Color.Empty, dl[i].text);
                        break;
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string originalText = txtBoxPrevScan.Text;
            string verifiableText = txtBoxCurrScan.Text;
            compareCode(originalText, verifiableText);

            int coincidence2 = originalText.Where(x => verifiableText.Contains(x)).Count();

            if (coincidence2 > 0)
                MessageBox.Show(coincidence2.ToString());
        }


        private void writeToFile(List<string> text, bool TypeScan)
        {
            string TypeScanText = "";

            if (!TypeScan)
                TypeScanText = "prevScan";
            else
                TypeScanText = "currScan";

            File.WriteAllLines(TypeScanText + ".txt", text);
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


        private static List<string> readFromFile(bool TypeScan)
        {
            string TypeScanText = "";

            if (!TypeScan)
                TypeScanText = "prevScan";
            else
                TypeScanText = "currScan";


            List<string> listLines = new List<string>();

            using (StreamReader sr = new StreamReader(File.Open(TypeScanText + ".txt", FileMode.Open)))
            {
                while (!sr.EndOfStream)
                    listLines.Add(sr.ReadLine());
            }
           
            return listLines;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSite addSiteForm = new AddSite();
            addSiteForm.Owner = this;
            addSiteForm.Show(); 
        }


        public void AddSite(string site)
        {
            listViewSites.Items.Add(new ListViewItem(new string[] { "test", "AJ", "22" }));
        }
    }
}
