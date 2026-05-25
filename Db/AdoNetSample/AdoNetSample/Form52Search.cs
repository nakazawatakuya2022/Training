using AdoNetSample.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetSample
{
    public partial class Form52Search : Form
    {
        public Form52Search()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // データベースへ接続
                connection.Open();

                // 実行するSQL文
                string sql = @"
                        SELECT product_id, product_name, price, p.category_id, category_name, memo
                        FROM products AS p
                        JOIN categories AS c
                        ON p.category_id = c.category_id
                        ";
                // カテゴリIDの指定があるならWHERE句を付ける
                int categoryId;
                if (int.TryParse(textBoxCategoryId.Text, out categoryId))
                {
                    sql += "WHERE p.category_id = @CategoryId";
                }
                sql += ";";

                // データアダプタの生成
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                // SELECT文のパラメータへ置き換える値を指定
                dataAdapter.SelectCommand.Parameters.AddWithValue("@CategoryId", categoryId);
                // データテーブルの生成
                DataTable dataTable = new DataTable();
                // データベースからデータのコピーを取得
                dataAdapter.Fill(dataTable);
                // DataGridViewのデータソースへ設定
                dataGridViewProductList.DataSource = dataTable;
            }
        }
    }
}