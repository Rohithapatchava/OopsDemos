using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class Employee
    {
        int id;
        string name;
        public int Id { get; set; }
        public string Name { get; set; }
        public Department dept { get; set; }
    }
}
