using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;

namespace HimawariRentalWeb.Pages.RentalItems
{
    public class IndexModel : PageModel
    {
        private readonly IRentalItemDataService _rentalItemDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="rentalItemDataService">レンタル品データの取得と登録に関する機能</param>
        public IndexModel(IRentalItemDataService rentalItemDataService)
        {
            _rentalItemDataService = rentalItemDataService;
        }

        /// <summary>
        /// 検索用キーワード
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string? Search { get; set; }

        /// <summary>
        /// レンタル中のみ絞込みフラグ
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public bool IsRentalOnly { get; set; }

        /// <summary>
        /// 一覧表示するレンタル品データのリスト
        /// </summary>
        public List<RentalItem>? RentalItems { get; set; } = new();

        public void OnGet()
        {
            // TODO: RentalItemsプロパティのデータを正しくセットすること
            RentalItems =
                _rentalItemDataService.GetList(Search, IsRentalOnly);
        }
    }
}
