using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HimawariRentalWeb.Pages.RentalItems
{
    public class CreateModel : PageModel
    {
        private readonly IRentalItemDataService _rentalItemDataService;
        private readonly ICategoryDataService _categoryDataService;

        public CreateModel(
            IRentalItemDataService rentalItemDataService,
            ICategoryDataService categoryDataService)
        {
            _rentalItemDataService = rentalItemDataService;
            _categoryDataService = categoryDataService;
        }

        [BindProperty]
        public RentalItem RentalItem { get; set; } = new();

        public List<Category> Categories { get; set; } = new();

        public void OnGet()
        {
            Categories = _categoryDataService.GetList();
        }

        public IActionResult OnPost()
        {
            Categories = _categoryDataService.GetList();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _rentalItemDataService.Register(RentalItem);

            return RedirectToPage("Index");
        }
    }
}