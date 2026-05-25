using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    /// <summary>
    /// レンタル履歴データの取得と登録に関する機能を提供する
    /// </summary>
    public interface IRentalHistoryDataService
    {
        /// <summary>
        /// レンタル品1件に対するレンタル履歴データの一覧を取得
        /// 並び順はレンタル日の降順とする
        /// </summary>
        /// <param name="rentalItemId">対象のレンタル品ID</param>
        /// <returns>レンタル履歴の一覧</returns>
        public List<RentalHistory> GetList(int rentalItemId);

        /// <summary>
        /// 1件分のレンタル履歴データを登録
        /// </summary>
        /// <param name="rentalHistory">登録するレンタル履歴データ</param>
        public void Register(RentalHistory rentalHistory);

        /// <summary>
        /// 1件分のレンタル履歴データを更新
        /// </summary>
        /// <param name="rentalHistory">更新するレンタル履歴データ</param>
        public void Update(RentalHistory rentalHistory);
    }
}
