using Microsoft.Data.SqlClient;
using System.Data;
using Umineko.Properties;

namespace Umineko
{
    public partial class FormBookList : Form
    {
        public FormBookList()
        {
            InitializeComponent();
        }

        private void FormBookList_Load(object sender, EventArgs e)
        {
            LoadBookList();
        }

        private void LoadBookList()
        {
            string connectionStr = Settings.Default.DbConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                    SELECT
                        *
                    FROM
                        books;
                ";

                SqlCommand command =
                    new SqlCommand(sql, connection);

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    DataTable table = new DataTable();

                    table.Load(reader);

                    dataGridViewBookList.DataSource = table;
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            UpdateBookList();
        }

        private void UpdateBookList()
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
                        books
                    WHERE
                        title LIKE @Keyword
                        OR author LIKE @Keyword
                        OR publisher LIKE @Keyword
                    ORDER BY
                        book_id;
                ";
                SqlCommand command =
                    new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@Keyword",
                    "%" + textBoxSearch.Text + "%"
                );

                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    DataTable table = new DataTable();

                    table.Load(reader);

                    dataGridViewBookList.DataSource = table;
                }
            }
        }

        private void buttonShowDetail_Click(object sender, EventArgs e)
        {
            int bookId =
        (int)numericUpDownBookId.Value;

            FormBookDetail form =
                new FormBookDetail(bookId);

            form.ShowDialog();
        }
    }
}

