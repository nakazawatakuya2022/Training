using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

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
        public Product Product { get; set; } = new Product();

        public IActionResult OnGet(int productId)
        {
            Product? data = _productDataService.GetById(productId);
            // 見つからない場合はエラー表示へ
            if (data == null)
            {
                return NotFound();  // HTTP 404 Not Found
            }
            Product = data;
            return Page();
        }

        public IActionResult OnPost(int productId)
        {
            _productDataService.DeleteById(productId);

            // 削除後は一覧表示へ戻る
            return RedirectToPage("/Products/Index");
        }
    }
}
