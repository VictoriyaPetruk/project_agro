using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro
{
   public class CultureSort
    {

      
        private string nameculture;
        private string sort;
        private double price;
        private double width_z;
        private double avr;
        private double yeild;

        public string Nameculture { set { nameculture = value; } get { return nameculture; } }
        public string Sort { set { sort = value; } get { return sort; } }
        public double Price { set { price = value; } get { return price; } }
        public double Width { set { width_z = value; } get { return width_z; } }
        public double Yeild_av { set { avr = value; } get { return avr; } }
        public double Yeild { set { yeild = value; } get { return yeild; } }

        public CultureSort()
        {
            nameculture = "culture";
            sort = "sort";
            price = 1;
            width_z = 1;
            avr = 1;
            yeild = 1;
        }
        public CultureSort(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                nameculture = val[0];
                sort = val[1];
                price = Convert.ToDouble(val[2]);
                width_z= Convert.ToDouble(val[3]);
                avr = Convert.ToDouble(val[3]);
                yeild = Convert.ToDouble(val[3]);
            }
        }
    }
}
