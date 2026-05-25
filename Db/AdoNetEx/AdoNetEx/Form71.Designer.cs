namespace AdoNetEx
{
    partial class Form71
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
            label1 = new Label();
            label2 = new Label();
            dataGridViewLicense = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            buttonShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLicense).BeginInit();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(204, 53);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(83, 34);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "検索";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(32, 60);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(155, 23);
            textBoxSearch.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 42);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 1;
            label1.Text = "資格名に含まれる文字列";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 9);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "資格一覧";
            // 
            // dataGridViewLicense
            // 
            dataGridViewLicense.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLicense.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewLicense.Location = new Point(12, 103);
            dataGridViewLicense.MultiSelect = false;
            dataGridViewLicense.Name = "dataGridViewLicense";
            dataGridViewLicense.RowTemplate.Height = 25;
            dataGridViewLicense.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLicense.Size = new Size(789, 256);
            dataGridViewLicense.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.DataPropertyName = "license_id";
            Column1.HeaderText = "資格ID";
            Column1.Name = "Column1";
            Column1.Width = 67;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "license_name";
            Column2.HeaderText = "資格名";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.DataPropertyName = "authority";
            Column3.HeaderText = "認定団体";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.DataPropertyName = "reward";
            Column4.HeaderText = "資格手当";
            Column4.Name = "Column4";
            Column4.Width = 80;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(12, 365);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(83, 34);
            buttonShow.TabIndex = 2;
            buttonShow.Text = "詳細表示";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonDetail_Click;
            // 
            // Form71
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 410);
            Controls.Add(dataGridViewLicense);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonShow);
            Controls.Add(buttonSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimumSize = new Size(530, 434);
            Name = "Form71";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "7-1";
            Load += Form71_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLicense).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewLicense;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button buttonShow;
    }
}