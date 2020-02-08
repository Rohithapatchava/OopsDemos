using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //cars();
            //Calcultor();
            //student();
            //TimeObjmethod();
            // AutoProp();
            //vehicle();
            // Inchcenti();
            //Methodoverloading();
            //Program pg = new Program();
            //pg.Nonstaticmethod();
            //sales();
            //sample();
            roadvehical();
            Employee emp = new Employee
            {
                Id = 10;
                Name = "anand";
                Department = new Department { Id=1,Dname=}
            }
        }

        private static void roadvehical()
        {
            Roadwayvehicle rv = new Roadwayvehicle();
            rv.showvehicle();
            rv.showvehicle();
            train tr = new train();
            tr.showtrain();
        }

        private static void sample()
        {
            sample s1 = new sample();
            sample s2 = new sample();
            sample s3 = new sample();
            OopsDemos.sample.show();
        }

        private static void sales()
        {
            sales s1 = new sales();
            sales s2 = new sales("biscuits", 5, 100);
            sales s3 = new sales("chocolates", 8, 800);
            Console.WriteLine(s1.display());
        }

        public void Nonstaticmethod()
        {
            Console.WriteLine("hai");
        }

        private static void student()
        {
            student std = new student();
            student std1 = new student("alex", "bob");

            std.Name = "Rohitha";
            std.Idno = 123;
            std.Course = "c#";
            //std.Joindate = DateTime.Parse("21-01-2020");
            std.Joindate = Convert.ToDateTime("21-01-2020");
            Console.WriteLine("name is {0}\n Id is {1}", std.Name, std.Idno);
            Console.WriteLine("course:{0}\n joindate:{1} ", std.Course, std.Joindate.ToShortDateString());
        }

        private static void cars()
        {
            cars car = new cars();
            //cars car = new cars("AP26BT8797");
            //cars car = new cars("AP26BT8797", "hondacity");
            cars car1 = new cars("AP26BT8797", "hondacity", "white", 150000);
            Console.WriteLine(car.showcar());
            String data = car1.showcar();
            Console.WriteLine(data);
        }

        private static void Calcultor()
        {
            calculator cal = new calculator();
            cal.showcal();
            calculator cal1 = new calculator(5, 4);
            cal1.showcal();
            int addition = cal1.add();
            int subtraction = cal1.sub();
            int multiplication = cal1.mul();
            int division = cal1.div();
            Console.WriteLine("addition is" + addition);
            Console.WriteLine("subtraction is" + subtraction);
            Console.WriteLine("multiplication is" + multiplication);
            Console.WriteLine("division is" + division);
        }

        private static void Methodoverloading()
        {
            calculate clt = new calculate();
            Console.WriteLine(clt.area(12));
            Console.WriteLine(clt.area(10, 20));
            Console.WriteLine(clt.area(15.7));
            Console.WriteLine(clt.area(10.6, 9));
        }

        private static void Inchcenti()
        {
            scale s = new scale();
            s.Inch = 15;
            Console.WriteLine("centimetre:{0}", s.Inch);
            s.showcenti();
        }

        private static void vehicle()
        {
            vehicle v = new vehicle { No = 1, Model = "Hondacity", Modeltype = "car", Price = 150000 };
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", v.No, v.Model, v.Modeltype, v.Price);
            vehicle v1 = new vehicle { No = 2, Model = "Duet", Modeltype = "scooty", Price = 80000 };
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", v1.No, v1.Model, v1.Modeltype, v1.Price);
        }



        private static void AutoProp()
        {
            product pd = new product { Id = 1, Pname = "chocolate",Price=100 };
            Console.WriteLine("{0}\n{1}\n{2}", pd.Id, pd.Pname,pd.Price);
        }

        private static void TimeObjmethod()
        {
            timeperiod tp = new timeperiod();
            tp.Hours = 15;
            Console.WriteLine("hours:{0}", tp.Hours);
            tp.showseconds();
        }
    }
}

