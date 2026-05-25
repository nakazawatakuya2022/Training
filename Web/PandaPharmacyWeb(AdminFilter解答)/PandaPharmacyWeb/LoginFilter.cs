using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

namespace PandaPharmacyWeb
{
    public class LoginFilter : IAuthorizationFilter
    {
        private readonly IUserDataService _userDataService;

        public LoginFilter(IUserDataService userDataService)
        {
            _userDataService = userDataService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // ログイン画面のページモデルでログイン成功時にセッションにIDを格納している
            // セッション内にIDがあればログイン済みとみなす
            string? userName = context.HttpContext.Session.GetString("userName");
            if (userName == null)
            {
                // ログインしていなければログイン画面へリダイレクト
                context.Result = new RedirectResult("/Login");
                return;
            }

            // ユーザアカウント情報を取得して保存
            User? userAccount = _userDataService.GetByName(userName);
            if (userAccount != null)
            {
                // フィルターを抜けた次のページでのみ使用できる情報
                context.HttpContext.Items.Add("userAccount", userAccount);
            }

            // このまま抜ければ要求されたページが表示される仕組み
        }
    }
}