using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    abstract class User
    {
        private int id;

        private int Id
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

        public User(int id, string fullName, string username, string password)
        {
            this.id = id;
            this.fullName = fullName;
            this.username = username;
            this.password = password;
        }

        public abstract void showRole();

        public override string ToString()
        {
            return "User: \n" + "  id: " + id + "\n  full name: " + fullName + "\n  username: " + username + "\n  password: " + password + "\n";  
        }
    }
}
