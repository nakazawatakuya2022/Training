using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PandaPharmacyWeb.Models;

namespace PandaPharmacyWeb
{
    public class AdminFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            User? userAccount = (User?)context.HttpContext.Items["userAccount"];
            if (userAccount == null || !userAccount.IsAdmin())
            {
                // 権限が無いユーザの場合は403 Forbiddenを返す
                context.Result = new StatusCodeResult(403);
            }

            // このまま抜ければ要求されたページが表示される仕組み
        }
    }
}
