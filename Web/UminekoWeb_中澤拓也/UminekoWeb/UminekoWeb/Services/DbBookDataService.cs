using Microsoft.Data.SqlClient;
using System.Data;
using UminekoWeb.Models;

namespace UminekoWeb.Services
{
    /// <summary>
    /// データベースからデータを取得・登録することでIBookDataServiceを実装する具象クラス
    /// </summary>
    public class DbBookDataService : IBookDataService
    {
        private const byte ON_LENT = 1;  // 貸出中

        public List<Book> GetList(string? search, bool isLentOnly)
        {
            // 空のリストで初期化
            List<Book> list = new List<Book>();
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();

                // 実行するSQL文
                string sql = @"
SELECT  *
FROM books b 
JOIN categories c
  ON b.category_id = c.category_id
WHERE 1 = 1
";
                // 検索文字列の指定がある場合
                if (search != null)
                {
                    sql += @"
AND (
  isbn LIKE @Search OR 
  title LIKE @Search OR  
  author LIKE @Search OR
  publisher LIKE @Search
)
";
                }
                if (isLentOnly)
                {
                    sql += @"
AND lent_flag = 1
";
                }
                sql += @"
ORDER BY book_id;
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
                        Book book = new Book(
                            reader.GetInt32("book_id"),
                            reader.GetString("isbn"),
                            reader.GetString("title"),
                            reader.GetString("author"),
                            reader.GetString("publisher"),
                            reader.GetDateTime("purchase_date"),
                            reader.GetInt32("purchase_price"),
                            reader.IsDBNull("memo") ? null : reader.GetString("memo"),
                            reader.GetInt32("category_id"),
                            reader.GetString("category_name"),
                            reader.GetByte("lent_flag") == ON_LENT
                            );
                        list.Add(book);
                    }
                }
            }
            return list;
        }

        public Book? GetById(int id)
        {
            Book? book = null;

            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
SELECT *
FROM books b JOIN categories c
  ON b.category_id = c.category_id
WHERE b.book_id = @BookId;
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@BookId", id);
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから１行分読み出し
                    if (reader.Read())
                    {
                        book = new Book(
                            reader.GetInt32("book_id"),
                            reader.GetString("isbn"),
                            reader.GetString("title"),
                            reader.GetString("author"),
                            reader.GetString("publisher"),
                            reader.GetDateTime("purchase_date"),
                            reader.GetInt32("purchase_price"),
                            reader.IsDBNull("memo") ? null : reader.GetString("memo"),
                            reader.GetInt32("category_id"),
                            reader.GetString("category_name"),
                            reader.GetByte("lent_flag") == ON_LENT
                            );
                    }
                }
            }
            return book;
        }

        public void Register(Book book)
        {
            using (SqlConnection connection = new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
INSERT INTO books (isbn, title, author, publisher, purchase_date, purchase_price, memo, category_id, lent_flag)
  VALUES (@Isbn, @Title, @Author, @Publisher, @PurchaseDate, @PurchasePrice, @Memo, @CategoryId, @LentFlag);
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーへ置き換える値を指定
                command.Parameters.AddWithValue("@Isbn", book.Isbn);
                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@Author", book.Author);
                command.Parameters.AddWithValue("@Publisher", book.Publisher);
                command.Parameters.AddWithValue("@PurchaseDate", book.PurchaseDate);
                command.Parameters.AddWithValue("@PurchasePrice", book.PurchasePrice);
                command.Parameters.AddWithValue("@Memo", book.Memo != null ? book.Memo : DBNull.Value);
                command.Parameters.AddWithValue("@CategoryId", book.CategoryId);
                command.Parameters.AddWithValue("@LentFlag", book.LentFlag);
                // コマンドを実行
                command.ExecuteNonQuery();
            }
        }

        public void Update(Book book)
        {
            using (SqlConnection connection =
               new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
UPDATE books
SET
  isbn = @Isbn,
  title = @Title,
  author = @Author,
  publisher = @Publisher,
  purchase_date = @PurchaseDate,
  purchase_price = @PurchasePrice,
  memo = @Memo,
  category_id = @CategoryId,
  lent_flag = @LentFlag
WHERE book_id = @BookId;
";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーへ置き換える値を指定
                command.Parameters.AddWithValue("@BookId", book.BookId);
                command.Parameters.AddWithValue("@Isbn", book.Isbn);
                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@Author", book.Author);
                command.Parameters.AddWithValue("@Publisher", book.Publisher);
                command.Parameters.AddWithValue("@PurchaseDate", book.PurchaseDate);
                command.Parameters.AddWithValue("@PurchasePrice", book.PurchasePrice);
                command.Parameters.AddWithValue("@Memo", book.Memo != null ? book.Memo : DBNull.Value);
                command.Parameters.AddWithValue("@CategoryId", book.CategoryId);
                command.Parameters.AddWithValue("@LentFlag", book.LentFlag);
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
                string sql = "DELETE FROM books WHERE book_id = @BookId";
                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);
                // プレースホルダーを置きかえる値を指定
                command.Parameters.AddWithValue("@BookId", id);
                // コマンドを実行
                command.ExecuteNonQuery();
            }
        }
    }
}
