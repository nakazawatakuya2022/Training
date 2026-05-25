using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form53 : Form
    {
        public Form53()
        {
            InitializeComponent();
        }

        private void Form53_Load(object sender, EventArgs e)
        {
            UpdateLicenseList();
        }

        private void UpdateLicenseList()
        {
            string connectionStr =
                Settings.Default.DbConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        *
                    FROM
                        employees
                    ORDER BY
                        employee_id;
                ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    string textInfo =
                        "社員ID｜社員名｜入社日｜上司の社員ID｜部署ID"
                        + Environment.NewLine;

                    while (reader.Read())
                    {
                        string managerId =
                            reader.IsDBNull(
                                reader.GetOrdinal("manager_id")
                            )
                            ? ""
                            : reader.GetInt32("manager_id")
                                .ToString();

                        textInfo += string.Format(
                            "{0}｜{1}｜{2}｜{3}｜{4}",
                            reader.GetInt32("employee_id"),
                            reader.GetString("employee_name"),
                            reader.GetDateTime("hire_date")
                                .ToString("yyyy/MM/dd"),
                            managerId,
                            reader.GetInt32("department_id")
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
                        employees
                    WHERE
                        employee_id = @Employee;
                ";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@Employee",
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