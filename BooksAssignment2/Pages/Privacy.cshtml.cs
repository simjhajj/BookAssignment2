using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksAssignment2.Pages
{
    // This class represents the code-behind for the Privacy.cshtml Razor Page.
    public class PrivacyModel : PageModel
    {
        // Private field to store an instance of the ILogger interface for logging purposes.
        private readonly ILogger<PrivacyModel> _logger;

        // Constructor to initialize the PrivacyModel with an instance of ILogger.
        // ILogger is a logging interface provided by ASP.NET Core.
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        // This method handles HTTP GET requests to the Privacy Page.
        // In this case, it's empty as no additional processing is required when the page is accessed.
        public void OnGet()
        {
        }
    }
}
