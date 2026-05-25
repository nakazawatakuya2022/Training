using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSampleApp.Pages
{
    public class S13RazorTestModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Keyword { get; set; }

        public void OnGet()
        {
        }
    }
}