using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                                    SELECT
                            l.license_name,
                            e.employee_name
                        FROM
                            licenses AS l
                            JOIN certified_licenses AS cl
                                ON l.license_id = cl.license_id
                            JOIN employees AS e
                                ON cl.employee_id = e.employee_id
                        WHERE
                            l.license_id = @LicenseId;
                             ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                                "@LicenseId",
                                numericUpDownLicenseId.Value
                            );

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        string textInfo = "";

                        while (reader.Read())
                        {
                            textBoxName.Text =
                                reader["license_name"].ToString();

                            textInfo +=
                                reader["employee_name"].ToString()
                                + Environment.NewLine;
                        }

                        textBoxEmployees.Text = textInfo;
                    }
                    else
                    {
                        textBoxName.Text = "見つかりませんでした。";
                        textBoxEmployees.Text = "";
                    }
                }
            }

        }
    }
}
