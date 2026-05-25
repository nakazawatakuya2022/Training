using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEx.Pages
{
    public class Ex2_2_2Model : PageModel
    {
        [BindProperty]
        public int? Num1 { get; set; }
        [BindProperty]
        public int? Num2 { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
