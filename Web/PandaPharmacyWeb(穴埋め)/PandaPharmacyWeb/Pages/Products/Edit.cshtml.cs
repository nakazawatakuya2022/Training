using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PandaPharmacyWeb.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly IProductDataService _productDataService;
        private readonly ICategoryDataService _categoryDataService;

        [BindProperty]
        public Product? Product { get; set; }

        public List<Category>? Categories { get; set; } 

        public EditModel(IProductDataService productDataService,
            ICategoryDataService categoryDataService)
        {
            _productDataService = productDataService;
            _categoryDataService = categoryDataService;
        }

        public IActionResult OnGet(int productId)
        {
            Categories = _categoryDataService.GetList(null);

            Product? data = _productDataService.GetById(productId);

            if (data == null)
            {
                return NotFound();
            }

            Product = data;

            return Page();
        }

        public IActionResult OnPost()
        {
            Categories = _categoryDataService.GetList(null);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _productDataService.Update(Product);

            return RedirectToPage("/Products/Index");
        }
    }
}
