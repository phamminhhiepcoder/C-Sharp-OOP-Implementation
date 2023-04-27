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

        public Student(int id, string fullName, string username, string password, string className) : base(id, fullName, username, password)
        {
            this.className = className;
        }

        public override void showRole()
        {
            Console.WriteLine("This user is a student in class {1}", className);
        }

        public override string ToString()
        {
            return base.ToString() + "\n Role: student\n class name: " + className;
        }
    }
}
