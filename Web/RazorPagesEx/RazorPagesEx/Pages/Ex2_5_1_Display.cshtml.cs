using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEx.Pages
{
    public class Ex2_5_1_DisplayModel : PageModel
    {
        public string? Name { get; set; }

        public string? Message { get; set; }

        public void OnGet()
        {
            Name = HttpContext.Session.GetString("UserName");
            Message = HttpContext.Session.GetString("UserMessage");
        }
    }
}