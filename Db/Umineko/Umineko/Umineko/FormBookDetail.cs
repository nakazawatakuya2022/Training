using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms.VisualStyles;
using Umineko.Properties;

namespace Umineko
{
    public partial class FormBookDetail : Form
    {
        private int _bookId;

        public FormBookDetail(int bookId)
        {
            InitializeComponent();

            _bookId = bookId;
        }

        private void FormBookDetail_Load(object sender, EventArgs e)
        {
            LoadBookDetail();
        }
        private void LoadBookDetail()
        {
            try
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
                    book_id = @BookId;
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
                        if (reader.Read())
                        {
                            numericUpDownBookId.Value =
                                Convert.ToDecimal(
                                    reader["book_id"]
                                );

                            textBoxIsbn.Text =
                                reader["isbn"].ToString();

                            textBoxTitle.Text =
                                reader["title"].ToString();

                            textBoxAuthor.Text =
                                reader["author"].ToString();

                            textBoxPublisher.Text =
                                reader["publisher"].ToString();

                            dateTimePickerPurchaseDate.Value =
                                Convert.ToDateTime(
                                    reader["purchase_date"]
                                );

                            numericUpDownPurchasePrice.Value =
                                Convert.ToDecimal(
                                    reader["purchase_price"]
                                );

                            textBoxMemo.Text =
                                reader["memo"] == DBNull.Value
                                    ? ""
                                    : reader["memo"].ToString();

                            textBoxCategory.Text =
                                reader["category_id"].ToString();

                            bool lent_flag =
                            Convert.ToBoolean(
                                reader["lent_flag"]
                            );

                            textBoxState.Text =
                                lent_flag
                                    ? "貸出中"
                                    : "利用可";

                            buttonLent.Enabled =
                                !lent_flag;

                            buttonReturn.Enabled =
                                lent_flag;
                        }
                        else
                        {
                            MessageBox.Show(
                                "データが見つかりません。"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "エラー"
                );
            }
        }
        private void buttonLent_Click(object sender, EventArgs e)
        {
            FormLent form =
            new FormLent(_bookId);

            form.ShowDialog();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            FormLent form =
            new FormLent(_bookId);

            form.ShowDialog();
        }

        private void buttonLentHistory_Click(object sender, EventArgs e)
        {
            FormLentHistory form =
            new FormLentHistory(_bookId);

            form.ShowDialog();
        }
    }
}
