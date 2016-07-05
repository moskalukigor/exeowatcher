using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeowatcher.classes
{
    public class Settings
    {
        public List<string> tags;
        public List<Proxy> proxys;


        public Settings()
        {

        }

        public Settings(List<string> tags, List<Proxy> proxys)
        {
            this.tags = tags;
            this.proxys = proxys;
        }
    }
}
