using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebSampleApp.Filters
{
    public class LoginFilter : IAuthorizationFilter
    {
        private bool IsLoggedIn()
        {
            return false;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // ログインしていなければログインページへリダイレクト
            if (!IsLoggedIn())
            {
                context.Result = new RedirectResult("/S19RazorTestResult");
            }

            // このままメソッドを抜ければ本来のページを表示
        }
    }
}