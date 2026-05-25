using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;

namespace HimawariRentalWeb.Pages.RentalItems
{
    [TypeFilter(typeof(AdminFilter))]
    [TypeFilter(typeof(LoginFilter))]
    public class CreateModel : PageModel
    {
        private readonly IRentalItemDataService _rentalItemDataService;
        private readonly ICategoryDataService _categoryDataService;

        /// <summary>
        /// 登録対象のレンタル品データ
        /// </summary>
        [BindProperty]
        public RentalItem RentalItem { get; set; } = new RentalItem();

        /// <summary>
        /// カテゴリ一覧（ドロップダウンリストから選択可能にするための）
        /// </summary>
        public List<Category> Categories { get; set; } = new List<Category>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="rentalItemDataService">レンタル品データの取得と登録に関する機能</param>
        /// <param name="categoryDataService">カテゴリデータの取得と登録に関する機能</param>
        public CreateModel(IRentalItemDataService rentalItemDataService,
            ICategoryDataService categoryDataService)
        {
            _rentalItemDataService = rentalItemDataService;
            _categoryDataService = categoryDataService;
        }
        
        public void OnGet()
        {
            Categories = _categoryDataService.GetList();
        }

        public IActionResult OnPost()
        {
            // 入力された内容が不正であれば同じページで再入力を促す
            if (!ModelState.IsValid)
            {
                Categories = _categoryDataService.GetList();
                return Page();
            }

            _rentalItemDataService.Register(RentalItem);

            // 作成後は一覧表示へ戻る
            return RedirectToPage("/RentalItems/Index");
        }
    }
}
