using Microsoft.Data.SqlClient;
using System.Data;
using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    public class DbUserAccountDataService : IUserAccountDataService
    {
        public UserAccount? GetById(string staffId)
        {
            UserAccount? userAccount = null;

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = "SELECT * FROM staffs WHERE staff_id = @StaffId";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // パラメータを置きかえ
                command.Parameters.AddWithValue("@StaffId", staffId);
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから1行分読み出す
                    if (reader.Read())
                    {
                        userAccount = new UserAccount(
                            reader.GetString("staff_id"),
                            reader.GetString("staff_name"),
                            reader.GetString("password"),
                            reader.GetByte("role")
                            );
                    }
                }
            }
            return userAccount;
        }
    }
}
