using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string connectionStr =
                Settings.Default.DbConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionStr))
            {
                connection.Open();

                try
                {
                    string sql = @"
                                INSERT INTO certified_licenses
                                    (
                                        employee_id,
                                        license_id,
                                        certified_date
                                    )
                                VALUES
                                    (
                                        @employee_id,
                                        @license_id,
                                        @certified_date
                                    );
                            ";
                    SqlCommand command =
                        new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue(
                        "@employee_id",
                        (int)numericUpDownId.Value
                    );

                    command.Parameters.AddWithValue(
                        "@license_id",
                        (int)numericUpDownLicenseId.Value
                    );

                    command.Parameters.AddWithValue(
                        "@certified_date",
                        dateTimePickerCertifiedDate.Value.Date
                    );

                    command.ExecuteNonQuery();

                    MessageBox.Show("登録しました。");

                    UpdateCertifiedLicenseList();

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateCertifiedLicenseList()
        {
            string connectionStr =
                Settings.Default.DbConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        employee_id,
                        license_id,
                        certified_date
                    FROM
                        certified_licenses
                    ORDER BY
                        employee_id,
                        license_id;
                ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    string textInfo =
                        "社員ID｜資格ID｜取得日"
                        + Environment.NewLine;

                    while (reader.Read())
                    {
                        textInfo += string.Format(
                            "{0}｜{1}｜{2}",
                            reader.GetInt32("employee_id"),
                            reader.GetInt32("license_id"),
                            reader.GetDateTime("certified_date")
                                .ToString("yyyy/MM/dd")
                        ) + Environment.NewLine;
                    }

                    textBoxList.Text = textInfo;
                }
            }
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            UpdateCertifiedLicenseList();
        }
    }
}