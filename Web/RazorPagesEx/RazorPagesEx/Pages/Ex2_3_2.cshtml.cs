using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEx.Pages
{
    public class Ex2_3_2Model : PageModel
    {
        [BindProperty]
        public int Num1 { get; set; }
        [BindProperty]
        public int Num2 { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return RedirectToPage(
                "/Ex2_3_2_Result",
                new
                {
                    Num1, Num2
                });
        }
    }
}
