using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PandaPharmacyWeb.Pages
{
    public class LogoutModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Session.Clear();
        }
    }
}