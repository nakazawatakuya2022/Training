using UminekoWeb.Models;

namespace UminekoWeb.Services
{
    /// <summary>
    /// カテゴリデータの取得に関する機能を提供する
    /// </summary>
    public interface ICategoryDataService
    {
        /// <summary>
        /// カテゴリデータの一覧を取得する
        /// </summary>
        /// <returns>カテゴリデータのリスト</returns>
        public List<Category> GetList();

    }
}
