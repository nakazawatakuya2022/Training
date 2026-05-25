using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PandaPharmacyWeb.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly IProductDataService _productDataService;
        private readonly ICategoryDataService _categoryDataService;

        /// <summary>
        /// 登録対象の商品データ
        /// </summary>
        [BindProperty]
        public Product? Product { get; set; }

        /// <summary>
        /// カテゴリ一覧（ドロップダウンリストから選択可能にするための）
        /// </summary>
        public List<Category>? Categories;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="productDataService">商品データの取得と登録に関する機能</param>
        /// <param name="categoryDataService">カテゴリデータの取得と登録に関する機能</param>
        public CreateModel(IProductDataService productDataService,
            ICategoryDataService categoryDataService)
        {
            _productDataService = productDataService;
            _categoryDataService = categoryDataService;
        }

        public void OnGet()
        {
            // まだ入力前なので空のデータを初期値とする
            Product = new Product();
            Categories = _categoryDataService.GetList(null);
        }

        public IActionResult OnPost()
        {
            // パラメータが正しくない場合
            if (!ModelState.IsValid || Product == null)
            {
                // 再入力を行う際にまたカテゴリ一覧が必要
                Categories = _categoryDataService.GetList(null);
                return Page();
            }

            _productDataService.Register(Product);

            // 作成後は一覧表示へ戻る
            return RedirectToPage("/Products/Index");
        }
    }
}
