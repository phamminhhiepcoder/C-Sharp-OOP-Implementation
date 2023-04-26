using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Student : User  
    {
        private string className { get; set; }
        public override void showRole()
        {
            Console.WriteLine("This user is a student in class {1}", className);
        }

    }
}
