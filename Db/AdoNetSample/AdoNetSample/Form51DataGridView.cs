using AdoNetSample.Properties;
using Microsoft.Data.SqlClient;
using System.Data;


namespace AdoNetSample
{
    public partial class Form51DataGridView : Form
    {
        public Form51DataGridView()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                            SELECT product_id, product_name, price, p.category_id, category_name, memo
                            FROM products AS p
                            JOIN categories AS c
                              ON p.category_id = c.category_id;
                            ";

                // データアダプタがSQLを実行する準備をする（まだSQLは実行していない）
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                // データテーブルはSQLの実行結果を受け取るための入れ物（リーダーのような立ち位置）
                DataTable dataTable = new ();
                // データアダプターによりSQLが実行され、データテーブルに入る
                dataAdapter.Fill(dataTable);

                // DataGridViewのデータソースへ設定
                dataGridView1.DataSource = dataTable;
            }
        }

    }
}