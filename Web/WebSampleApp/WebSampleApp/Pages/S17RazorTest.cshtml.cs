using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebSampleApp.Pages
{
    public class S17RazorTestModel : PageModel
    {
        public void OnGet()
        {
            int? counter = HttpContext.Session.GetInt32("counter");
            // まだセッションが無い初回はnullになるので0で初期化
            if (counter == null)
            {
                counter = 0;
            }
            // GETされる度にカウンタを1増やしていく
            counter++;
            HttpContext.Session.SetInt32("counter", (int)counter);
        }

    }
}