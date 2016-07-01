using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeowatcher.classes
{
    class Tags
    {
        public string Title;
        public string Description;
        public string Content;
        public string Keywords;
        public string p;
        public string b;
        public string h;

        public Tags ()
        {
            this.Title = "X";
            this.Description = "X";
            this.Content = "X";
            this.Keywords = "X";
            this.p = "X";
            this.b = "X";
            this.h = "X";
        }

        public Tags (string Title, string Description, string Content, string Keywords, string p, string b, string h)
        {
            this.Title = Title;
            this.Description = Description;
            this.Content = Content;
            this.Keywords = Keywords;
            this.p = p;
            this.b = b;
            this.h = h;
        }
    }
}
