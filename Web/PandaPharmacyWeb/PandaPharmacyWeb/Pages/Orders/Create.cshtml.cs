using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

namespace PandaPharmacyWeb.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly IOrderDataService _orderDataService;
        private readonly IProductDataService _productDataService;

        [BindProperty]
        public Order Order { get; set; } = new Order();

        public List<Product> Products { get; set; } = new List<Product>();

        public CreateModel(
            IOrderDataService orderDataService,
            IProductDataService productDataService)
        {
            _orderDataService = orderDataService;
            _productDataService = productDataService;
        }

        public void OnGet()
        {
            Products = _productDataService.GetList(null);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Products = _productDataService.GetList(null);
                return Page();
            }

            _orderDataService.Register(Order);

            return RedirectToPage("/Orders/Index");
        }
    }
}