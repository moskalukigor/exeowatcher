using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeowatcher.classes
{
    class Site
    {
        public string site;
        public DateTime latestScan;
        public List<Page> pages = new List<Page>();
        //public Tags tags = new Tags();

        public Site()
        {
            
        }

        public Site(string site, DateTime latestScan, int countPages, List<Page> pages)//, Tags tags)
        {
            this.site = site;
            this.latestScan = latestScan;
            this.pages = pages;
            //this.tags = tags;
        }
    }
}
