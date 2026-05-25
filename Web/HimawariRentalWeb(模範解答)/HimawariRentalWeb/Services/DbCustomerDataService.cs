using Microsoft.Data.SqlClient;
using System.Data;
using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    /// <summary>
    /// データベースからデータを取得・登録することでICustomerDataServiceを実装する具象クラス
    /// </summary>
    public class DbCustomerDataService : ICustomerDataService
    {
        public List<Customer> GetList()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = "SELECT * FROM customers;";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから1行分読み出し続ける
                    while (reader.Read())
                    {
                        // １行分のモデルのインスタンスを生成してリストに追加していく
                        Customer customer = new Customer(
                            reader.GetString("customer_code"),
                            reader.GetString("customer_name"),
                            reader.GetString("customer_kana"),
                            reader.GetByte("gender"),
                            reader.GetString("zip_code"),
                            reader.GetString("address1"),
                            reader.IsDBNull("address2") ? null : reader.GetString("address2"),
                            reader.GetString("tel"),
                            reader.IsDBNull("email") ? null : reader.GetString("email"),
                            reader.IsDBNull("memo") ? null : reader.GetString("memo"),
                            reader.GetDateTime("input_date")
                            );
                        customers.Add(customer);
                    }
                }
            }
            return customers;
        }
    }
}
