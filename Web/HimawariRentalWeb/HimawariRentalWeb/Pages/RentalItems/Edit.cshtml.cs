using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HimawariRentalWeb.Pages.RentalItems
{
    public class EditModel : PageModel
    {
        private readonly IRentalItemDataService _rentalItemDataService;
        private readonly ICategoryDataService _categoryDataService;

        public EditModel(
            IRentalItemDataService rentalItemDataService,
            ICategoryDataService categoryDataService)
        {
            _rentalItemDataService = rentalItemDataService;
            _categoryDataService = categoryDataService;
        }

        [BindProperty]
        public RentalItem RentalItem { get; set; } = new();

        public List<Category> Categories { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            Categories = _categoryDataService.GetList();

            RentalItem? data =
                _rentalItemDataService.GetById(id);

            if (data == null)
            {
                return NotFound();
            }

            RentalItem = data;

            return Page();
        }

        public IActionResult OnPost()
        {
            Categories = _categoryDataService.GetList();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _rentalItemDataService.Update(RentalItem);

            return RedirectToPage("Index");
        }
    }
}