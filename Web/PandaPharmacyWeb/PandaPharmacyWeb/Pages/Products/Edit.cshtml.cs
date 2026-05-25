using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

namespace PandaPharmacyWeb.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly IProductDataService _productDataService;
        private readonly ICategoryDataService _categoryDataService;

        /// <summary>
        /// 更新対象の商品データ
        /// </summary>
        [BindProperty]
        public Product Product { get; set; } = new Product();

        /// <summary>
        /// カテゴリ一覧（ドロップダウンリストから選択可能にするための）
        /// </summary>
        public List<Category> Categories = new List<Category>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="productDataService">商品データの取得と登録に関する機能</param>
        /// <param name="categoryDataService">カテゴリデータの取得と登録に関する機能</param>
        public EditModel(IProductDataService productDataService,
            ICategoryDataService categoryDataService)
        {
            _productDataService = productDataService;
            _categoryDataService = categoryDataService;
        }

        public IActionResult OnGet(int productId)
        {
            Categories = _categoryDataService.GetList(null);
            // DB上の現在の状態をフォームの初期値として予め表示されるようにセット
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
            // 入力された内容が不正であれば同じページで再入力を促す
            if (!ModelState.IsValid)
            {
                Categories = _categoryDataService.GetList(null);
                return Page();
            }

            _productDataService.Update(Product);

            // 作成後は一覧表示へ戻る
            return RedirectToPage("/Products/Index");
        }
    }
}
