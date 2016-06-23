using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeowatcher.classes
{
    class InformationSite
    {
        public string Site { get; set; }
        public int Count { get; set; }
        public List<Page> pages = new List<Page>();
    }


}
