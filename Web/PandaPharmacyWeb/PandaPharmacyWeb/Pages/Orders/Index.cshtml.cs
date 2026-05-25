using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

public class IndexModel : PageModel
{
    private readonly IOrderDataService _orderDataService;

    public IndexModel(
        IOrderDataService orderDataService)
    {
        _orderDataService = orderDataService;
    }

    public List<Order> Orders { get; set; }
        = new();

    public void OnGet()
    {
        Orders =
            _orderDataService.GetList();
    }
}