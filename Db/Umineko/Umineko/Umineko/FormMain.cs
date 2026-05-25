using Microsoft.Data.SqlClient;
using System.Data;
using Umineko.Properties;

namespace Umineko
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            FormBookList form = new FormBookList();

            form.ShowDialog();
        }
        private void toolStripMenuItemVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "バージョン：1.0.0.0\n作成者：ウチダカレッジ"
           );
        }
    }
}
