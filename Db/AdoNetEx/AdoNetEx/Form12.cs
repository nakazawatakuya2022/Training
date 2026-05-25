using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form12 : Form
    {
        public Form12()
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
                string sql = @"
                        SELECT
                            license_name,
                            authority,
                            reward
                        FROM
                            licenses
                        WHERE
                            license_id = @LicenseId;
                    ";

                SqlCommand command = new SqlCommand(sql, connection);

                // 追加する箇所
                command.Parameters.AddWithValue("@LicenseId", numericUpDownLicenseId.Value);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxLicenseName.Text = reader["license_name"].ToString();
                        textBoxAuthority.Text = reader["authority"].ToString();
                        textBoxReward.Text = $"{reader["reward"].ToString()}円";
                    }
                    else
                    {
                        textBoxLicenseName.Text = "見つかりませんでした。";
                    }
                }
            }
        }
    }
}
