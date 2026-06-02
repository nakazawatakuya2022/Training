using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YokoamiPetWeb.Models;
using YokoamiPetWeb.Services;

namespace YokoamiPetWeb.Pages.Histories
{
    public class EditModel : PageModel
    {
        private readonly IHistoryDataService _historyDataService;
        private readonly IPetServices _petServices;
        private readonly IServiceDataService _serviceDataService;

        public EditModel(
            IHistoryDataService historyDataService,
            IPetServices petServices,
            IServiceDataService serviceDataService)
        {
            _historyDataService = historyDataService;
            _petServices = petServices;
            _serviceDataService = serviceDataService;
        }

        [BindProperty]
        public History History { get; set; } = new();

        public List<Pet> Pets { get; set; } = new();

        public List<Service> Services { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            History? history = _historyDataService.GetById(id);

            if (history == null)
            {
                return NotFound();
            }

            History = history;

            Pets = _petServices.GetList();
            Services = _serviceDataService.GetList();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Pets = _petServices.GetList();
                Services = _serviceDataService.GetList();

                return Page();
            }

            _historyDataService.Update(History);

            return RedirectToPage("./Index");
        }
    }
}