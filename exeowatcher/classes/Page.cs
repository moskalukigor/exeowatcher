using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeowatcher.classes
{
    class Page
    {
        public string pageName;
        public int countChanges;

        public Page()
        {

        }

        public Page(string pageName, int countChanges)
        {
            this.pageName = pageName;
            this.countChanges = countChanges;
        }
    }
}
