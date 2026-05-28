using Microsoft.Data.SqlClient;
using System.Data;
using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    public class DbRankingRentalItemDataService : IRankingRentalItemDataService
    {
        private const int NOT_RETURNED = 0;

        public List<RankingRentalItem> GetRankingList(DateTime startDate, DateTime endDate)
        {
            // 空のリストで初期化
            List<RankingRentalItem> list = new List<RankingRentalItem>();
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();

                // 実行するSQL文
                string sql = @"
                    WITH rental_times AS (
                    SELECT 
                      b.rental_item_id,
                      COUNT(*) AS times
                    FROM rental_histories lh
                    JOIN rental_items b
                      ON lh.rental_item_id = b.rental_item_id
                    WHERE lh.rental_date BETWEEN @StartDate AND @EndDate
                    GROUP BY b.rental_item_id
                    )

                    SELECT TOP 10
                      b.*,
                      c.category_name,
                      lt.times
                    FROM rental_items b
                    JOIN categories c
                      ON b.category_id = c.category_id
                    JOIN rental_times lt
                      ON b.rental_item_id = lt.rental_item_id
                    ORDER BY lt.times DESC;
                ";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // SELECT文のパラメータへ置き換える値を指定
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから1行分読み出し続ける
                    while (reader.Read())
                    {
                        // 1行分のモデルのインスタンスを生成してリストに追加していく
                        RankingRentalItem rentalItem = new RankingRentalItem(
                            reader.GetInt32("rental_item_id"),
                            reader.GetString("management_code"),
                            reader.GetString("item_name"),
                            reader.GetString("maker"),
                            reader.GetString("storage_location"),
                            reader.GetDateTime("purchase_date"),
                            reader.GetInt32("purchase_price"),
                            reader.IsDBNull("memo") ? null : reader.GetString("memo"),
                            reader.GetInt32("category_id"),
                            reader.GetString("category_name"),
                            false,
                            reader.GetInt32("times")
                            );
                        list.Add(rentalItem);
                    }
                }
            }
            return list;
        }
    }
}
