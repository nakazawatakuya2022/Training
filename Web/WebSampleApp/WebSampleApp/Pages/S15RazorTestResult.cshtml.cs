using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSampleApp.Pages
{
    public class S15RazorTestResultModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? Age { get; set; }

        public void OnGet()
        {
        }
    }
}
