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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.02;
            if(this.Opacity == 1)
            {
                timer1.Stop();
            }
        }
    }
}
