using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class BorrowingBooks
    {
        private User user;
        private List<Book> books;
        
        public User GetUser()
        {
            return user;
        }
        public BorrowingBooks(User user) { }
    }
}
