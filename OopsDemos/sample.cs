using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class sample
    {
        int no = 0;
        static int cnt = 0;
        public sample()
        {
            no++;
            cnt++;
            Console.WriteLine("no:{0}\n count:{1}\n", no, cnt);
        }
        public static void show()
        {
            cnt++;
            Console.WriteLine("From static show method" + "and count is {0}", cnt);
        }
    }
}
