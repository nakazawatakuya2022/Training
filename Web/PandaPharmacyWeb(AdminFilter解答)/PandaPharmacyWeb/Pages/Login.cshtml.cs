using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;
using System.ComponentModel.DataAnnotations;

namespace PandaPharmacyWeb.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserDataService _userDataService;

        public LoginModel(IUserDataService userDataService)
        {
            _userDataService = userDataService;
        }

        [BindProperty]
        [Required]
        public string? UserName { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        // 1. ログインが失敗したらtrueになるフラグを用意
        // bool型のフィールドは初期値がfalse
        public bool LoginFailed { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (UserName == null || Password == null)
            {
                return Page();
            }

            User? userAccount = _userDataService.GetByName(UserName);
            if (userAccount == null || userAccount.Password != Password)
            {
                // 2. ログインが失敗した旨プロパティへ格納
                LoginFailed = true;
                return Page();
            }

            HttpContext.Session.SetString("userName", UserName);

            return RedirectToPage("/Index");
        }
    }
}