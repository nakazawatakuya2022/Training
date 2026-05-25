using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSampleApp.Pages
{
    public class S03RazorTestModel : PageModel
    {
        public string Massage { get; set; } = "初期状態です。";
        public void OnGet()
        {
            Massage = "リクエストを受け取りました（Get）";
        }

        public string Info()
        {
            return "リクエストの受け取り確認プログラム";
        }
    }
}