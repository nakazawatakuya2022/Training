using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

namespace PandaPharmacyWeb.Pages.Orders
{
    public class DetailModel : PageModel
    {
        private readonly IOrderDataService _orderDataService;

        public Order Order { get; set; } = new Order();

        public DetailModel(IOrderDataService orderDataService)
        {
            _orderDataService = orderDataService;
        }

        public IActionResult OnGet(int orderId)
        {
            Order? data = _orderDataService.GetById(orderId);

            if (data == null)
            {
                return NotFound();
            }

            Order = data;

            return Page();
        }
    }
}