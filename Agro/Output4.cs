using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro
{
  public   class Output4
    {
        private string nameculture;
        private double massa;
        public string Nameculture { set { nameculture = value; } get { return nameculture; } }
        public double Massa { set { massa = value; } get { return massa; } }
        public Output4(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                nameculture = val[0];
                massa = Convert.ToDouble(val[1]);
            }
        }
    }
}
