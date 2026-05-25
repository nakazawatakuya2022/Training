using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNetEx
{
    public partial class Form71 : Form
    {
        public Form71()
        {
            InitializeComponent();
        }

        private void Form71_Load(object sender, EventArgs e)
        {
            UpdateLicenseList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            UpdateLicenseList();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewLicense.CurrentRow == null)
            {
                MessageBox.Show("資格を選択してください。");
                return;
            }

            int indexRow =
                dataGridViewLicense.CurrentRow.Index;

            string licenseName =
                (string)dataGridViewLicense[1, indexRow].Value;

            string authority =
                (string)dataGridViewLicense[2, indexRow].Value;

            MessageBox.Show(
                "資格名：" + licenseName
                + Environment.NewLine
                + "認定団体：" + authority
            );
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
                        licenses
                ";

                if (textBoxSearch.Text != "")
                {
                    sql += @"
                        WHERE
                            license_name LIKE @LicenseName
                    ";
                }

                //sql += @"
                //    ORDER BY
                //        license_id;
                //";

                SqlDataAdapter dataAdapter =
                    new SqlDataAdapter(sql, connection);

                if (textBoxSearch.Text != "")
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue(
                        "@LicenseName",
                        "%" + textBoxSearch.Text + "%"
                    );
                }

                DataTable dataTable =
                    new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridViewLicense.DataSource =
                    dataTable;
            }
        }
    }
}