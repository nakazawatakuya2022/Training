using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSampleApp.Pages
{
    public class S14RazorTestModel : PageModel
    {
        [BindProperty]
        public string? FullName { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/S14RazorTestResult",
                new
                {
                    FullName
                });

            // 値を渡す必要がない場合は以下のみでOK
            // return RedirectToPage("/Sample/PrgTestResult");
        }
    }
}