using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using UminekoWeb.Models;
using UminekoWeb.Services;

namespace UminekoWeb.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IStaffDataService _staffDataService;

        public LoginModel(IStaffDataService staffDataService)
        {
            _staffDataService = staffDataService;
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
            if (StaffId == null || Password == null)
            {
                return Page();
            }

            Staff? staff =
                _staffDataService.GetById(StaffId);

            if (staff == null || staff.Password != Password)
            {
                LoginFailed = true;
                return Page();
            }

            HttpContext.Session.SetString("staffId", StaffId);

            return RedirectToPage("/Index");
        }
    }
}