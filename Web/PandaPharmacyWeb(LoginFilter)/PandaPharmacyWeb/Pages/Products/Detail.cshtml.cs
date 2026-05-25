using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

namespace PandaPharmacyWeb.Pages.Products
{
    public class DetailModel : PageModel
    {
        private readonly IProductDataService _productDataService;

        /// <summary>
        /// 表示対象の商品データ
        /// </summary>
        public Product? Product { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="productDataService">商品データの取得と登録に関する機能</param>
        public DetailModel(IProductDataService productDataService)
        {
            _productDataService = productDataService;
        }

        public void OnGet(int productId)
        {
            // 現在の対象のデータをDBから取得し初期化
            Product = _productDataService.GetById(productId);
        }
    }
}
