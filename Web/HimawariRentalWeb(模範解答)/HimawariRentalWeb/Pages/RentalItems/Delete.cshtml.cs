using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;

namespace HimawariRentalWeb.Pages.RentalItems
{
    [TypeFilter(typeof(AdminFilter))]
    [TypeFilter(typeof(LoginFilter))]
    public class DeleteModel : PageModel
    {
        private readonly IRentalItemDataService _rentalItemDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="rentalItemDataService">レンタル品データの取得と登録に関する機能</param>
        public DeleteModel(IRentalItemDataService rentalItemDataService)
        {
            _rentalItemDataService = rentalItemDataService;
        }

        /// <summary>
        /// 削除対象のレンタル品データ
        /// </summary>
        public RentalItem RentalItem { get; set; } = new RentalItem();

        public IActionResult OnGet(int rentalItemId)
        {
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
            _rentalItemDataService.DeleteById(rentalItemId);

            // 削除後は一覧表示へ戻る
            return RedirectToPage("/RentalItems/Index");
        }
    }
}
