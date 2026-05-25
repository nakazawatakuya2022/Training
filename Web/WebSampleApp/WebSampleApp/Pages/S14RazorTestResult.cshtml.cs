using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSampleApp.Pages
{
    public class S14RazorTestResultModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? FullName { get; set; }
        public void OnGet()
        {
        }
    }
}