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
        public int countPages;
        public List<string> pages = new List<string>();

        public Site()
        {
            this.site = "Default";
            this.latestScan = new DateTime(00, 00, 00);
            this.countPages = 0;
            this.pages.Add("Default");
        }

        public Site(string site, DateTime latestScan, int countPages, List<string> pages)
        {
            this.site = site;
            this.latestScan = latestScan;
            this.countPages = countPages;
            this.pages = pages;
        }
    }
}
