using AdoNetEx.Properties;
using Microsoft.Data.SqlClient;

namespace AdoNetEx
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        // 「接続」ボタンがクリックされたときに実行されるメソッド
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // App.config に保存されている接続文字列を取得
            // 「どのDBに接続するか」の情報
            string connectionStr = Settings.Default.DbConnectionString;

            // SqlConnectionオブジェクトを作成
            // using を使うことで処理終了時に自動で接続を閉じてくれる
            using (SqlConnection connection = new(connectionStr))
            {
                // データベースへ接続する
                connection.Open();

                // 接続成功メッセージを表示
                MessageBox.Show("データベースに接続しました\nOKを押すと切断します");

                // using を抜けると自動で connection.Dispose() が呼ばれ、
                // DB接続も自動で閉じられる
            }
        }
    }
}
