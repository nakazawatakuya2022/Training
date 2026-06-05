using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YokoamiPetWeb.Models;
using YokoamiPetWeb.Services;

namespace YokoamiPetWeb.Pages.Services
{
    public class CreateModel : PageModel
    {
        private readonly IServiceDataService _serviceDataService;

        public CreateModel(
            IServiceDataService serviceDataService)
        {
            _serviceDataService = serviceDataService;
        }

        [BindProperty]
        public Service Service { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _serviceDataService.Register(Service);

            return RedirectToPage("./Index");
        }
    }
}