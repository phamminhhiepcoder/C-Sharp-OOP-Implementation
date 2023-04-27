using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class ClassBook : Book
    {
        private int grade;

        private int Grade
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


        public override void showInfo()
        {
            string list = "";
            foreach(string x in subjects)
            {
                list += x + ", ";
            }
            list = list.Substring(0, list.Length - 2);
            Console.WriteLine("This classbook is used for grade {0}, about subjects: {1}", grade, list);
        }

        public override string ToString()
        {
            string listOfSubjects = "";
            foreach (string x in subjects)
            {
                listOfSubjects += x + ", ";
            }
            listOfSubjects = listOfSubjects.Substring(0, listOfSubjects.Length - 2);
            return base.ToString() + "grade: " + grade + "\nsubjects: " + listOfSubjects;     
        }
    }
}
