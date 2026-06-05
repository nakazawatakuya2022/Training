using Microsoft.AspNetCore.Mvc.RazorPages;
using YokoamiPetWeb.Models;
using YokoamiPetWeb.Services;

namespace YokoamiPetWeb.Pages.Services
{
    public class IndexModel : PageModel
    {
        private readonly IServiceDataService _serviceDataService;

        public List<Service> Services { get; set; } = new();

        public IndexModel(IServiceDataService serviceDataService)
        {
            _serviceDataService = serviceDataService;
        }

        public void OnGet()
        {
            Services = _serviceDataService.GetList();
        }
    }
}