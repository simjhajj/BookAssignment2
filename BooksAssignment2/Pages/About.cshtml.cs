// Namespace containing classes and interfaces for building web applications using ASP.NET Core MVC.
using Microsoft.AspNetCore.Mvc;

// Namespace containing classes and interfaces specific to Razor Pages, an alternative approach to MVC in ASP.NET Core.
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksAssignment2.Pages
{
    // The AboutModel class serves as the code-behind for the About Razor Page.
    // Define a class AboutModel which inherits from PageModel
    // Page class is base class for ASP.NET core Razor pages
    public class AboutModel : PageModel
    {
        // This method is executed when an HTTP GET request is made to the About page.
        public void OnGet()
        {
            // No specific actions are performed in this method for the HTTP GET request.
        }
    }
}
