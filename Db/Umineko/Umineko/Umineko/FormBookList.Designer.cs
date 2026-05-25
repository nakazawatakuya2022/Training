namespace Umineko
{
    partial class FormBookList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label3 = new Label();
            buttonShowDetail = new Button();
            label1 = new Label();
            numericUpDownBookId = new NumericUpDown();
            dataGridViewBookList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookList).BeginInit();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.Font = new Font("Yu Gothic UI", 11.25F);
            buttonSearch.Location = new Point(512, 31);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(77, 32);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "検索";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Location = new Point(12, 37);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(485, 23);
            textBoxSearch.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 11.25F);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(470, 20);
            label3.TabIndex = 2;
            label3.Text = "キーワードで検索（タイトル、著者、出版に含まれる文字列を入力してください）";
            // 
            // buttonShowDetail
            // 
            buttonShowDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonShowDetail.Font = new Font("Yu Gothic UI", 11.25F);
            buttonShowDetail.Location = new Point(165, 422);
            buttonShowDetail.Name = "buttonShowDetail";
            buttonShowDetail.Size = new Size(77, 32);
            buttonShowDetail.TabIndex = 0;
            buttonShowDetail.Text = "詳細表示";
            buttonShowDetail.UseVisualStyleBackColor = true;
            buttonShowDetail.Click += buttonShowDetail_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F);
            label1.Location = new Point(15, 428);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "蔵書ID";
            // 
            // numericUpDownBookId
            // 
            numericUpDownBookId.Location = new Point(75, 428);
            numericUpDownBookId.Name = "numericUpDownBookId";
            numericUpDownBookId.Size = new Size(84, 23);
            numericUpDownBookId.TabIndex = 5;
            // 
            // dataGridViewBookList
            // 
            dataGridViewBookList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookList.Location = new Point(15, 75);
            dataGridViewBookList.Name = "dataGridViewBookList";
            dataGridViewBookList.Size = new Size(574, 341);
            dataGridViewBookList.TabIndex = 6;
            // 
            // FormBookList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 465);
            Controls.Add(dataGridViewBookList);
            Controls.Add(numericUpDownBookId);
            Controls.Add(label1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(label3);
            Controls.Add(buttonShowDetail);
            Name = "FormBookList";
            Text = "蔵書一覧";
            Load += FormBookList_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label3;
        private Button buttonShowDetail;
        private Label label1;
        private NumericUpDown numericUpDownBookId;
        private DataGridView dataGridViewBookList;
    }
}