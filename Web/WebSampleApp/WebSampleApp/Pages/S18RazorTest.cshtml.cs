using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebSampleApp.Pages
{
    public class S18RazorTestModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; } = "";

        public IActionResult OnPost()
        {
            HttpContext.Session.SetString("UserName", Name ??"ゲスト");

            return RedirectToPage("/S18RazorTestResult");
        }

    }
}