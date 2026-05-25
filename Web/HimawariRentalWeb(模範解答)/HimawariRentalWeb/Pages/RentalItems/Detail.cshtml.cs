using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;

namespace HimawariRentalWeb.Pages.RentalItems
{
    [TypeFilter(typeof(LoginFilter))]
    public class DetailModel : PageModel
    {
        private readonly IRentalItemDataService _rentalItemDataService;
        private readonly IRentalHistoryDataService _rentalHistoryDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="rentalItemDataService">レンタル品データの取得と登録に関する機能</param>
        /// <param name="rentalHistoryDataService">レンタル履歴データの取得と登録に関する機能</param>
        public DetailModel(IRentalItemDataService rentalItemDataService, 
            IRentalHistoryDataService rentalHistoryDataService)
        {
            _rentalItemDataService = rentalItemDataService;
            _rentalHistoryDataService = rentalHistoryDataService;
        }

        /// <summary>
        /// 詳細表示対象のレンタル品データ
        /// </summary>
        public RentalItem RentalItem { get; set; } = new RentalItem();

        /// <summary>
        /// レンタル履歴一覧
        /// </summary>
        public List<RentalHistory> RentalHistories {  get; set; } = new List<RentalHistory>();

        public IActionResult OnGet(int rentalItemId)
        {
            RentalHistories = _rentalHistoryDataService.GetList(rentalItemId);
            RentalItem? data = _rentalItemDataService.GetById(rentalItemId);
            // 見つからない場合はエラー表示へ
            if (data == null)
            {
                return NotFound();  // HTTP 404 Not Found
            }
            RentalItem = data;
            return Page();
        }
    }
}
