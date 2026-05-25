using PandaPharmacyWeb.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace PandaPharmacyWeb.Services
{
    public class DbUserDataService : IUserDataService
    {
        public User? GetByName(string userName)
        {
            User? userAccount = null;

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = "SELECT * FROM users " +
                             "  WHERE user_name = @UserName";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // パラメータを置きかえ
                command.Parameters.AddWithValue("@UserName", userName);
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから1行分読み出す
                    if (reader.Read())
                    {
                        userAccount = new User(
                            reader.GetString("user_name"),
                            reader.GetString("password"),
                            reader.GetString("first_name"),
                            reader.GetString("last_name"),
                            reader.GetByte("role")
                            );
                    }
                }
            }
            return userAccount;
        }
    }
}
