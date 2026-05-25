using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;

namespace HimawariRentalWeb.Pages.RentalItems
{
    [TypeFilter(typeof(AdminFilter))]
    [TypeFilter(typeof(LoginFilter))]
    public class EditModel : PageModel
    {
        private readonly IRentalItemDataService _rentalItemDataService;
        private readonly ICategoryDataService _categoryDataService;

        /// <summary>
        /// 編集対象のレンタル品データ
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
        public EditModel(IRentalItemDataService rentalItemDataService,
            ICategoryDataService categoryDataService)
        {
            _rentalItemDataService = rentalItemDataService;
            _categoryDataService = categoryDataService;
        }

        public IActionResult OnGet(int rentalItemId)
        {
            Categories = _categoryDataService.GetList();
            RentalItem? data = _rentalItemDataService.GetById(rentalItemId);
            // 見つからない場合はエラー表示へ
            if (data == null)
            {
                return NotFound();  // HTTP 404 Not Found
            }
            RentalItem = data;
            return Page();
        }

        public IActionResult OnPost(int rentalItemId)
        {
            // 通常は起こらないケースだがデータが送信されてきていない場合エラー表示へ
            if (RentalItem == null)
            {
                return BadRequest();  // HTTP 400 Bad Request
            }

            // 入力された内容が不正であれば同じページで再入力を促す
            if (!ModelState.IsValid)
            {
                // 再入力を行う際にまたカテゴリ一覧が必要
                Categories = _categoryDataService.GetList();
                return Page();
            }

            _rentalItemDataService.Update(RentalItem);

            // 登録後は一覧表示へ戻る
            return RedirectToPage("/RentalItems/Index");
        }
    }
}
