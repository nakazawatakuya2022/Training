using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSampleApp.Pages
{
    public class S04RazorTestModel : PageModel
    {
        public string? CompanyName { get; set; }

        public int? ProductId { get; set; }

        public string Introduce()
        {
            return CompanyName + "の" + ProductId + "番の商品ページです";
        }

        public void OnGet(string? companyName, int? productId)
        {
            CompanyName = companyName;
            ProductId = productId;
        }
    }
}