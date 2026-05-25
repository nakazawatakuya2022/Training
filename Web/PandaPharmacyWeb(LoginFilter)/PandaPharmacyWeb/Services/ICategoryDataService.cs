using PandaPharmacyWeb.Models;

namespace PandaPharmacyWeb.Services
{
    /// <summary>
    /// カテゴリデータの取得と登録に関する機能を提供する
    /// </summary>
    public interface ICategoryDataService
    {
        /// <summary>
        /// カテゴリデータの一覧を取得する
        /// </summary>
        /// <returns>カテゴリデータのリスト</returns>
        /// <param name="search">検索用キーワード. nullであれば全検索</param>
        public List<Category> GetList(string? search);

        /// <summary>
        /// カテゴリIDに一致する1件分のカテゴリデータを取得する.
        /// </summary>
        /// <param name="id">カテゴリID</param>
        /// <returns>カテゴリデータ. IDに一致するものが無ければnullが返る.</returns>
        public Category? GetById(int id);

        /// <summary>
        /// 1件分のカテゴリデータを登録する
        /// </summary>
        /// <param name="category"></param>
        public void Register(Category category);

        /// <summary>
        /// 1件分のカテゴリデータを更新する.
        /// </summary>
        public void Update(Category category);

        /// <summary>
        /// カテゴリIDに一致する1件分のカテゴリデータを削除する.
        /// </summary>
        /// <param name="id">カテゴリID</param>
        public void DeleteById(int id);
    }

}
