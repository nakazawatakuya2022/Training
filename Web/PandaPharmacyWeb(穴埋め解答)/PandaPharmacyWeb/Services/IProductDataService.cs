using PandaPharmacyWeb.Models;

namespace PandaPharmacyWeb.Services
{
    /// <summary>
    /// 商品データの取得と登録に関する機能を提供する
    /// </summary>
    public interface IProductDataService
    {
        /// <summary>
        /// 商品データの一覧を取得する
        /// </summary>
        /// <param name="search">検索用キーワード. nullであれば全検索</param>
        /// <returns>商品データのリスト</returns>
        public List<Product> GetList(string? search);

        /// <summary>
        /// 商品IDに一致する1件分の商品データを取得する.
        /// </summary>
        /// <param name="id">商品ID</param>
        /// <returns>商品データ. IDに一致するものが無ければnullが返る.</returns>
        public Product? GetById(int id);

        /// <summary>
        /// 1件分の商品データを登録する
        /// </summary>
        /// <param name="product"></param>
        public void Register(Product product);

        /// <summary>
        /// 1件分の商品データを更新する.
        /// </summary>
        public void Update(Product product);

        /// <summary>
        /// 商品IDに一致する1件分の商品データを削除する.
        /// </summary>
        /// <param name="id">商品ID</param>
        public void DeleteById(int id);
    }
}
