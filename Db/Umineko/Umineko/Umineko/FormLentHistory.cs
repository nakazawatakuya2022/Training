using Microsoft.Data.SqlClient;
using System.Data;
using Umineko.Properties;

namespace Umineko
{
    public partial class FormLentHistory : Form
    {
        private int _bookId;
        public FormLentHistory(int bookId)
        {
            InitializeComponent();

            _bookId = bookId;
        }

        private void FormLentHistory_Load(object sender, EventArgs e)
        {
            numericUpDownBookId.Value =
                _bookId;

            LoadLentHistory();
        }
        private void LoadLentHistory()
        {
            string connectionStr =
                Settings.Default.DbConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionStr))
            {
                connection.Open();

                string sql = @"
                 SELECT
                    lh.lent_date,
                    lh.member_code,
                    m.member_name,
                    lh.has_returned
                FROM
                    lent_histories AS lh
                    JOIN members AS m
                        ON lh.member_code = m.member_code
                WHERE
                    lh.book_id = @BookId
                    AND lh.has_returned = 0
                ORDER BY
                    lh.lent_date DESC;
                 ";

                SqlCommand command =
                        new SqlCommand(sql, connection);

                command.Parameters.AddWithValue(
                    "@BookId",
                    _bookId
                );
                using (SqlDataReader reader =
                    command.ExecuteReader())
                {
                    textBoxHistory.Clear();

                    while (reader.Read())
                    {
                        DateTime lentDate =
                            Convert.ToDateTime(reader["lent_date"]);

                        string? memberNo =
                            reader["member_code"].ToString();

                        string? memberName =
                            reader["member_name"].ToString();

                        bool returnedFlag =
                            Convert.ToBoolean(reader["has_returned"]);

                        string flag =
                            returnedFlag
                                ? "返却済み"
                                : "貸出中";

                        string row =
                            lentDate.ToString("yyyy/MM/dd")
                            + " "
                            + memberNo
                            + " "
                            + memberName
                            + " "
                            + flag;

                        textBoxHistory.AppendText(
                            row + Environment.NewLine
                        );
                    }
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
