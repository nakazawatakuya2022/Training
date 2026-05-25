using Microsoft.Data.SqlClient;
using System.Data;
using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    /// <summary>
    /// データベースからデータを取得・登録することでICategoryDataServiceを実装する具象クラス
    /// </summary>
    public class DbCategoryDataService : ICategoryDataService
    {
        public List<Category> GetList()
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = "SELECT * FROM categories;";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから1行分読み出し続ける
                    while (reader.Read())
                    {
                        // １行分のモデルのインスタンスを生成してリストに追加していく
                        Category category = new Category(
                            reader.GetInt32("category_id"),
                            reader.GetString("category_name")
                            );
                        categories.Add(category);
                    }
                }
            }
            return categories;
        }
    }
}
