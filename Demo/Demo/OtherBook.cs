using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class OtherBook : Book
    {
        private string type { get; set; }

        public OtherBook(int id, string title, string authorName, List<string> languages, int year, int quantity, bool available, string type) : base(id, title, authorName, languages, year, quantity, available)
        {
            this.type = type;   
        }

        public override void showInfo()
        {
            Console.Write(" This other book has type {1}", type);
        }

        public override string ToString()
        {
            return base.ToString() + "type: " + type;
        }
    }
}
