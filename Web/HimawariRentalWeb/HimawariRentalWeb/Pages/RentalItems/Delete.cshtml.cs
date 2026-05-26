using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HimawariRentalWeb.Pages.RentalItems
{
    public class DeleteModel : PageModel
    {
        private readonly IRentalItemDataService _rentalItemDataService;

        public DeleteModel(IRentalItemDataService rentalItemDataService)
        {
            _rentalItemDataService = rentalItemDataService;
        }

        public RentalItem? RentalItem { get; set; }

        public IActionResult OnGet(int id)
        {
            RentalItem = _rentalItemDataService.GetById(id);

            if (RentalItem == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            _rentalItemDataService.DeleteById(id);

            return RedirectToPage("Index");
        }
    }
}