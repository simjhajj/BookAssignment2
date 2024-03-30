using BooksAssignment2.Models; // Importing the namespace for the Book class from the Models folder.
using System.Text.Json; // Importing the namespace for working with JSON data.

namespace BooksAssignment2.Services
{
    // Class responsible for providing book data from a JSON file.
    public class JsonFileBookService
    {
        // Constructor for the JsonFileBookService class.
        // It takes a parameter of type IWebHostEnvironment, which provides information about the web hosting environment.
        public JsonFileBookService(IWebHostEnvironment webHostEnvironment)
        {
            // Assigning the provided web hosting environment to the WebHostEnvironment property.
            WebHostEnvironment = webHostEnvironment;
        }

        // Property to store the web hosting environment.
        // Only getter is used here because WebHostEnvironment remains the same
        public IWebHostEnvironment WebHostEnvironment { get; }

        // Combining the file path for the JSON file containing book data.
        // The JSON file is located in the "wwwroot data" folder.
        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "books.json");

        // Method to retrieve a collection of Book objects from a JSON file
        public IEnumerable<Book> GetBooks()
        {
            // Open the JSON file containing book data for reading.
            using var jsonFileReader = File.OpenText(JsonFileName);

            // Deserialize the JSON data into an array of Book objects.
            // Deserization is necessary for the computer to understand the code
            // Read the entire content of the JSON file as a string and deserialize it.
            // PropertyNameCaseInsensitive is set to true to ensure case-insensitive matching of property names.
            return JsonSerializer.Deserialize<Book[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })!;

        }
    }
}