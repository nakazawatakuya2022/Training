using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UminekoWeb.Models;

namespace UminekoWeb.Pages
{
    [TypeFilter(typeof(LoginFilter))]
    public class IndexModel : PageModel
    {
        public Staff? Staff { get; set; }

        public void OnGet()
        {
            Staff =
                HttpContext.Items["staff"] as Staff;
        }
    }
}