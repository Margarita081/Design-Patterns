using Microsoft.AspNetCore.Mvc;
using Task3_Book;

namespace Task3_Book
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetBook(
            [FromQuery] string title,
            [FromQuery] string author,
            [FromQuery] string user)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                return BadRequest("Title and author are required.");
            }

            var proxy = new BookProxy(title, author, user);
            string result = proxy.Get();

            if (result.StartsWith("Access is denied"))
            {
                return StatusCode(403, result);
            }
            return Ok(result);
        }
    }
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