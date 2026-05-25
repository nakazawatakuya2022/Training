using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using HimawariRentalWeb.Models;

namespace HimawariRentalWeb
{
    public class AdminFilter : IPageFilter
    {
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            UserAccount? userAccount = (UserAccount?)context.HttpContext.Items["userAccount"];
            if (userAccount == null || !userAccount.IsAdmin())
            {
                // 権限が無いユーザの場合は403 Forbiddenを返す
                context.Result = new StatusCodeResult(403);
            }
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
        }
    }
}
