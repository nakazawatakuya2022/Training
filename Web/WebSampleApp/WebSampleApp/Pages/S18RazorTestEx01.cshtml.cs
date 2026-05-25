using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSampleApp.Pages
{
    public class S18RazorTestEx01Model : PageModel
    {
        [BindProperty]
        public string? Name { get; set; }

        public void OnGet()
        {
            Name = HttpContext.Session.GetString("UserName");
        }

        public IActionResult OnPost()
        {
            if (Name != null)
            {
                return Page();
            }

            HttpContext.Session.SetString("UserName", Name??"ゲスト");

            return RedirectToPage("/S18RazorTestEx01");
        }
    }
}