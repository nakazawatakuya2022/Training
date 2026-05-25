using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    /// <summary>
    /// レンタル品データの取得と登録に関する機能を提供する
    /// </summary>
    public interface IRentalItemDataService
    {
        /// <summary>
        /// レンタル品データの一覧を取得
        /// </summary>
        /// <param name="search">検索文字列</param>
        /// <param name="isRentalOnly">レンタル中のみで絞込むフラグ</param>
        /// <returns>レンタル品データの一覧</returns>
        public List<RentalItem> GetList(string? search, bool isRentalOnly);

        /// <summary>
        /// 1件分のレンタル品データを取得
        /// </summary>
        /// <param name="id">レンタル品ID</param>
        /// <returns>レンタル品データ. 一致するものが無ければnullが返る</returns>
        /// 
        public RentalItem? GetById(int id);

        /// <summary>
        /// 1件分のレンタル品データを登録する
        /// </summary>
        /// <param name="rentalItem"></param>
        public void Register(RentalItem rentalItem);

        /// <summary>
        /// 1件分のレンタル品データを更新する.
        /// </summary>
        /// <param name="rentalItem"></param>
        public void Update(RentalItem rentalItem);

        /// <summary>
        /// レンタル品IDに一致する1件分のレンタル品データを削除する.
        /// </summary>
        /// <param name="id">レンタル品ID</param>
        public void DeleteById(int id);

    }
}
