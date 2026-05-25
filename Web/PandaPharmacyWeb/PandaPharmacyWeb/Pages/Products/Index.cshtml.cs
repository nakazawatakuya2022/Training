using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

namespace PandaPharmacyWeb.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductDataService _productDataService;
        private readonly ICategoryDataService _categoryDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="productDataService">商品データの取得と登録に関する機能</param>
        public IndexModel(IProductDataService productDataService)
        {
            _productDataService = productDataService;
        }

        /// <summary>
        /// 検索用キーワード
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string? Search { get; set; }

        /// <summary>
        /// データベースから取得した商品データのリスト
        /// </summary>
        public List<Product> Products { get; set; } = new List<Product>();

        public void OnGet()
        {
            // 商品データのリストを取得
            Products = _productDataService.GetList(Search);
        }
    }
}
