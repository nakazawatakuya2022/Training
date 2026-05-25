using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;

namespace HimawariRentalWeb.Pages.RentalItems
{
    [TypeFilter(typeof(LoginFilter))]
    public class RentModel : PageModel
    {
        private readonly IRentalItemDataService _rentalItemDataService;
        private readonly IRentalHistoryDataService _rentalHistoryDataService;
        private readonly ICustomerDataService _customerDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="rentalItemDataService">レンタル品データの取得と登録に関する機能</param>
        /// <param name="rentalHistoryDataService">レンタル履歴データの取得と登録に関する機能</param>
        /// <param name="customerDataService">顧客データの取得と登録に関する機能</param>
        public RentModel(IRentalItemDataService rentalItemDataService,
            IRentalHistoryDataService rentalHistoryDataService,
            ICustomerDataService customerDataService)
        {
            _rentalItemDataService = rentalItemDataService;
            _rentalHistoryDataService = rentalHistoryDataService;
            _customerDataService = customerDataService;
        }

        /// <summary>
        /// 詳細表示対象のレンタル品データ
        /// </summary>
        public RentalItem RentalItem { get; set; } = new RentalItem();

        /// <summary>
        /// 登録対象のレンタル履歴データ
        /// </summary>
        [BindProperty]
        public RentalHistory RentalHistory { get; set; } = new RentalHistory();

        /// <summary>
        /// 顧客データの一覧（ドロップダウンリストから選択可能にするための）
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public IActionResult OnGet(int rentalItemId)
        {
            RentalItem? data = _rentalItemDataService.GetById(rentalItemId);
            // 見つからない場合はエラー表示へ
            if (data == null)
            {
                return NotFound();  // HTTP 404 Not Found
            }
            RentalItem = data;

            Customers = _customerDataService.GetList();
            RentalHistory = new RentalHistory();
            return Page();
        }

        public IActionResult OnPost(int rentalItemId)
        {
            // 対象のレンタル品データを取得しておく
            RentalItem? data = _rentalItemDataService.GetById(rentalItemId);
            // 見つからない場合はエラー表示へ
            if (data == null)
            {
                return NotFound();  // HTTP 404 Not Found
            }
            RentalItem = data;

            // パラメータが正しくない場合
            if (!ModelState.IsValid || RentalHistory == null)
            {
                // 再入力を行う際にまたデータの初期化が必要
                Customers = _customerDataService.GetList();
                RentalHistory = new RentalHistory();
                return Page();
            }

            // レンタル品IDをレンタル品データと同じものでセット
            RentalHistory.RentalItemId = RentalItem.RentalItemId;
            // レンタル日を本日の日付, 返却日を2週間後の日付で設定する
            RentalHistory.RentalDate = DateTime.Now;
            RentalHistory.ReturnDate = DateTime.Now.AddDays(14);
            _rentalHistoryDataService.Register(RentalHistory);

            // 対象のレンタル品データをレンタル中状態にする
            RentalItem.RentalFlag = true;
            _rentalItemDataService.Update(RentalItem);

            // レンタル処理完了後は詳細表示へ戻る
            return RedirectToPage("/RentalItems/Detail",
                new
                {
                    RentalItemId = rentalItemId
                });
        }
    }
}
