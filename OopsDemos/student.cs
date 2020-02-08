using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemos
{
    class student
    {
        string name;
        int idno;
        string course;
        DateTime joindate;
        string firstname, lastname;
        public student()
        {

        }
        public student(string fn,string ln)
        {
            firstname = fn;
            lastname = ln;
        }
        public string Name
        {
            get
            {
                // return name;
                return string.Format("{0} {1}", firstname, lastname);
            }
            set
            {
                name = value;
            }
        }
       public int Idno
          {
            get
            {
                return idno;
            }
            set
            {
                idno=value;
            }
        }
    public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime Joindate
        {
            get { return joindate; }
            set { joindate = value; }
        }
    }
}
