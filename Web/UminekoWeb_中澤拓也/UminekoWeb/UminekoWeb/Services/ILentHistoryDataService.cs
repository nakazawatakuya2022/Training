using UminekoWeb.Models;

namespace UminekoWeb.Services
{
    /// <summary>
    /// 貸出履歴データの取得に関する機能を提供する
    /// </summary>
    public interface ILentHistoryDataService
    {
        /// <summary>
        /// 指定した蔵書IDの貸出履歴一覧を取得する
        /// </summary>
        /// <param name="bookId">蔵書ID</param>
        /// <returns>貸出履歴の一覧</returns>
        public List<LentHistory> GetList(int bookId);

        void Register(LentHistory lentHistory);
    }
}