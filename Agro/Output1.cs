using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro
{
    public class Output1
    {
        private int number;
        private string nameculture;
       
        private string sort_p;
        private double massa;
        public int Number { set { number = value; } get { return number; } }
        public string Nameculture { set { nameculture = value; } get { return nameculture; } }
     
        public string Sort_p { set { sort_p = value; } get { return sort_p; } }
        public double Massa { set { massa = value; } get { return massa; } }
        public Output1(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                number = Convert.ToInt32(val[0]);
                nameculture = val[1];
               
                sort_p = val[2];
                massa= Convert.ToDouble(val[3]);
            }
            
        }
    }
}
