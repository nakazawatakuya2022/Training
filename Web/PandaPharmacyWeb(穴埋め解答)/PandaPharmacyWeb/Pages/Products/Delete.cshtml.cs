using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace PandaPharmacyWeb.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly IProductDataService _productDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="productDataService">商品データの取得と登録に関する機能</param>
        public DeleteModel(IProductDataService productDataService)
        {
            _productDataService = productDataService;
        }

        /// <summary>
        /// 削除対象の商品データ
        /// </summary>
        [BindProperty]
        public Product? Product { get; set; }

        public void OnGet(int productId)
        {
            // 現在の対象のデータを取得し初期化
            Product = _productDataService.GetById(productId);
        }

        public IActionResult OnPost()
        {
            if (Product != null && Product.ProductId != null)
            {
                _productDataService.DeleteById((int)Product.ProductId);
            }

            // 削除後は一覧表示へ戻る
            return RedirectToPage("/Products/Index");
        }
    }
}
