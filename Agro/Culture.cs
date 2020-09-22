using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro
{
    public class Culture
    {
        private string nameculture;
        public string Nameculture { set { nameculture = value; } get { return nameculture; } }
        public Culture()
        {
            nameculture = "culture";
        }
        public Culture(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                nameculture = val[0];
            }
        }
    }
}
