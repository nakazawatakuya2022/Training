using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;


namespace AdoNetEx
{
    public partial class Form72 : Form
    {
        public Form72()
        {
            InitializeComponent();
        }
        private void Form72_Load(object sender, EventArgs e)
        {
            LoadDepartmentComboBox();
            UpdateEmployeeList();
        }

        private void LoadDepartmentComboBox()
        {
            string connectionStr =
                Settings.Default.DbConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        department_id,
                        department_name
                    FROM
                        departments
                    ORDER BY
                        department_id;
                ";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                DataRow emptyRow =
                    table.NewRow();

                emptyRow["department_id"] = DBNull.Value;
                emptyRow["department_name"] = "";

                table.Rows.InsertAt(emptyRow, 0);

                comboBoxDepartments.DataSource = table;
                comboBoxDepartments.DisplayMember = "department_name";
                comboBoxDepartments.ValueMember = "department_id";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
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
                e.employee_id,
                e.employee_name,
                e.hire_date,
                e.manager_id,
                e.department_id,
                d.department_name
            FROM
                employees AS e
                LEFT JOIN departments AS d
                    ON e.department_id = d.department_id
            WHERE
                1 = 1
        ";

                if (comboBoxDepartments.SelectedValue != DBNull.Value)
                {
                    sql += @"
                AND e.department_id = @DepartmentId
            ";
                }

                if (textBoxSearch.Text != "")
                {
                    sql += @"
                AND e.employee_name LIKE @EmployeeName
            ";
                }

                sql += @"
            ORDER BY
                e.employee_id;
        ";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection);

                if (comboBoxDepartments.SelectedValue != DBNull.Value)
                {
                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@DepartmentId",
                        comboBoxDepartments.SelectedValue
                    );
                }

                if (textBoxSearch.Text != "")
                {
                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@EmployeeName",
                        "%" + textBoxSearch.Text + "%"
                    );
                }

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                dataGridViewEmployee.DataSource =
                    table;
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.CurrentRow == null)
            {
                MessageBox.Show("社員を選択してください。");
                return;
            }

            int indexRow =
                dataGridViewEmployee.CurrentRow.Index;

            int employeeId =
                (int)dataGridViewEmployee["employee_id", indexRow].Value;

    //        Form72Detail detailForm =
    //new Form72Detail(employeeId);

    //        detailForm.ShowDialog();
        }
    }
}