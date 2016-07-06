using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeowatcher.classes
{
    public class Proxy
    {
        public string ip;
        public int port;
        public string login;
        public string password;
        public string type;

        public Proxy()
        {

        }

        public Proxy(string ip, int port, string login, string password, string type)
        {
            this.ip = ip;
            this.port = port;
            this.login = login;
            this.password = password;
            this.type = type;
        }
    }
}
