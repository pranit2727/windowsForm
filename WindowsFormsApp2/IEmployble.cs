using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    interface IEmployble
    {
        string firstName { set; get; }
        string lastName { set; get; }
        string email { set; get; }
        int age { set; get; }
    }
}
