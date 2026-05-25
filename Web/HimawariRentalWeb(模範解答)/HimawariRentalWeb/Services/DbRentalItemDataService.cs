using Microsoft.Data.SqlClient;
using System.Data;
using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    /// <summary>
    /// データベースからデータを取得・登録することでIRentalItemDataServiceを実装する具象クラス
    /// </summary>
    public class DbRentalItemDataService : IRentalItemDataService
    {
        private const byte ON_RENTAL = 1;  // レンタル中

        public List<RentalItem> GetList(string? search, bool isRentalOnly)
        {
            // 空のリストで初期化
            List<RentalItem> list = new List<RentalItem>();
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();

                // 実行するSQL文
                string sql = @"
SELECT  *
FROM rental_items b 
JOIN categories c
  ON b.category_id = c.category_id
WHERE 1 = 1
";
                // 検索文字列の指定がある場合
                if (search != null)
                {
                    sql += @"
AND (
  management_code LIKE @Search OR 
  item_name LIKE @Search OR  
  maker LIKE @Search OR
  storage_location LIKE @Search
)
";
                }
                if (isRentalOnly)
                {
                    sql += @"
AND rental_flag = 1
";
                }
                sql += @"
ORDER BY rental_item_id;
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // SELECT文のパラメータへ置き換える値を指定
                command.Parameters.AddWithValue("@Search", "%" + search + "%");
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから1行分読み出し続ける
                    while (reader.Read())
                    {
                        // 1行分のモデルのインスタンスを生成してリストに追加していく
                        RentalItem rentalItem = new RentalItem(
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
                            reader.GetByte("rental_flag") == ON_RENTAL
                            );
                        list.Add(rentalItem);
                    }
                }
            }
            return list;
        }

        public RentalItem? GetById(int id)
        {
            RentalItem? rentalItem = null;

            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
SELECT *
FROM rental_items b JOIN categories c
  ON b.category_id = c.category_id
WHERE b.rental_item_id = @RentalItemId;
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@RentalItemId", id);
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから１行分読み出し
                    if (reader.Read())
                    {
                        rentalItem = new RentalItem(
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
                            reader.GetByte("rental_flag") == ON_RENTAL
                            );
                    }
                }
            }
            return rentalItem;
        }

        public void Register(RentalItem rentalItem)
        {
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
INSERT INTO rental_items (management_code, item_name, maker, storage_location, purchase_date, purchase_price, memo, category_id, rental_flag)
  VALUES (@ManagementCode, @ItemName, @Maker, @StorageLocation, @PurchaseDate, @PurchasePrice, @Memo, @CategoryId, @RentalFlag);
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーへ置き換える値を指定
                command.Parameters.AddWithValue("@ManagementCode", rentalItem.ManagementCode);
                command.Parameters.AddWithValue("@ItemName", rentalItem.ItemName);
                command.Parameters.AddWithValue("@Maker", rentalItem.Maker);
                command.Parameters.AddWithValue("@StorageLocation", rentalItem.StorageLocation);
                command.Parameters.AddWithValue("@PurchaseDate", rentalItem.PurchaseDate);
                command.Parameters.AddWithValue("@PurchasePrice", rentalItem.PurchasePrice);
                command.Parameters.AddWithValue("@Memo", rentalItem.Memo != null ? rentalItem.Memo : DBNull.Value);
                command.Parameters.AddWithValue("@CategoryId", rentalItem.CategoryId);
                command.Parameters.AddWithValue("@RentalFlag", rentalItem.RentalFlag);
                // コマンドを実行
                command.ExecuteNonQuery();
            }
        }

        public void Update(RentalItem rentalItem)
        {
            using (SqlConnection connection =
               new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
UPDATE rental_items
SET
  management_code = @ManagementCode,
  item_name = @ItemName,
  maker = @Maker,
  storage_location = @StorageLocation,
  purchase_date = @PurchaseDate,
  purchase_price = @PurchasePrice,
  memo = @Memo,
  category_id = @CategoryId,
  rental_flag = @RentalFlag
WHERE rental_item_id = @RentalItemId;
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーへ置き換える値を指定
                command.Parameters.AddWithValue("@RentalItemId", rentalItem.RentalItemId);
                command.Parameters.AddWithValue("@ManagementCode", rentalItem.ManagementCode);
                command.Parameters.AddWithValue("@ItemName", rentalItem.ItemName);
                command.Parameters.AddWithValue("@Maker", rentalItem.Maker);
                command.Parameters.AddWithValue("@StorageLocation", rentalItem.StorageLocation);
                command.Parameters.AddWithValue("@PurchaseDate", rentalItem.PurchaseDate);
                command.Parameters.AddWithValue("@PurchasePrice", rentalItem.PurchasePrice);
                command.Parameters.AddWithValue("@Memo", rentalItem.Memo != null ? rentalItem.Memo : DBNull.Value);
                command.Parameters.AddWithValue("@CategoryId", rentalItem.CategoryId);
                command.Parameters.AddWithValue("@RentalFlag", rentalItem.RentalFlag);
                // コマンドを実行
                command.ExecuteNonQuery();
            }
        }

        public void DeleteById(int id)
        {
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = "DELETE FROM rental_items WHERE rental_item_id = @RentalItemId";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーを置きかえる値を指定
                command.Parameters.AddWithValue("@RentalItemId", id);
                // コマンドを実行
                command.ExecuteNonQuery();
            }
        }
    }
}
