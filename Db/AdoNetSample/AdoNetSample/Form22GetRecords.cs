using AdoNetSample.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetSample
{
    public partial class Form22GetRecords : Form
    {
        public Form22GetRecords()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                            SELECT 
                                * 
                            FROM 
                                products 
                            WHERE 
                                category_id = @CategoryId;"
                            ;
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CategoryId", numericUpDownCategoryId.Value);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        string textInfo = "";
                        while (reader.Read())
                        {
                            textInfo += string.Format(
                                "{0} ({1}円)",
                                reader.GetString("product_name"), reader.GetInt32("price")
                                ) + Environment.NewLine;
                        }
                        textBoxProductInfo.Text = textInfo;
                    }
                    else
                    {
                        textBoxProductInfo.Text = "入力されたカテゴリIDに該当する商品は存在しません。";
                    }
                }
            }
        }
    }
}