using AdoNetSample.Properties;
using Microsoft.Data.SqlClient;
using System.Data;


namespace AdoNetSample
{
    public partial class Form63DisplayProductList : Form
    {
        public Form63DisplayProductList()
        {
            InitializeComponent();
        }

        private void Form63DisplayProductList_Load(object sender, EventArgs e)
        {
            LoadCategoryDataFromDb();
        }

        // ComboBoxでアイテムが選択されていない状態
        private const int ITEM_NOT_SELECTED = -1;

        private void LoadProductDataFromDb()
        {
            string connectionStr = Settings.Default.DbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // データベースへ接続
                connection.Open();

                // 実行するSQL文
                string sql = @"
                    SELECT product_id, product_name, price, p.category_id, category_name, memo
                    FROM products AS p
                    JOIN categories AS c
                    ON p.category_id = c.category_id
                    WHERE 1 = 1
                    ";
                // カテゴリIDの指定がある場合（数値に変換できる文字列が入力されている場合）
                if (comboBoxCategory.SelectedValue != null &&
                    (int)comboBoxCategory.SelectedValue != ITEM_NOT_SELECTED)
                {
                    sql += " AND p.category_id = @CategoryId";
                }

                // 商品名の指定がある場合
                if (textBoxProductName.Text != "")
                {
                    sql += " AND product_name LIKE @ProductName";
                }
                sql += ";";

                // データアダプタの生成
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                // SELECT文のパラメータへ置き換える値を指定
                dataAdapter.SelectCommand.Parameters.AddWithValue("@CategoryId", comboBoxCategory.SelectedValue);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@ProductName", "%" + textBoxProductName.Text + "%");
                // データテーブルの生成
                DataTable dataTable = new DataTable();
                // データベースからデータのコピーを取得
                dataAdapter.Fill(dataTable);
                // DataGridViewのデータソースへ設定
                dataGridViewProductList.DataSource = dataTable;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadProductDataFromDb();
        }

        private void buttonShowDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductList.CurrentRow == null)
            {
                return;
            }
            int indexRow = dataGridViewProductList.CurrentRow.Index;
            int productId = (int)dataGridViewProductList[0, indexRow].Value;
            // 現在選択中の行の商品IDをサブフォームのコンストラクタに渡す
            Form63EditProductInfo form = new Form63EditProductInfo(productId);
            // OKがクリックされた時はデータが更新されているのでデータベースから取得し直す
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProductDataFromDb();
            }
        }

        private void LoadCategoryDataFromDb()
        {
            string connectionStr = Settings.Default.DbConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // データベースへ接続
                connection.Open();
                // 実行するSQL文
                string sql = "SELECT * FROM categories ORDER BY category_id";
                // データアダプタの生成
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                // データテーブルの生成
                DataTable dataTable = new DataTable();
                // データベースからデータのコピーを取得
                dataAdapter.Fill(dataTable);
                // ComboBoxで何も選択していないという状態を作るために空のRowを先頭に挿入
                DataRow emptyDataRow = dataTable.NewRow();
                emptyDataRow["category_name"] = "";
                emptyDataRow["category_id"] = ITEM_NOT_SELECTED;
                dataTable.Rows.InsertAt(emptyDataRow, 0);
                // ComboBoxのデータソースにデータテーブルをセット
                comboBoxCategory.DisplayMember = "category_name";
                comboBoxCategory.ValueMember = "category_id";
                comboBoxCategory.DataSource = dataTable;
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}