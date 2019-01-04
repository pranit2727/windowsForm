using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Employee : IEmployble
    {
        public string firstName { get; set; }
        public string lastName { get ; set; }
        public string email { get ; set; }
        public int age { get; set; }

        public Employee(string fname,string lname,string emai,int ag)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.email = emai;
            this.age = ag;
        }
    }
}
