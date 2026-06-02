using Microsoft.Data.SqlClient;
using System.Data;
using YokoamiPetWeb.Models;

namespace YokoamiPetWeb.Services
{
    /// <summary>
    /// 実施サービス履歴データをDBから操作するクラス
    /// </summary>
    public class DbHistoryDataService : IHistoryDataService
    {
        /// <summary>
        /// 実施サービス履歴一覧を取得する
        /// </summary>
        public List<History> GetList()
        {
            // 履歴一覧を格納するリストを生成
            List<History> histories = new();

            // DB接続用のコネクションを生成（接続文字列を指定）
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                // 一覧表示のSQL文を生成
                string sql = @"
                    SELECT
                        h.id,
                        h.pet_id,
                        h.service_id,
                        h.service_date,
                        o.name AS owner_name,
                        p.name AS pet_name,
                        s.name AS service_name,
                        s.price
                    FROM history h
                    JOIN pet p
                        ON h.pet_id = p.id
                    JOIN owner o
                        ON p.owner_id = o.id
                    JOIN service s
                        ON h.service_id = s.id
                    ORDER BY h.service_date ASC
                    ";

                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);

                // コマンドを実行して、データリーダーを取得
                using (SqlDataReader reader =command.ExecuteReader())
                {
                    // データリーダーから1行ずつ読み取る
                    while (reader.Read())
                    {
                        History history = new History(
                            reader.GetInt32("id"),
                            reader.GetInt32("pet_id"),
                            reader.GetInt32("service_id"),
                            reader.GetDateTime("service_date"),
                            reader.GetString("owner_name"),
                            reader.GetString("pet_name"),
                            reader.GetString("service_name"),
                            reader.GetInt32("price")
                        );

                        // 生成した履歴をリストに追加
                        histories.Add(history);
                    }
                }
            }
            // 生成した履歴のリストを返す
            return histories;
        }

        /// <summary>
        /// 指定した実施サービスIDの履歴を取得する
        /// </summary>
        public History? GetById(int id)
        {
            // １件表示の履歴を格納する変数を生成
            History? history = null;

            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                // １件表示のSQL文を生成
                string sql = @"
                    SELECT
                        h.id,
                        h.pet_id,
                        h.service_id,
                        h.service_date,
                        o.name AS owner_name,
                        p.name AS pet_name,
                        s.name AS service_name,
                        s.price
                    FROM history h
                    JOIN pet p
                        ON h.pet_id = p.id
                    JOIN owner o
                        ON p.owner_id = o.id
                    JOIN service s
                        ON h.service_id = s.id
                    WHERE h.id = @Id
                    ";

                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);

                // SQL文のパラメーターに値を設定
                command.Parameters.AddWithValue("@Id", id);

                // コマンドを実行して、データリーダーを取得
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // データリーダーから1行読み取る
                    if (reader.Read())
                    {
                        history = new History(
                            reader.GetInt32("id"),
                            reader.GetInt32("pet_id"),
                            reader.GetInt32("service_id"),
                            reader.GetDateTime("service_date"),
                            reader.GetString("owner_name"),
                            reader.GetString("pet_name"),
                            reader.GetString("service_name"),
                            reader.GetInt32("price")
                        );
                    }
                }

            }
            // 生成した履歴を返す
            return history;
        }

        /// <summary>
        /// 実施サービス履歴を登録する
        /// </summary>
        public void Register(History history)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                // 新規登録のSQL文を生成
                string sql = @"
                    INSERT INTO history
                    (
                        pet_id,
                        service_id,
                        service_date
                    )
                    VALUES
                    (
                        @PetId,
                        @ServiceId,
                        @ServiceDate
                    )
                    ";

                // コマンドを生成（SQL文とコネクションを指定）
                SqlCommand command = new SqlCommand(sql, connection);

                // SQL文のパラメーターに値を設定
                command.Parameters.AddWithValue("@PetId", history.PetId);
                command.Parameters.AddWithValue("@ServiceId", history.ServiceId);
                command.Parameters.AddWithValue("@ServiceDate", history.ServiceDate);

                // コマンドを実行して、DBに登録する
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 実施サービス履歴を更新する
        /// </summary>
        public void Update(History history)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
                    UPDATE history
                    SET
                        pet_id = @PetId,
                        service_id = @ServiceId,
                        service_date = @ServiceDate
                    WHERE
                        id = @Id
                    ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@PetId",history.PetId);
                command.Parameters.AddWithValue("@ServiceId",history.ServiceId);
                command.Parameters.AddWithValue("@ServiceDate",history.ServiceDate);
                command.Parameters.AddWithValue("@Id",history.Id);

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 指定した実施サービスIDの履歴を削除する
        /// </summary>
        public void Delete(int id)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.DbConnectStr))
            {
                connection.Open();

                string sql = @"
                    DELETE FROM history
                    WHERE id = @Id
                    ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@Id",
                    id);

                command.ExecuteNonQuery();
            }
        }
    }
}