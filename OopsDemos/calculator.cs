using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class calculator
    {
        int firstvalue;
        int secondvalue;
        int result;
        public calculator()
        {

        }
       public calculator(int first,int second)
        {
            firstvalue = first;
            secondvalue = second;
           
        }
        public void showcal()
        {
            Console.WriteLine("first value is" + firstvalue);
            Console.WriteLine("second value is" + secondvalue);
            
        }
        public int add()
        {
            result = firstvalue + secondvalue;
            return result;
        }
        public int sub()
        {
            result = firstvalue - secondvalue;
            return result;
        }
        public int mul()
        {
            result = firstvalue * secondvalue;
            return result;
        }
        public int div()
        {
            result = firstvalue / secondvalue;
            return result;
        }
    }
}
