using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesEx.Pages
{
    public class Ex2_4_2Model : PageModel
    {
        [BindProperty]

        [StringLength(
            20,
            MinimumLength = 8,
            ErrorMessage = "パスワードは8文字以上20文字以内で入力してください"
        )]

        public string? Password { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Ex2_4_2");
        }
    }
}