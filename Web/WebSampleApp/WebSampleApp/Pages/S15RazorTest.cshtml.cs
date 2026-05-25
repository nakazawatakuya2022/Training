using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebSampleApp.Pages
{
    public class S15RazorTestModel : PageModel
    {
        [Range(0, 120, ErrorMessage = "年齢は0から120の間で入力してください")]
        [BindProperty]
        public int? Age { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // 検証に成功したケース. 結果ページへリダイレクト
                return RedirectToPage("/S15RazorTestResult",
                    new
                    {
                        Age
                    });
            }
            else
            {
                // 検証に失敗したケース
                // 自分のページをもう一度返す
                return Page();
            }
        }
    }
}