using AdoNetSample.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetSample
{
    public partial class Form31InsertRecord : Form
    {
        public Form31InsertRecord()
        {
            InitializeComponent();
        }

        private void UpdateProductList()
        {
            string connectionStr = Settings.Default.DbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // データベースへ接続
                connection.Open();

                // 実行するSQL文
                string sql = @"
                            SELECT product_id, product_name, price, memo, category_name
                            FROM products AS p
                            JOIN categories AS c
                              ON p.category_id = c.category_id;
                            ";
                // コマンドを生成(SQL文とコネクションを指定)
                SqlCommand command = new SqlCommand(sql, connection);
                // SQLコマンドを実行し結果をリーダーに入れる
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // リーダーから1行分読み出し続ける

                        string textInfo = "";
                        while (reader.Read())
                        {
                            // 1行分の情報を追記していく
                            textInfo += string.Format(
                                "{0}:{1} {2} {3} {4}",
                                reader.GetInt32("product_id"),
                                reader.GetString("category_name"),
                                reader.GetString("product_name"),
                                reader.GetInt32("price") + "円",
                                reader.IsDBNull("memo") ? "説明なし" : reader.GetString("memo")
                            ) + Environment.NewLine;
                        }
                        textBoxProductList.Text = textInfo;
                    }
                    else
                    {
                        textBoxProductList.Text = "商品は存在しません。";
                    }
                }
            }
        }

        private void Form31InsertRecord_Load(object sender, EventArgs e)
        {
            UpdateProductList();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = @"
                    INSERT INTO products (product_name, price, memo, category_id)
                    VALUES (@ProductName, @Price, @Memo, @CategoryId);
                    ";
                // コマンドを生成(SQL文とコネクションを指定)
                SqlCommand command = new SqlCommand(sql, connection);
                // パラメータへ置き換える値を指定
                command.Parameters.AddWithValue("@ProductName", textBoxProductName.Text);
                command.Parameters.AddWithValue("@Price", numericUpDownPrice.Value);
                command.Parameters.AddWithValue("@Memo", textBoxMemo.Text);
                command.Parameters.AddWithValue("@CategoryId", numericUpDownCategoryId.Value);
                // コマンドを実行
                int result = command.ExecuteNonQuery();
                MessageBox.Show(result + "件のデータを登録しました。");
                // 商品リストを更新する
                UpdateProductList();
            }
        }
    }
}
