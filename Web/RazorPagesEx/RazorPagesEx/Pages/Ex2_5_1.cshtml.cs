using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEx.Pages
{
    public class Ex2_5_1Model : PageModel
    {

        [BindProperty]
        public string? Name { get; set; }

        [BindProperty]
        public string? Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Name != null && Message != null)
            {
                HttpContext.Session.SetString("UserName", Name);
                HttpContext.Session.SetString("UserMessage", Message);
                return RedirectToPage("Ex2_5_1_Display");
            }
            else
            {
                return Page();
            }
        }
    }
}