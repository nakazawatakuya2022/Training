using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesEx.Pages
{
    public class Ex2_4_1Model : PageModel
    {
        [BindProperty]
        [Phone(ErrorMessage = "電話番号の形式が正しくありません")]
        public string? PhoneNumber { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Ex2_4_1");
        }
    }
}