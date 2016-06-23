using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exeowatcher
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        MainForm main;

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
        }


        private void btnSettingsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettingsOk_Click(object sender, EventArgs e)
        {
            
            if(checkedListBoxTags.CheckedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали ни одного тега");
                return;
            }
            
            foreach (string s in checkedListBoxTags.CheckedItems)
            {
                main.tags.Add(s);
            }

            this.Close();
        }


    }
}
