using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace WebSampleApp.Pages
{
    public class S18RazorTestEx02Model : PageModel
    {
        [BindProperty]
        public int? Age { get; set; }
        public void OnGet()
        {
            Age =
                HttpContext.Session.GetInt32("UserAge");
        }
        public IActionResult OnPost()
        {
            if(Age != null)
            {
                HttpContext.Session.SetInt32("UserAge", (int)Age);
                return RedirectToPage("/S18RazorTestEx02");
            }
            else
            {
                return Page();
            }
        }
    }
}
