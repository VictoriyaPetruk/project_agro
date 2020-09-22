using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro
{
    public class Output2
    {
      
       
        private string nameculture;
        private string sort;
        private int year;
        public string Nameculture { set { nameculture = value; } get { return nameculture; } }
        public string Sort{ set { sort = value; } get { return sort; } }
        public int Year { set { year = value; } get { return year; } }
        public Output2(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                nameculture = val[0];
                sort = val[1];
                year= Convert.ToInt32(val[2]);
              

            }

        } 
    }
}
