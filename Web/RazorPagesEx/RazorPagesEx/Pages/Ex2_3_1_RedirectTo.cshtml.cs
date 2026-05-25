using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEx.Pages
{
    public class Ex2_3_1_RedirectToModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? FullName { get; set; }
        public void OnGet()
        {
        }
    }
}
