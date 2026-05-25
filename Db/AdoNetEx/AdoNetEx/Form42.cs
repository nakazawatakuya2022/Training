using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;


namespace AdoNetEx
{
    public partial class Form42 : Form
    {
        public Form42()
        {
            InitializeComponent();
        }
        private void Form42InsertRecord_Load(object sender, EventArgs e)
        {
            UpdateDepartmentList();
        }
        private void UpdateDepartmentList()
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
                    string textInfo = "資格ID｜資格名｜認定団体｜資格手当"
                    + Environment.NewLine;

                    while (reader.Read())
                    {
                        textInfo += string.Format(
                            "{0}:{1}:{2}:{3}",
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                            UPDATE
                                licenses
                            SET
                                license_name = @LicenseName,
                                authority = @Authority,
                                reward = @Reward
                            WHERE
                                license_id = @LicenseId;
                        ";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@LicenseId",
                    numericUpDownId.Value
                );

                command.Parameters.AddWithValue(
                    "@LicenseName",
                    textBoxName.Text
                );

                command.Parameters.AddWithValue(
                    "@Authority",
                    textBoxAuthority.Text
                );

                command.Parameters.AddWithValue(
                    "@Reward",
                    numericUpDownReward.Value
                );

                int result = command.ExecuteNonQuery();

                MessageBox.Show(
                    result + "件のデータを更新しました。"
                );

                UpdateDepartmentList();
            }
        }

    }
}
