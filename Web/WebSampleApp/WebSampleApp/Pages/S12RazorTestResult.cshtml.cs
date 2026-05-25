using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSampleApp.Pages
{
    public class S12RazorTestResultModel : PageModel
    {
        [BindProperty]
        public string? FullName { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}