using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form54 : Form
    {
        public Form54()
        {
            InitializeComponent();
        }

        private void Form54_Load(object sender, EventArgs e)
        {
            Form_Load();
        }
        private void Form_Load()
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
                    SELECT
	                    *
                    FROM
	                    certified_licenses
                    ORDER BY
	                    employee_id ASC,
                        license_id ASC;
                    
                    ";

                    SqlCommand command =
                   new SqlCommand(sql, connection);

                    using (SqlDataReader reader =
                    command.ExecuteReader())
                    {
                        string textInfo =
                            "社員ID｜資格ID｜取得日｜"
                            + Environment.NewLine;

                        while (reader.Read())
                        {
                            textInfo += string.Format(
                                "{0}｜{1}｜{2}",
                                reader.GetInt32(reader.GetOrdinal("employee_id")),
                                reader.GetInt32(reader.GetOrdinal("license_id")),
                                reader.GetDateTime(reader.GetOrdinal("certified_date"))
                                    .ToString("yyyy/MM/dd")
                            ) + Environment.NewLine;
                        }

                        textBoxList.Text = textInfo;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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
                        DELETE FROM
                            certified_licenses
                        WHERE
                            employee_id = @employee_id
                            AND license_id = @license_id;
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

                    int result =
                        command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("削除しました。");
                    }
                    else
                    {
                        MessageBox.Show("対象の社員IDが見つかりませんでした。");
                    }

                    Form_Load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

