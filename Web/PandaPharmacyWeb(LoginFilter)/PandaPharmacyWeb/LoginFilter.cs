using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

namespace PandaPharmacyWeb
{
    public class LoginFilter : IAuthorizationFilter
    {

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

            // このまま抜ければ要求されたページが表示される仕組み
        }
    }
}