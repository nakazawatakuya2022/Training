using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

namespace PandaPharmacyWeb.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly IProductDataService _productDataService;

        public DeleteModel(IProductDataService productDataService)
        {
            _productDataService = productDataService;
        }

        [BindProperty]
        public Product? Product { get; set; }

        public IActionResult OnGet(int productId)
        {
            Product = _productDataService.GetById(productId);

            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (Product == null || Product.ProductId == null)
            {
                return BadRequest();
            }

            _productDataService.DeleteById((int)Product.ProductId);

            return RedirectToPage("/Products/Index");
        }
    }
}