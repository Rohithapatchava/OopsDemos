using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class scale
    {
        double inch;
        double centimeter;
        public double Inch
        {
            get
            {
                return centimeter*2.54 ;
            }
            set
            {
                centimeter=value/2.54; ;
            }
        }
        public void showcenti()
        {
            Console.WriteLine(" centimeter to inch is: {0}",centimeter );
        }

    }
}
