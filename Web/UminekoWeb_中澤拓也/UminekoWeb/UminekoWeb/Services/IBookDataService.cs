using UminekoWeb.Models;

namespace UminekoWeb.Services
{
    /// <summary>
    /// 蔵書データの取得と登録に関する機能を提供する
    /// </summary>
    public interface IBookDataService
    {
        /// <summary>
        /// 蔵書データの一覧を取得
        /// </summary>
        /// <param name="search">検索文字列</param>
        /// <param name="isLentOnly">貸出中のみで絞込むフラグ</param>
        /// <returns>書籍データの一覧</returns>
        List<Book> GetList(string? search, bool isLentOnly);

        /// <summary>
        /// 1件分の蔵書データを取得
        /// </summary>
        /// <param name="id">蔵書ID</param>
        /// <returns>蔵書データ. 一致するものが無ければnullが返る</returns>
        /// 
        Book? GetById(int id);

        /// <summary>
        /// 1件分の蔵書データを登録する
        /// </summary>
        /// <param name="book"></param>
        void Register(Book book);

        /// <summary>
        /// 1件分の蔵書データを更新する.
        /// </summary>
        /// <param name="book"></param>
        void Update(Book book);

        /// <summary>
        /// 蔵書IDに一致する1件分の蔵書データを削除する.
        /// </summary>
        /// <param name="id">蔵書ID</param>
        void DeleteById(int id);
    }
}
