using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Teacher : User
    {
        private int yearsOfExperience
        {
            get
            {
                return yearsOfExperience;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Value must be greater than 0!");
                }
                else
                {
                    yearsOfExperience = value;
                }
            }    
        }

        public override void showRole()
        {
            Console.WriteLine("This user is a teacher and has {1} years of experience!", yearsOfExperience);
        }
    }
}
