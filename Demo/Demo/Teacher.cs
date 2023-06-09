﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Teacher : User
    {
        private int yearsOfExperience;

        public Teacher(int id, string fullName, string username, string password, int yearsOfExperience) : base(id, fullName, username, password)
        {
            this.yearsOfExperience = yearsOfExperience;
        }

        private int YearsOfExperience
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
            Console.WriteLine("This user is a teacher and has {0} years of experience!", yearsOfExperience);
        }

        public override string ToString()
        {
            return base.ToString() + "Role: teacher\nyears of experience: " + yearsOfExperience;
        }
    }
}
