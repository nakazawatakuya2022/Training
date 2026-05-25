using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PandaPharmacyWeb.Models;
using PandaPharmacyWeb.Services;

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
        public CreateModel(IProductDataService productDataService,
            ICategoryDataService categoryDataService)
        {
            _productDataService = productDataService;
            _categoryDataService = categoryDataService;
        }

        public void OnGet()
        {
            Categories = _categoryDataService.GetList(null);
        }

        public IActionResult OnPost()
        {
            // 入力された内容が不正であれば同じページで再入力を促す
            if (!ModelState.IsValid)
            {
                Categories = _categoryDataService.GetList(null);
                return Page();
            }

            _productDataService.Register(Product);

            // 作成後は一覧表示へ戻る
            return RedirectToPage("/Products/Index");
        }
    }
}
