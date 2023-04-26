using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class ClassBook : Book
    {
        

        private int grade
        {
            get
            {
                return grade;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("The value must be greater than 0!");
                }
                else
                {
                    grade = value;
                }
            }
        }
        private List<string> subjects { get; set; }
        public ClassBook(int id, string title, string authorName, List<string> languages, int year, int quantity, bool available, int grade, List<string> subjects) : base(id, title, authorName, languages, year, quantity, available)
        {
            this.grade = grade;
            this.subjects = subjects;
        }



        public void showInfo()
        {
            Book.showInfo();
            Console.Write(", grade {1}, subjects: {2}", grade, subjects);
        }
        

    }
}
