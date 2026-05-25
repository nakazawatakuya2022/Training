using AdoNetSample.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetSample
{
    public partial class Form61ShowProductInfo : Form
    {
        public Form61ShowProductInfo()
        {
            InitializeComponent();
        }

        private int _productId;

        public Form61ShowProductInfo(int productId)
        {
            InitializeComponent();
            _productId = productId;
        }

        private void Form61ShowProductInfo_Load(object sender, EventArgs e)
        {
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
                        numericUpDownCategoryId.Value = reader.GetInt32("category_id");
                        textBoxCategoryName.Text = reader.GetString("category_name");
                    }
                }
            }
        }
    }
}