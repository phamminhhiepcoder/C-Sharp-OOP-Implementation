using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    abstract class User
    {
        private int id
        {
            get
            {
                return id;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Value must be greater than 0");
                }
                else
                {
                    id = value;
                }
            }
        }
        private string fullName { get; set; }
        private string username { get; set; }
        private string password { get; set; }

        public abstract void showRole();
    }
}
