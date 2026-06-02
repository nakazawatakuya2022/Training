using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YokoamiPetWeb.Models;
using YokoamiPetWeb.Services;

namespace YokoamiPetWeb.Pages.Histories
{
    public class CreateModel : PageModel
    {
        // データサービスを格納するフィールド
        private readonly IHistoryDataService _historyDataService;
        private readonly IPetServices _petServices;
        private readonly IServiceDataService _serviceDataService;

        // コンストラクタでデータサービスを受け取って、フィールドに格納する
        public CreateModel(
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
        public List<Service> Services { get; set; } = new();

        public List<Pet> Pets { get; set; } = new();

        public void OnGet()
        {
            Pets = _petServices.GetList();
            Services = _serviceDataService.GetList();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Pets = _petServices.GetList();
                Services = _serviceDataService.GetList();
                return Page();
            }

            _historyDataService.Register(History);

            return RedirectToPage("./Index");
        }
    }
}
