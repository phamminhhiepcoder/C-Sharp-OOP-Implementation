using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class BorrowingBooks
    {
        private User user { get; set; }
        private List<Book> books { get; set; }

        public BorrowingBooks(User user, List<Book> books)
        {
            this.user = user;
            this.books = books;
        }
        public void addBook(Book book)
        {
            books.Add(book);
        }
        public void removeBook(Book book)
        {
            if(books.Contains(book) == false)
            {
                Console.WriteLine("Can't find that book!");
            }
            else
            {
                books.Remove(book);
            }
        }

        public override string ToString()
        {
            string listOfBooks = "";
            foreach(Book book in books) { 
                    listOfBooks += book.ToString(); 
                }
            listOfBooks = listOfBooks.Substring(0, listOfBooks.Length - 2);
            return "User: " + user.ToString() + "\nList of books: " + listOfBooks;
        }
    }
}
