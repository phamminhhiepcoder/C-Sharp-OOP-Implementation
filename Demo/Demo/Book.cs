using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Book
    {
        private int id;
        private string title { get; set; }
        private string authorName { get; set; }
        private List<string> languages { get; set; }
        private int year;
        private int quantity;
        private bool available { get; set; }


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
                    this.id = value;
                }
            }
        }
       
        private int Year
        {
            get
            {
                return year;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Value must be greater than 0!");
                }
                else
                {
                    this.year = value;
                }
            }
        }
        private int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Value must be greater than 0 or equals to 0!");
                }
                else
                {
                    this.quantity = value;
                }
            }
        } 

        public Book(int id, string title, string authorName, List<string> languages, int year, int quantity, bool available)
        {
            this.id = id;
            this.title = title;
            this.authorName = authorName;
            this.languages = languages;
            this.year = year;
            this.quantity = quantity;
            this.available = available;
        }

        public virtual void showInfo()
        {
            Console.Write("This book has id {1}, title {2}, author {3}, languages: {4}, year {5}, quantity: {6}, available: {7}", id, title, authorName, languages, year, quantity, available);
        }

        public override string ToString()
        {
            string listOfLanguages = "";
            foreach(string x in languages)
            {
                listOfLanguages += x + ", ";
            }
            listOfLanguages = listOfLanguages.Substring(0, listOfLanguages.Length - 2);
            return "Book: \n" + "id: " + id + "\ntitle: " + title + "\n author's name: " + authorName + "\nLanguages: " + listOfLanguages + "\nyear: " + year + "\nquantity: " + quantity + "\navailable: " + available + "\n";
        }
    }
}
