using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    /// <summary>
    /// レンタル回数付きレンタル品データの取得と登録に関する機能を提供する
    /// </summary>
    public interface IRankingRentalItemDataService
    {
        /// <summary>
        /// 指定期間におけるレンタル回数上位の一覧取得
        /// </summary>
        /// <param name="startDate">期間開始日</param>
        /// <param name="endDate">期間終了日</param>
        /// <returns></returns>
        public List<RankingRentalItem> GetRankingList(DateTime startDate, DateTime endDate);
    }
}
