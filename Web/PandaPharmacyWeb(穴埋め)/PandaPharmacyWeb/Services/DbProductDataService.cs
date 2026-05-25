using PandaPharmacyWeb.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace PandaPharmacyWeb.Services
{
    /// <summary>
    /// データベースからデータを取得・登録することでIProductDataServiceを実装する具象クラス
    /// </summary>
    public class DbProductDataService : IProductDataService
    {
        public List<Product> GetList(string? search)
        {
            // 空のリストで初期化
            List<Product> list = new List<Product>();
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();

                // 実行するSQL文
                string sql = @"
SELECT product_id, product_name, price, memo, p.category_id, category_name
FROM products AS p
JOIN categories AS c
  ON p.category_id = c.category_id
WHERE 1 = 1
";
                // 商品名の検索の指定がある場合
                if (search != null)
                {
                    sql += " AND product_name LIKE @ProductName";
                }
                sql += ";";

                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // SELECT文のパラメータへ置き換える値を指定
                command.Parameters.AddWithValue("@ProductName", "%" + search + "%");
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから1行分読み出し続ける
                    while (reader.Read())
                    {
                        // 1行分のモデルのインスタンスを生成してリストに追加していく
                        Product product = new Product(
                            reader.GetInt32("product_id"),
                            reader.GetString("product_name"),
                            reader.GetInt32("price"),
                            reader.IsDBNull("memo") ? null : reader.GetString("memo"),
                            reader.GetInt32("category_id"),
                            reader.GetString("category_name")
                            );
                        list.Add(product);
                    }
                }
            }
            return list;

        }

        public void Register(Product product)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
INSERT INTO products (product_name, price, memo, category_id)
  VALUES (@ProductName, @Price, @Memo, @CategoryId);
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーへ置き換える値を指定
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Memo", product.Memo != null ? product.Memo : DBNull.Value);
                command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                // コマンドを実行
                command.ExecuteNonQuery();
            }
        }

        public Product? GetById(int id)
        {
            Product? product = null;
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
SELECT product_id, product_name, price, memo, p.category_id, category_name
FROM products AS p
JOIN categories AS c
  ON p.category_id = c.category_id
WHERE product_id = @ProductId;
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProductId", id);
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから１行分読み出し
                    if (reader.Read())
                    {
                        product = new Product(
                            reader.GetInt32("product_id"),
                            reader.GetString("product_name"),
                            reader.GetInt32("price"),
                            reader.IsDBNull("memo") ? null : reader.GetString("memo"),
                            reader.GetInt32("category_id"),
                            reader.GetString("category_name")
                            );
                    }
                }
                return product;
            }
        }

        public void Update(Product product)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
UPDATE products
SET
  product_name = @ProductName,
  price = @Price,
  memo = @Memo,
  category_id = @CategoryId
WHERE product_id = @ProductId;
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーへ置き換える値を指定
                command.Parameters.AddWithValue("@ProductId", product.ProductId);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Memo", product.Memo != null ? product.Memo : DBNull.Value);
                command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
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
                string sql = "DELETE FROM products WHERE product_id = @ProductId";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーを置きかえる値を指定
                command.Parameters.AddWithValue("@ProductId", id);
                // コマンドを実行
                command.ExecuteNonQuery();
            }
        }
    }
}
