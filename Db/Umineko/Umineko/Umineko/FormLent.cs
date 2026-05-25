using Microsoft.Data.SqlClient;
using System.Data;
using Umineko.Properties;


namespace Umineko
{
    public partial class FormLent : Form
    {
        private int _bookId;
        public FormLent(int bookId)
        {
            InitializeComponent();
            _bookId = bookId;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            LentBook();
        }
        public void LentBook()
        {
            string connectionStr =
                    Settings.Default.DbConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionStr))
            {
                connection.Open();

                string insertSql = @"
                    INSERT INTO lent_histories
                    (
                        member_code,
                        book_id,
                        lent_date,
                        return_date,
                        memo,
                        has_returned
                    )
                    VALUES
                    (
                        @MemberCode,
                        @BookId,
                        @LentDate,
                        @ReturnDate,
                        @Memo,
                        0
                    );
                ";

                SqlCommand insertCommand =
                    new SqlCommand(insertSql, connection);



                using (SqlDataReader reader =
                        insertCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        numericUpDownBookId.Value =
                            Convert.ToDecimal(
                                reader["book_id"]
                            );
                    }
                }
            }
        }
    }
}



