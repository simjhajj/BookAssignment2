using BooksAssignment2.Models; // Importing the Book model namespace
using BooksAssignment2.Services; // Importing the service namespace
using Microsoft.AspNetCore.Mvc; // Importing ASP.NET Core MVC namespace
using Microsoft.AspNetCore.Mvc.RazorPages; // Importing ASP.NET Core Razor Pages namespace

namespace BooksAssignment2.Pages
{
    public class BookListModel : PageModel
    {
        // Declaring a field to hold the BookService instance
        public JsonFileBookService BookService;

        // Declaration of the Books property.
        // This property represents a collection of Book objects.
        // It is declared as public, allowing external code to read its value,
        // while its setter is private, restricting modification to code within the BookListModel class.
        // Declaring a property to hold the list of books
        public IEnumerable<Book> Books { get; private set; } = default!;

        // Constructor for the BookListModel class
        // Constructor for the BookListModel class.
        // It takes two parameters:
        // 1. ILogger<IndexModel> logger: This parameter is of type ILogger, which is a generic interface for logging. 
        //    Here, it is specifically typed to ILogger<IndexModel>, indicating that it will log messages related to the IndexModel class.
        //    However, this parameter seems to be incorrectly typed, as it should be ILogger<BookListModel> instead of ILogger<IndexModel>.
        // 2. JsonFileBookService bookService: This parameter is of type JsonFileBookService, which is a service responsible for handling book data stored in JSON format.
        //    It is used to retrieve books from a JSON file and interact with the book data.

        public BookListModel(ILogger<IndexModel> logger, JsonFileBookService bookService)
        {
            // Assigning the injected book service instance to the BookService field
            BookService = bookService;
        }

        // Handler method for HTTP GET requests
        public void OnGet()
        {
            // Retrieving the list of books from the BookService
            Books = BookService.GetBooks();
        }
    } // class
} // namespace
