using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEx.Pages
{
    public class Ex2_2_1Model : PageModel
    {
        [BindProperty]
        public int? Num1 { get; set; }
        [BindProperty]
        public int? Num2 { get; set; }

        public string Keisan()
        {
            int? kotae = Num1 + Num2;
            return $"{Num1}+{Num2}={kotae}";
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
