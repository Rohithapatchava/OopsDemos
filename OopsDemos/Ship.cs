using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class Ship:vehical
    {
        public void showship()
        {
            Console.WriteLine("this is ship");
        }
        new public void showvehical()//new hides the base class showvehical
        {
            Console.WriteLine("cruise liner ship");
        }
    }
}
