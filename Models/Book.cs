
// The 'System.Text.Json' namespace contains classes for serializing and deserializing JSON data.
using System.Text.Json;
// The 'System.Text.Json.Serialization' namespace contains types and APIs for customizing JSON serialization and deserialization behavior.
using System.Text.Json.Serialization;

/*
    The 'namespace' keyword defines a named scope that contains a set of related objects.
    It helps in organizing the code and preventing naming conflicts
    The namespace has .Models to refer to the current folder "Models" 
*/

namespace BooksAssignment2.Models
{
    // The Book class represents the model for book entity in the application
    public class Book
    {
        // Getter and Setter for public property Title
        public string? Title { get; set; }

        // Getter and Setter for public property Author
        public string? Author { get; set; }
        // Getter and Setter for public property Img
        public string? Img { get; set; }
        // Getter and Setter for public property Genre
        public string? Genre { get; set; }

        /*
        'ToString' method serializes the 'Book' object to a JSON string using the System.Text.Json serializer.
        */
        public override string ToString() => JsonSerializer.Serialize<Book>(this);

    } // class
} // namespace