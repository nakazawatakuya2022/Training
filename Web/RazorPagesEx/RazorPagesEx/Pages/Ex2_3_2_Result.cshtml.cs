using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEx.Pages
{
    public class Ex2_3_2_ResultModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Num1 { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Num2 { get; set; }

        //public int Answer { get; set; }

        public string keisan()
        {
            int answer = Num1 + Num2;
            return $"{Num1} + {Num2} = {answer}";
        }

        public void OnGet()
        {
            //Answer = Num1 + Num2;
        }
    }
}