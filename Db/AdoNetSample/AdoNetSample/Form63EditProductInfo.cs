using AdoNetSample.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetSample
{
    public partial class Form63EditProductInfo : Form
    {
        public Form63EditProductInfo()
        {
            InitializeComponent();
        }

        private int _productId;

        public Form63EditProductInfo(int productId)
        {
            InitializeComponent();
            _productId = productId;
        }

        private void Form63EditProductInfo_Load(object sender, EventArgs e)
        {
            LoadCategoryDataFromDb();
            LoadProductDataFromDb();
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
                    SELECT product_id, product_name, price, category_name, memo, p.category_id AS category_id
                    FROM products AS p
                    JOIN categories AS c
                      ON p.category_id = c.category_id
                    WHERE product_id = @ProductId;
                    ";
                // コマンドを生成(SQL文とコネクションを指定)
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProductId", _productId);
                // SQLコマンドを実行
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // リーダーから1行分読み出す
                    if (reader.Read())
                    {
                        numericUpDownProductId.Value = reader.GetInt32("product_id");
                        textBoxProductName.Text = reader.GetString("product_name");
                        numericUpDownPrice.Value = reader.GetInt32("price");
                        // memoはNullである可能性があるのでチェックが必要
                        textBoxMemo.Text = reader.IsDBNull("memo") ? "" : reader.GetString("memo");
                        comboBoxCategory.SelectedValue = reader.GetInt32("category_id");
                    }
                }
            }
        }

        private void LoadCategoryDataFromDb()
        {
            string connectionStr = Settings.Default.DbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // データベースへ接続
                connection.Open();

                // 実行するSQL文
                string sql = "SELECT * FROM categories ORDER BY category_id";

                // データアダプタの生成
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

                // データテーブルの生成
                DataTable dataTable = new DataTable();

                // データベースからデータのコピーを取得
                dataAdapter.Fill(dataTable);

                // ComboBoxのデータソースにデータテーブルをセット
                comboBoxCategory.DisplayMember = "category_name";
                comboBoxCategory.ValueMember = "category_id";
                comboBoxCategory.DataSource = dataTable;
            }
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStr))
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
                // コマンドを生成(SQL文とコネクションを指定)
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // パラメータへ置き換える値を指定
                    command.Parameters.AddWithValue("@ProductId", numericUpDownProductId.Value);
                    command.Parameters.AddWithValue("@ProductName", textBoxProductName.Text);
                    command.Parameters.AddWithValue("@Price", numericUpDownPrice.Value);
                    command.Parameters.AddWithValue("@Memo", textBoxMemo.Text);
                    command.Parameters.AddWithValue("@CategoryId", comboBoxCategory.SelectedValue);
                    // コマンドを実行
                    int result = command.ExecuteNonQuery();
                    MessageBox.Show(result + "件のデータを更新しました。");
                }
            }
        }
    }
}
