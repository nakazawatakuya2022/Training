using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;


namespace AdoNetEx
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                // 書き換える箇所
                string sql = @"
                        SELECT
                            employee_name,
                            hire_date
                       
                        FROM
                            employees
                        WHERE
                            employee_id = @Employee_Id;
                    ";

                SqlCommand command = new SqlCommand(sql, connection);

                // 追加する箇所
                command.Parameters.AddWithValue("@Employee_Id", numericUpDownEmployeeId.Value);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DateTime hireDate = reader.GetDateTime("hire_date");

                        textBoxName.Text = reader["employee_name"].ToString();
                        textBoxHireDate.Text = hireDate.ToString("yyyy/MM/dd");
                    }
                    else
                    {
                        textBoxName.Text = "見つかりませんでした。";
                    }
                }
            }
        }
    }
}
