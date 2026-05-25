using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form51 : Form
    {
        public Form51()
        {
            InitializeComponent();
        }
        private void Form31InsertRecord_Load(object sender, EventArgs e)
        {
            UpdateDepartmentList();
        }

        private void UpdateDepartmentList()
        {
            string connectionStr = Settings.Default.DbConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        department_id,
                        department_name
                    FROM
                        departments;
                ";

                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string textInfo = "部署ID｜部署名"
                    + Environment.NewLine;

                    while (reader.Read())
                    {
                        textInfo += string.Format(
                            "{0}:{1}",
                            reader.GetInt32("department_id"),
                            reader.GetString("department_name")
                        ) + Environment.NewLine;
                    }

                    textBoxList.Text = textInfo;
                }
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string connectionStr = Settings.Default.DbConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                        DELETE FROM
                            departments
                        WHERE
                            department_id = @DepartmentId;
                    ";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@DepartmentId",
                    numericUpDownDepartmentId.Value
                );

                int result = command.ExecuteNonQuery();

                MessageBox.Show(result + "件のデータを削除しました。");

                UpdateDepartmentList();
            }
        }

    }
}
