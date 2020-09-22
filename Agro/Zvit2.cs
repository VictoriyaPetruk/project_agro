using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro
{
  public  class Zvit2
    {
        private int id_p;
        private DateTime date;
        private string nameculture;
        private double massa;
        public int ID {set { id_p = value; }  get { return id_p; }}
        public  DateTime  Date{ set { date = value; } get { return date; } }
        public string Nameculture { set { nameculture = value; } get { return nameculture; } }
        
        public double Massa { set { massa = value; } get { return massa; } }
        public Zvit2()
        {
            id_p = 1;
            date = Convert.ToDateTime("01.01.2020");

            nameculture = "culture";
            massa = 1;
        }
        public Zvit2(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                id_p = Convert.ToInt32(val[0]);
                date = Convert.ToDateTime(val[1]);
                nameculture = val[2];
                massa = Convert.ToDouble(val[3]);
            }
        }
    }
}
