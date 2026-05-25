using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebSampleApp.Pages
{
    public class S16RazorTestModel : PageModel
    {
        public int Count { get; set; } = 100;
        public void OnGet()
        {
            Count++;
        }
    }
}