using Microsoft.Data.SqlClient;
using System.Data;
using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    /// <summary>
    /// データベースからデータを取得・登録することでIRentalHistoryDataServiceを実装する具象クラス
    /// </summary>
    public class DbRentalHistoryDataService : IRentalHistoryDataService
    {
        private const int NOT_RETURNED = 0;
        private const int RETURNED = 1;

        public List<RentalHistory> GetList(int rentalItemId)
        {
            List<RentalHistory> histories = new List<RentalHistory>();
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = "SELECT * FROM rental_histories WHERE rental_item_id = @RentalItemId ORDER BY rental_date DESC;";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーへ置き換える値を指定
                command.Parameters.AddWithValue("@RentalItemId", rentalItemId);
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから1行分読み出し続ける
                    while (reader.Read())
                    {
                        // １行分のモデルのインスタンスを生成してリストに追加していく
                        RentalHistory history = new RentalHistory(
                            reader.GetString("customer_code"),
                            reader.GetInt32("rental_item_id"),
                            reader.GetDateTime("rental_date"),
                            reader.GetDateTime("return_date"),
                            reader.IsDBNull("memo") ? null : reader.GetString("memo"),
                            reader.GetByte("has_returned") == RETURNED
                            );
                        histories.Add(history);
                    }
                }
            }
            return histories;
        }

        public void Register(RentalHistory rentalHistory)
        {
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
INSERT INTO rental_histories (customer_code, rental_item_id, rental_date, return_date, memo, has_returned)
  VALUES (@CustomerCode, @RentalItemId, @RentalDate, @ReturnDate, @Memo, @HasReturned);
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーへ置き換える値を指定
                command.Parameters.AddWithValue("@CustomerCode", rentalHistory.CustomerCode);
                command.Parameters.AddWithValue("@RentalItemId", rentalHistory.RentalItemId);
                command.Parameters.AddWithValue("@RentalDate", rentalHistory.RentalDate);
                command.Parameters.AddWithValue("@ReturnDate", rentalHistory.ReturnDate);
                command.Parameters.AddWithValue("@Memo", rentalHistory.Memo != null ? rentalHistory.Memo : DBNull.Value);
                command.Parameters.AddWithValue("@HasReturned", NOT_RETURNED);
                // コマンドを実行
                command.ExecuteNonQuery();
            }
        }

        public void Update(RentalHistory rentalHistory)
        {
            using (SqlConnection connection =
               new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
UPDATE rental_histories
SET
  return_date = @ReturnDate,
  memo = @Memo,
  has_returned = @HasReturned
WHERE 
  customer_code = @CustomerCode AND 
  rental_item_id = @RentalItemId AND 
  rental_date = @RentalDate;
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーへ置き換える値を指定
                command.Parameters.AddWithValue("@ReturnDate", rentalHistory.ReturnDate);
                command.Parameters.AddWithValue("@Memo", rentalHistory.Memo != null ? rentalHistory.Memo : DBNull.Value);
                command.Parameters.AddWithValue("@HasReturned", rentalHistory.HasReturned);
                command.Parameters.AddWithValue("@CustomerCode", rentalHistory.CustomerCode);
                command.Parameters.AddWithValue("@RentalItemId", rentalHistory.RentalItemId);
                command.Parameters.AddWithValue("@RentalDate", rentalHistory.RentalDate);
                // コマンドを実行
                command.ExecuteNonQuery();
            }
        }
    }
}
