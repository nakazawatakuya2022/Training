using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEx.Pages
{
    public class Ex2_2_3Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Keyword { get; set; }

        public void OnGet()
        {

        }
    }
}
