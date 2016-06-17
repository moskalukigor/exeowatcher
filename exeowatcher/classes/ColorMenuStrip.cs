using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exeowatcher.classes
{
    class ColorMenuStrip : ProfessionalColorTable
    {
        public override Color MenuItemBorder
        {
            get{ return Color.Gray; }
        }



        public override Color MenuItemSelected
        {
            get { return Color.Gray; }
        }

        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Color.LightGray; }
        }
    }
}
