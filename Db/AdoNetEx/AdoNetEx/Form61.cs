using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form61 : Form
    {
        public Form61()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                string employeeCountSql = @"
                    SELECT COUNT(*) AS employee_count
                    FROM employees;
                ";

                string licenseCountSql = @"
                    SELECT COUNT(*) AS license_count
                    FROM licenses;
                ";

                string licenseEmployeeCountSql = @"
                    SELECT
                        l.license_id,
                        l.license_name,
                        COUNT(cl.employee_id) AS employee_count
                    FROM
                        licenses AS l
                        LEFT JOIN certified_licenses AS cl
                            ON l.license_id = cl.license_id
                    GROUP BY
                        l.license_id,
                        l.license_name
                    ORDER BY
                        l.license_id;
                ";

                SqlCommand employeeCommand =
                    new SqlCommand(employeeCountSql, connection);

                SqlCommand licenseCommand =
                    new SqlCommand(licenseCountSql, connection);

                SqlCommand licenseEmployeeCommand =
                    new SqlCommand(licenseEmployeeCountSql, connection);

                int employeeCount =
                    (int)employeeCommand.ExecuteScalar();

                int licenseCount =
                    (int)licenseCommand.ExecuteScalar();

                textBoxEmployeesCount.Text =
                    employeeCount.ToString();

                textBoxLicensesCount.Text =
                    licenseCount.ToString();

                string textInfo = "";

                using (SqlDataReader reader =
                    licenseEmployeeCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        textInfo += string.Format(
                            "{0}：{1}人",
                            reader.GetString("license_name"),
                            reader.GetInt32("employee_count")
                        ) + Environment.NewLine;
                    }
                }

                textBoxList.Text = textInfo;
            }
        }
    }
}