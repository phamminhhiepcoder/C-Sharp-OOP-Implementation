using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class OtherBook : Book
    {
        private string type;

        public OtherBook(int id, string title, string authorName, List<string> languages, int year, int quantity, bool available, string type) : base(id, title, authorName, languages, year, quantity, available)
        {
            this.type = type;   
        }

        public void showInfo()
        {
            Book.showInfo();
            Console.Write(", type {1}", type);
        }
    }
}
