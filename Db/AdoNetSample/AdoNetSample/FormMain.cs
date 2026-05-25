namespace AdoNetSample
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // アプリケーションを終了する
            Application.Exit();
        }

        private void button11Connect_Click(object sender, EventArgs e)
        {
            Form11Connect form = new Form11Connect();
            form.ShowDialog();
        }

        private void button21GetRecord_Click(object sender, EventArgs e)
        {
            Form21GetRecord form = new Form21GetRecord();
            form.ShowDialog();
        }

        private void button22GetRecords_Click(object sender, EventArgs e)
        {
            Form22GetRecords form = new Form22GetRecords();
            form.ShowDialog();
        }

        private void button31InsertRecord_Click(object sender, EventArgs e)
        {
            Form31InsertRecord form = new Form31InsertRecord();
            form.ShowDialog();
        }

        private void button32UpdateRecord_Click(object sender, EventArgs e)
        {
            Form32UpdateRecord form = new Form32UpdateRecord();
            form.ShowDialog();
        }

        private void button33DeleteRecord_Click(object sender, EventArgs e)
        {
            Form33DeleteRecord form = new Form33DeleteRecord();
            form.ShowDialog();
        }

        private void button41CountRecord_Click(object sender, EventArgs e)
        {
            Form41CountRecord form = new Form41CountRecord();
            form.ShowDialog();
        }

        private void button51DataGridView_Click(object sender, EventArgs e)
        {
            Form51DataGridView form = new Form51DataGridView();
            form.ShowDialog();
        }

        private void button52Search_Click(object sender, EventArgs e)
        {
            Form52Search form = new Form52Search();
            form.ShowDialog();
        }

        private void button61DisplayList_Click(object sender, EventArgs e)
        {
            Form61DisplayProductList form = new Form61DisplayProductList();
            form.ShowDialog();
        }

        private void button62UpdateList_Click(object sender, EventArgs e)
        {
            Form62DisplayProductList form = new Form62DisplayProductList();
            form.ShowDialog();
        }

        private void button63OtherControls_Click(object sender, EventArgs e)
        {
            Form63DisplayProductList form = new Form63DisplayProductList();
            form.ShowDialog();
        }

        private void button64ComplicatedList_Click(object sender, EventArgs e)
        {
            Form64DisplayProductList form = new Form64DisplayProductList();
            form.ShowDialog();
        }
    }
}