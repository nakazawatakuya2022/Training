using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebSampleApp.Filters;

namespace WebSampleApp.Pages
{
    [TypeFilter(typeof(LoginFilter))]
    public class S19RazorTestModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}