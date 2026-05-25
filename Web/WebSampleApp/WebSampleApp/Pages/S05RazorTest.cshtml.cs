using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSampleApp.Pages
{
    public class S05RazorTestModel : PageModel
    {
        // 追記
        [BindProperty]
        public string? Inquiry { get; set; }

        public void OnGet()
        {

        }

        public void OnPost(string? inquiry)
        {
            
        }
    }
}