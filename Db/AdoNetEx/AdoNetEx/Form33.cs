using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void Form33_Load(object sender, EventArgs e)
        {
            UpdateEmployeeList();
        }

        private void UpdateEmployeeList()
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
                        employee_name,
                        hire_date,
                        manager_id,
                        department_id
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
                        "社員ID｜社員名｜入社日｜上司ID｜部署ID"
                        + Environment.NewLine;

                    while (reader.Read())
                    {
                        string? managerText =
                            reader.IsDBNull("manager_id")
                            ? "上司なし"
                            : reader["manager_id"].ToString();

                        textInfo += string.Format(
                            "{0}｜{1}｜{2}｜{3}｜{4}",
                            reader.GetInt32("employee_id"),
                            reader.GetString("employee_name"),
                            reader.GetDateTime("hire_date")
                                .ToString("yyyy/MM/dd"),
                            managerText,
                            reader.GetInt32("department_id")
                        ) + Environment.NewLine;
                    }

                    textBoxList.Text = textInfo;
                }
            }
        }

        private void buttonInsert_Click(
            object sender,
            EventArgs e)
        {
            string connectionStr =
                Settings.Default.DbConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                    INSERT INTO employees (
                        employee_name,
                        hire_date,
                        manager_id,
                        department_id
                    )
                    VALUES (
                        @EmployeeName,
                        @HireDate,
                        @ManagerId,
                        @DepartmentId
                    );
                ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@EmployeeName",
                    textBoxName.Text
                );

                command.Parameters.AddWithValue(
                    "@HireDate",
                    dateTimePickerHireDate.Value
                );

                int managerId =
                    (int)numericUpDownManagerId.Value;

                command.Parameters.AddWithValue(
                    "@ManagerId",
                    managerId != 0
                        ? managerId
                        : DBNull.Value
                );

                command.Parameters.AddWithValue(
                    "@DepartmentId",
                    numericUpDownDepartmentId.Value
                );

                int result = command.ExecuteNonQuery();

                MessageBox.Show(
                    result + "件のデータを登録しました。"
                );

                UpdateEmployeeList();
            }
        }
    }
}