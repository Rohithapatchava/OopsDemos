using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class cars
    {
        string color;
        string regno;
        string model;
        int price;
        public cars()//default constructor
        {

        }
        public cars(string reg)//overloaded
        {
            regno = reg;
        }
        public cars(string reg,string mod)
        {
            regno = reg;
            model = mod;

        }
        public cars(string reg, string mod,string clr,int prc)
        {
            regno = reg;
            model = mod;
            color = clr;
            price = prc;
        }
       // public void showcar()
       public string showcar()
        {
           /* Console.WriteLine("reg no is" + regno);
            Console.WriteLine("model is" + model);
            Console.WriteLine("color is" + color);
            Console.WriteLine("price is" + price);*/
            return string.Format("reg no:{0}\n maodel no is {1}\n color is {2}\n price is {3}", regno, model, color, price);
        }
    }
}
