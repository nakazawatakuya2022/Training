using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEx.Pages
{
    public class Ex2_1_4Model : PageModel
    {
        public string? FullName { get; set; }

        public string? Age { get; set; }

        public string? View()
        {
            return $"{FullName}さんは{Age}歳です。";
        }

        public void OnGet(string? fullName, string? age)
        {
            FullName = fullName;
            Age = age;
        }
    }
}
