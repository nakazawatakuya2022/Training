using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;


namespace AdoNetEx
{
    public partial class Form23 : Form
    {
        public Form23()
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
                                e.employee_name,
                                l.license_name
                            FROM
                                employees AS e
                                JOIN certified_licenses AS cl
                                    ON e.employee_id = cl.employee_id
                                JOIN licenses AS l
                                    ON cl.license_id = l.license_id
                            WHERE
                                e.employee_id = @EmployeeId;
                        ";

                            SqlCommand command =
                new SqlCommand(sql, connection);

                            command.Parameters.AddWithValue(
                                "@EmployeeId",
                                numericUpDownEmployeeId.Value
                            );

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        string textInfo = "";

                        while (reader.Read())
                        {
                            textBoxName.Text =
                                reader["employee_name"].ToString();

                            textInfo +=
                                reader["license_name"].ToString()
                                + Environment.NewLine;
                        }

                        textBoxLienses.Text = textInfo;
                    }
                    else
                    {
                        textBoxName.Text =
                            "見つかりませんでした。";

                        textBoxLienses.Text = "";
                    }
                }
            }

        }
    }
}
