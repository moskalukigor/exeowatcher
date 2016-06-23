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

        public Site()
        {
            //this.site = "Default";
            //this.latestScan = new DateTime(1990, 01, 01);
            //this.pages.Add(new Page("default", 0));
        }

        public Site(string site, DateTime latestScan, int countPages, List<Page> pages)
        {
            this.site = site;
            this.latestScan = latestScan;
            this.pages = pages;
        }
    }
}
