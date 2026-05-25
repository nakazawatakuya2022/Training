using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEx.Pages
{
    public class Ex2_3_1Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? FullName { get; set; }

        public IActionResult OnGet()
        {
            if (FullName == null)
            {
                return Page();
            }

            return RedirectToPage(
                "/Ex2_3_1_RedirectTo",
                new { FullName = FullName }
            );
        }
    }
}