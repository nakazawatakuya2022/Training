using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebSampleApp.Pages
{
    public class S18RazorTestResultModel : PageModel
    {
        public string Name { get; set; } = "";

        public void OnGet()
        {
            // nullだった場合は ゲスト を取得するコード
            Name = HttpContext.Session.GetString("UserName") ?? "ゲスト";
        }

    }
}