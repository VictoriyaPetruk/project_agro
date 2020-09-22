using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro
{
    public class Output3
    {
        private string nameculture;
        private string sort;
        private int count;
        private double price;
       
        public string Nameculture { set { nameculture = value; } get { return nameculture; } }
        public string Household { set { sort = value; } get { return sort; } }
        public int Postavka { set { count= value; } get { return count; } }
        public double Price { set { price = value; } get { return price; } }
   
        public Output3(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                nameculture = val[0];
                sort = val[1];
                count = Convert.ToInt32(val[2]);
                price = Convert.ToDouble(val[3]);
               
            }

        }
    }
    }
