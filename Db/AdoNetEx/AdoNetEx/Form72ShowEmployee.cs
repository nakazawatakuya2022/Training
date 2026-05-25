using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form72ShowEmployee : Form
    {
        private int _employeeId;

        public Form72ShowEmployee(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
        }

        private void Form72ShowEmployee_Load(
            object sender,
            EventArgs e
        )
        {
            LoadEmployeeDetail();
        }

        private void LoadEmployeeDetail()
        {
            string connectionStr =
                Settings.Default.DbConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        e.employee_id,
                        e.employee_name,
                        e.hire_date,
                        e.manager_id,
                        m.employee_name AS manager_name,
                        e.department_id,
                        d.department_name
                    FROM
                        employees AS e
                        LEFT JOIN employees AS m
                            ON e.manager_id = m.employee_id
                        LEFT JOIN departments AS d
                            ON e.department_id = d.department_id
                    WHERE
                        e.employee_id = @EmployeeId;
                ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@EmployeeId",
                    _employeeId
                );

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //textBoxEmployeeId.Text =
                        //    reader.GetInt32("employee_id")
                        //        .ToString();

                        //textBoxEmployeeName.Text =
                        //    reader.GetString("employee_name");

                        //textBoxHireDate.Text =
                        //    reader.GetDateTime("hire_date")
                        //        .ToString("yyyy/MM/dd");

                        //textBoxManagerId.Text =
                        //    reader.IsDBNull(
                        //        reader.GetOrdinal("manager_id")
                        //    )
                        //    ? ""
                        //    : reader.GetInt32("manager_id")
                        //        .ToString();

                        //textBoxManagerName.Text =
                        //    reader.IsDBNull(
                        //        reader.GetOrdinal("manager_name")
                        //    )
                        //    ? ""
                        //    : reader.GetString("manager_name");

                        //textBoxDepartmentId.Text =
                        //    reader.GetInt32("department_id")
                        //        .ToString();

                        //textBoxDepartmentName.Text =
                        //    reader.GetString("department_name");
                    }
                }
            }
        }
    }
}