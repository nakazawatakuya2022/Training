using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using HimawariRentalWeb.Models;
using HimawariRentalWeb.Services;

namespace HimawariRentalWeb.Pages.RentalItems
{
    [TypeFilter(typeof(LoginFilter))]
    public class RankingModel : PageModel
    {
        private readonly IRankingRentalItemDataService _rankingDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="rankingDataService">レンタル回数付きレンタル品データの取得と登録に関する機能</param>
        public RankingModel(IRankingRentalItemDataService rankingDataService)
        {
            _rankingDataService = rankingDataService;
        }

        /// <summary>
        /// 期間開始日
        /// </summary>
        [BindProperty(SupportsGet = true)]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 期間終了日
        /// </summary>
        [BindProperty(SupportsGet = true)]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// データベースから取得したレンタル品データのリスト
        /// </summary>
        public List<RankingRentalItem> RentalItems { get; set; } = new List<RankingRentalItem>();

        public void OnGet()
        {
            if (StartDate != null && EndDate != null)
            {
                RentalItems = _rankingDataService.GetRankingList(
                    (DateTime)StartDate, (DateTime)EndDate);
            }
        }
    }
}
