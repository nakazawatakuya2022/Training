using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;

namespace HimawariRentalWeb.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserAccountDataService _userAccountDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userAccountDataService">ユーザアカウントデータの取得と登録に関する機能</param>
        public LoginModel(IUserAccountDataService userAccountDataService)
        {
            _userAccountDataService = userAccountDataService;
        }

        [BindProperty]
        [Required]
        public string? StaffId { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public bool LoginFailed { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (StaffId != null && Password != null)
            {
                // ユーザ名とパスワードが正当なものであるか検証する
                UserAccount? userAccount = _userAccountDataService.GetById(StaffId);
                if (userAccount == null || userAccount.Password != Password)
                {
                    // ログイン失敗
                    LoginFailed = true;
                    return Page();
                }

                // セッションにユーザ名を保存
                // 以降アクセスの度にユーザ名が保存されているか確認し保存されていればログイン済みとみなす
                HttpContext.Session.SetString("staffId", StaffId);

                // ログイン成功. トップページへリダイレクト
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
