using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class sales
    {
        string Productname;
        int quantity;
        double Price;
        static double totalsales;
        public sales()
        {

        }
        public sales(string pn, int q, double pr)
        {
            Productname = pn;
            quantity = q;
            Price=pr;
            totalsales += pr * q;
        }
        public double display()
        {
            return totalsales;
        }
          

    }    

}
