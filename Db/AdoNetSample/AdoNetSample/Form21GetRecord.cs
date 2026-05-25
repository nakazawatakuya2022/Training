using AdoNetSample.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetSample
{
    public partial class Form21GetRecord : Form
    {
        public Form21GetRecord()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                // 書き換える箇所
                string sql = "SELECT * FROM products WHERE product_id = @ProductId;";

                SqlCommand command = new SqlCommand(sql, connection);

                // 追加する箇所
                command.Parameters.AddWithValue("@ProductId", numericUpDownProductId.Value);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxProductName.Text = reader.GetString("product_name");
                    }
                    else
                    {
                        textBoxProductName.Text = "入力された商品IDに該当する商品は存在しません。";
                    }
                }
            }
        }
    }
}