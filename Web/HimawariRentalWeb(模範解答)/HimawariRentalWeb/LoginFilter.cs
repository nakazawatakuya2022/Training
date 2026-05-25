using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;

namespace HimawariRentalWeb
{
    public class LoginFilter : IAuthorizationFilter
    {
        private readonly IUserAccountDataService _userAccountDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userAccountDataService">ユーザアカウントデータの取得と登録に関する機能</param>
        public LoginFilter(IUserAccountDataService userAccountDataService)
        {
            _userAccountDataService = userAccountDataService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string? staffId = context.HttpContext.Session.GetString("staffId");
            if (staffId == null)
            {
                // ログインしていなければログイン画面へリダイレクト
                context.Result = new RedirectResult("/Login");
                return;
            }

            // ユーザアカウント情報を取得して保存
            UserAccount? userAccount = _userAccountDataService.GetById(staffId);
            if (userAccount != null)
            {
                context.HttpContext.Items.Add("userAccount", userAccount);
            }

            // このまま抜ければ要求されたページが表示される仕組み
        }
    }
}

