using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form21 : Form
    {
        public Form21()
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
                d.department_name,
                e.employee_name
            FROM
                employees AS e
                JOIN departments AS d
                    ON e.department_id = d.department_id
            WHERE
                d.department_id = @DepartmentId;
        ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@DepartmentId",
                    numericUpDownDepartmentId.Value
                );

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        string textInfo = "";


                        while (reader.Read())
                        {
                            textBoxName.Text =
                                reader["department_name"].ToString();

                            textInfo +=
                                reader["employee_name"].ToString()
                                + Environment.NewLine;
                        }

                        textBoxEmployees.Text = textInfo;
                    }
                    else
                    {
                        textBoxEmployees.Text =
                            "該当する社員は存在しません。";
                    }
                }
            }
        }
    }
}