using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;
using System.Data.SqlClient;

namespace PandaPharmacyWeb.Pages.Products
{
    [TypeFilter(typeof(LoginFilter))]
    public class IndexModel : PageModel
    {
        private readonly IProductDataService _productDataService;

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
        public List<Product>? Products { get; set; }

        public void OnGet()
        {
            // 商品データのリストを取得
            Products = _productDataService.GetList(Search);
        }
    }
}
