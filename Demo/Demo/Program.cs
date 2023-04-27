using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new ClassBook(1, "Mathematics", "NXB Kim Dong", new List<string>() { "Vietnamese", "English"}, 2002, 1, true, 5, new List<string>() { "Science", "Math" });
            Book secondBook = new ClassBook(2, "Literature", "Thomas", new List<string>() { "French", "English"}, 1999, 2, true, 12, new List<string>() { "Literature", "History" });
            firstBook.showInfo();
            
            User user = new Teacher(1, "Nguyen Van A", "nguyenvana", "123", 5);
            user.showRole();

            BorrowingBooks borrowingBooks = new BorrowingBooks(user, new List<Book> { firstBook, secondBook });
            Console.WriteLine(borrowingBooks);

        }
    }
}
