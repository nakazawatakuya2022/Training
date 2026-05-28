using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using UminekoWeb.Models;
using UminekoWeb.Services;

namespace UminekoWeb
{
    public class LoginFilter : IAuthorizationFilter
    {
        private readonly IStaffDataService _staffDataService;

        public LoginFilter(IStaffDataService staffDataService)
        {
            _staffDataService = staffDataService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string? staffId =
                context.HttpContext.Session.GetString("staffId");

            if (staffId == null)
            {
                context.Result = new RedirectResult("/Login");
                return;
            }

            Staff? staff =
                _staffDataService.GetById(staffId);

            if (staff != null)
            {
                context.HttpContext.Items.Add("staff", staff);
            }
        }
    }
}