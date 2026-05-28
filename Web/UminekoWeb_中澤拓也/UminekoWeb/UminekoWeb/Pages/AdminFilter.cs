using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using UminekoWeb.Models;

namespace UminekoWeb
{
    public class AdminFilter : IPageFilter
    {
        public void OnPageHandlerSelected(
            PageHandlerSelectedContext context)
        {
        }

        public void OnPageHandlerExecuting(
            PageHandlerExecutingContext context)
        {
            Staff? staff =
                context.HttpContext.Items["staff"] as Staff;

            if (staff == null || !staff.IsAdmin())
            {
                context.Result =
                    new StatusCodeResult(403);
            }
        }

        public void OnPageHandlerExecuted(
            PageHandlerExecutedContext context)
        {
        }
    }
}