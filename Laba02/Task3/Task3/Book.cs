using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{

    public interface IBook
    {
        string Author { get; }
        string Title { get; }

        string Get();

    }
    public class Book : IBook
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Get()
        {
            return $"{Title} {Author}";
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Console.WriteLine($"New book is {title}, {author}.");
        }
    }

    public class BookProxy : IBook
    {
        private Book? _book;
        private readonly string _author;
        private readonly string _title;
        private readonly string _user;

        public string Title => _title;
        public string Author => _author;

        public BookProxy(string title, string author, string user)
        {
            _title = title;
            _author = author;
            _user = user;
            Console.WriteLine($"Create Proxy for a book {title}, {author}.");
        }

        public string Get()
        {
            if (!IsUserRegistered())
            {
                return "Access is denied: the user is not registered.";
            }
            if (!HasAccessToBook())
            {
                return "Access is denied: insufficient permissions.";
            }
            if (_book == null)
            {
                _book = new Book(_title, _author);
            }
            return _book.Get();
        }
        private bool IsUserRegistered()
        {
            return _user is "User" or "Admin";
        }

        private bool HasAccessToBook()
        {
            return _user != "Guest";
        }
    }
}
