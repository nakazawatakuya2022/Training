using AdoNetSample.Properties;
using Microsoft.Data.SqlClient;
using System.Data;


namespace AdoNetSample
{
    public partial class Form61DisplayProductList : Form
    {
        public Form61DisplayProductList()
        {
            InitializeComponent();
        }
        private void LoadProductDataFromDb()
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
                    WHERE 1 = 1
                    ";
                // カテゴリIDの指定がある場合（数値に変換できる文字列が入力されている場合）
                int categoryId;
                if (int.TryParse(textBoxCategoryId.Text, out categoryId))
                {
                    sql += " AND p.category_id = @CategoryId";
                }
                // 商品名の指定がある場合
                if (textBoxProductName.Text != "")
                {
                    sql += " AND product_name LIKE @ProductName";
                }
                sql += ";";

                // データアダプタの生成
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                // SELECT文のパラメータへ置き換える値を指定
                dataAdapter.SelectCommand.Parameters.AddWithValue("@CategoryId", categoryId);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@ProductName", "%" + textBoxProductName.Text + "%");
                // データテーブルの生成
                DataTable dataTable = new DataTable();
                // データベースからデータのコピーを取得
                dataAdapter.Fill(dataTable);
                // DataGridViewのデータソースへ設定
                dataGridViewProductList.DataSource = dataTable;
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadProductDataFromDb();
        }

        private void buttonShowDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductList.CurrentRow == null)
            {
                return;
            }
            int indexRow = dataGridViewProductList.CurrentRow.Index;
            int productId = (int)dataGridViewProductList[0, indexRow].Value;
            // 現在選択中の行の商品IDをサブフォームのコンストラクタに渡す
            Form61ShowProductInfo form = new Form61ShowProductInfo(productId);
            form.ShowDialog();
        }
    }
}