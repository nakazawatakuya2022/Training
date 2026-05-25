using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form52 : Form
    {
        public Form52()
        {
            InitializeComponent();
        }

        private void Form52_Load(object sender, EventArgs e)
        {
            UpdateLicenseList();
        }

        private void UpdateLicenseList()
        {
            string connectionStr = Settings.Default.DbConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        *
                    FROM
                        licenses
                    ORDER BY
                        license_id;
                ";

                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string textInfo =
                        "資格ID｜資格名｜認定団体｜資格手当"
                        + Environment.NewLine;

                    while (reader.Read())
                    {
                        textInfo += string.Format(
                            "{0}｜{1}｜{2}｜{3}",
                            reader.GetInt32("license_id"),
                            reader.GetString("license_name"),
                            reader.GetString("authority"),
                            reader.GetInt32("reward")
                        ) + Environment.NewLine;
                    }

                    textBoxList.Text = textInfo;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                    DELETE FROM
                        licenses
                    WHERE
                        license_id = @LicenseId;
                ";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@LicenseId",
                    (int)numericUpDownId.Value
                );

                int result = command.ExecuteNonQuery();

                MessageBox.Show(
                    result + "件のデータを削除しました。"
                );

                UpdateLicenseList();
            }
        }
    }
}