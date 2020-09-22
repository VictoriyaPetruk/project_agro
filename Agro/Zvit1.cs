using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro
{
   public class Zvit1
    {
        private string nameculture;
        private string sort;
        private double massa_z;
        private double massa_p;
        private double massa_d;
        public string Nameculture { set { nameculture = value; } get { return nameculture; } }
        public string Sort { set { sort = value; } get { return sort; } }
        public double Massa_z { set { massa_z = value; } get { return massa_z; } }
        public double Massa_p { set { massa_p = value; } get { return massa_p; } }
        public double Massa_d { set { massa_d = value; } get { return massa_d; } }
        public Zvit1()
        {
            nameculture = "culture";
            sort = "sort";
            massa_z = 1000;
            massa_p = 1000;
            massa_d = 0;
        }
        public Zvit1(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                nameculture = val[0];
                sort = val[1];
                massa_z = Convert.ToDouble(val[2]);
                massa_p = Convert.ToDouble(val[3]);
                massa_d = Convert.ToDouble(val[4]);
            }
        }
    }
}
