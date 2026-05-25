using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form43 : Form
    {
        public Form43()
        {
            InitializeComponent();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
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
                        UPDATE
                            employees
                        SET
                            employee_name = @employee_name,
                            hire_date = @hire_date,
                            manager_id = @manager_id,
                            department_id = @department_id
                        WHERE
                            employee_id = @employee_id;
                    ";

                    SqlCommand command =
                        new SqlCommand(sql, connection);

                    int managerId =
                        (int)numericUpDownManagerId.Value;

                    command.Parameters.AddWithValue(
                        "@employee_id",
                        (int)numericUpDownId.Value
                    );

                    command.Parameters.AddWithValue(
                        "@employee_name",
                        textBoxName.Text
                    );

                    command.Parameters.AddWithValue(
                        "@hire_date",
                        dateTimePickerHireDate.Value.Date
                    );

                    command.Parameters.AddWithValue(
                        "@manager_id",
                        managerId == 0 ? DBNull.Value : managerId
                    );

                    command.Parameters.AddWithValue(
                        "@department_id",
                        (int)numericUpDownDepartmentId.Value
                    );

                    int count =
                        command.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show("更新しました。");
                    }
                    else
                    {
                        MessageBox.Show("対象の社員IDが見つかりませんでした。");
                    }

                    UpdateEmployeeList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
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
                            reader.IsDBNull(reader.GetOrdinal("manager_id"))
                            ? "上司なし"
                            : reader["manager_id"].ToString();

                        textInfo += string.Format(
                            "{0}｜{1}｜{2}｜{3}｜{4}",
                            reader.GetInt32(reader.GetOrdinal("employee_id")),
                            reader.GetString(reader.GetOrdinal("employee_name")),
                            reader.GetDateTime(reader.GetOrdinal("hire_date"))
                                .ToString("yyyy/MM/dd"),
                            managerText,
                            reader.GetInt32(reader.GetOrdinal("department_id"))
                        ) + Environment.NewLine;
                    }

                    textBoxList.Text = textInfo;
                }
            }
        }
        private void Form35_Load(object sender, EventArgs e)
        {
            UpdateEmployeeList();
        }
    }
}
