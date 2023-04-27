using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class ReferenceBook : Book
    {
        private string major { get; set; }

        public ReferenceBook(int id, string title, string authorName, List<string> languages, int year, int quantity, bool available, string major) : base(id, title, authorName, languages, year, quantity, available)
        {
            this.major = major;
        }

        public override void showInfo()
        {
            Console.Write("This reference book has major {1}", major);
        }

        public override string ToString()
        {
            return base.ToString() + "major: " + major;
        }
    }
}
