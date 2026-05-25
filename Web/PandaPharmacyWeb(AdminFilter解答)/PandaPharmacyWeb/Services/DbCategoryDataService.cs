using Microsoft.Data.SqlClient;
using PandaPharmacyWeb.Models;
using System.Data;

namespace PandaPharmacyWeb.Services
{
    public class DbCategoryDataService : ICategoryDataService
    {
        public List<Category> GetList(string? search)
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
        public Category? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Register(Category category)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }

}
