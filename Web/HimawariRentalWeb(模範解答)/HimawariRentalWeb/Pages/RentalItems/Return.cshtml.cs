using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;

namespace HimawariRentalWeb.Pages.RentalItems
{
    [TypeFilter(typeof(LoginFilter))]
    public class ReturnModel : PageModel
    {
        private readonly IRentalItemDataService _rentalItemDataService;
        private readonly IRentalHistoryDataService _rentalHistoryDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="rentalItemDataService">レンタル品データの取得と登録に関する機能</param>
        /// <param name="rentalHistoryDataService">レンタル履歴データの取得と登録に関する機能</param>
        public ReturnModel(IRentalItemDataService rentalItemDataService,
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
        /// 最新のレンタル履歴データを取得する
        /// </summary>
        /// <param name="rentalItemId"></param>
        /// <returns></returns>
        private RentalHistory? GetLatestRentalHistory(int rentalItemId)
        {
            List<RentalHistory> rentalHistories = _rentalHistoryDataService.GetList(rentalItemId);
            if (rentalHistories != null && rentalHistories.Count > 0)
            {
                return rentalHistories[0];
            }
            return null;
        }

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
            RentalItem? data = _rentalItemDataService.GetById(rentalItemId);
            // 見つからない場合はエラー表示へ
            if (data == null)
            {
                return NotFound();  // HTTP 404 Not Found
            }
            RentalItem = data;

            RentalHistory? latestRentalHistory = GetLatestRentalHistory(rentalItemId); 
            // 見つからない場合はエラー表示へ
            if (latestRentalHistory == null)
            {
                return NotFound();  // HTTP 404 Not Found
            }

            latestRentalHistory.ReturnDate = DateTime.Now;
            latestRentalHistory.HasReturned = true;
            _rentalHistoryDataService.Update(latestRentalHistory);

            // 対象のレンタル品データを利用可状態にする
            RentalItem.RentalFlag = false;
            _rentalItemDataService.Update(RentalItem);

            // レンタル処理完了後は詳細表示へ戻る
            return RedirectToPage("/RentalItems/Detail",
                new
                {
                    rentalItemId = rentalItemId
                });
        }
    }
}
