using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class ReferenceBook : Book
    {
        private string major;

        public ReferenceBook(int id, string title, string authorName, List<string> languages, int year, int quantity, bool available, string major) : base(id, title, authorName, languages, year, quantity, available)
        {
            this.major = major;
        }

        public void showInfo()
        {
            Book.showInfo();
            Console.Write(", major {1}", major);
        }
    }
}
