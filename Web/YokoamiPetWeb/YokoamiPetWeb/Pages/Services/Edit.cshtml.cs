using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YokoamiPetWeb.Models;
using YokoamiPetWeb.Services;

namespace YokoamiPetWeb.Pages.Services
{
    public class EditModel : PageModel
    {
        private readonly IServiceDataService _serviceDataService;

        public EditModel(
            IServiceDataService serviceDataService)
        {
            _serviceDataService = serviceDataService;
        }

        [BindProperty]
        public Service Service { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            Service? service =
                _serviceDataService.GetById(id);

            if (service == null)
            {
                return NotFound();
            }

            Service = service;

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _serviceDataService.Update(Service);

            return RedirectToPage("./Index");
        }
    }
}