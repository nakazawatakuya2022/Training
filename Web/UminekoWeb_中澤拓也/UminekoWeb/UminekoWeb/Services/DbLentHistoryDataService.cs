using Microsoft.Data.SqlClient;
using System.Data;
using UminekoWeb.Models;

namespace UminekoWeb.Services
{
    /// <summary>
    /// データベースから貸出履歴データを取得するクラス
    /// </summary>
    public class DbLentHistoryDataService : ILentHistoryDataService
    {
        // 貸出履歴の返却済みフラグの値
        private const byte RETURNED = 1;

        public List<LentHistory> GetList(int bookId)
        {
            // 空のリストで初期化
            List<LentHistory> list = new List<LentHistory>();

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                //lent_historiesのbook_idに基づいて、貸出履歴を取得する
                string sql = @"
                    SELECT *
                    FROM lent_histories
                    WHERE book_id = @BookId
                    ORDER BY lent_date DESC;
                    ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@BookId", bookId);

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LentHistory history = new LentHistory(
                            reader.GetString("member_code"),
                            reader.GetInt32("book_id"),
                            reader.GetDateTime("lent_date"),
                            reader.IsDBNull("return_date")
                                ? null
                                : reader.GetDateTime("return_date"),
                            reader.IsDBNull("memo")
                                ? null
                                : reader.GetString("memo"),
                            //tinyint型のhas_returnedをbool型のHasReturnedに変換
                            //式全体がtrue or falseになるように、has_returnedがRETURNEDと等しいかどうかを評価
                            reader.GetByte("has_returned") == RETURNED
                        );

                        list.Add(history);
                    }
                }
            }

            return list;
        }
        //貸し出しのインサート
        public void Register(LentHistory lentHistory)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                // データベースへ接続
                connection.Open();

                // 実行するSQL文
                string sql = @"
                    INSERT INTO lent_histories
                        (
                            member_code,
                            book_id,
                            lent_date,
                            return_date,
                            memo,
                            has_returned
                        )
                    VALUES
                        (
                            @MemberCode,
                            @BookId,
                            @LentDate,
                            @ReturnDate,
                            @Memo,
                            @HasReturned
                        );
                    ";

                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command =
                    new SqlCommand(sql, connection);

                // プレースホルダーへ置き換える値を指定
                command.Parameters.AddWithValue(
                    "@MemberCode",
                    lentHistory.MemberCode);

                command.Parameters.AddWithValue(
                    "@BookId",
                    lentHistory.BookId);

                command.Parameters.AddWithValue(
                    "@LentDate",
                    DateTime.Today);

                command.Parameters.AddWithValue(
                    "@ReturnDate",
                    DateTime.Today.AddDays(14));

                // nullだったらDBのNULLを入れる
                // 左がnullじゃなければ左。nullなら右
                // C#のnullとDBのNULLは別物
                // DBNull.Value でDB用のNULLを表す
                // string と DBNull.Value の型を合わせるため
                // (object)DBNull.Value にしている
                command.Parameters.AddWithValue(
                    "@Memo",
                    lentHistory.Memo ?? (object)DBNull.Value);

                command.Parameters.AddWithValue(
                    "@HasReturned",
                    0);

                // コマンドを実行
                command.ExecuteNonQuery();
            }
        }

        public void Return(int bookId)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
                    UPDATE lent_histories
                    SET
                        has_returned = 1,
                        return_date = @ReturnDate
                    WHERE
                        book_id = @BookId
                        AND has_returned = 0;
                    ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@ReturnDate",
                    DateTime.Today);

                command.Parameters.AddWithValue(
                    "@BookId",
                    bookId);

                command.ExecuteNonQuery();
            }
        }
    }
}