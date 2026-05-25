namespace AdoNetSample
{
    partial class Form52Search
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
            label1 = new Label();
            label2 = new Label();
            buttonSearch = new Button();
            textBoxCategoryId = new TextBox();
            dataGridViewProductList = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCategoryId = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colMemo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 16);
            label1.TabIndex = 0;
            label1.Text = "商品の一覧";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 0;
            label2.Text = "カテゴリID";
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Location = new Point(265, 15);
            buttonSearch.Margin = new Padding(4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(120, 42);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "検索";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxCategoryId
            // 
            textBoxCategoryId.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCategoryId.Location = new Point(102, 19);
            textBoxCategoryId.Margin = new Padding(4);
            textBoxCategoryId.Name = "textBoxCategoryId";
            textBoxCategoryId.Size = new Size(116, 23);
            textBoxCategoryId.TabIndex = 3;
            // 
            // dataGridViewProductList
            // 
            dataGridViewProductList.AllowUserToAddRows = false;
            dataGridViewProductList.AllowUserToDeleteRows = false;
            dataGridViewProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductList.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colPrice, colCategoryId, colCategoryName, colMemo });
            dataGridViewProductList.Location = new Point(10, 95);
            dataGridViewProductList.Margin = new Padding(4);
            dataGridViewProductList.MultiSelect = false;
            dataGridViewProductList.Name = "dataGridViewProductList";
            dataGridViewProductList.ReadOnly = true;
            dataGridViewProductList.RowTemplate.Height = 21;
            dataGridViewProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductList.Size = new Size(677, 307);
            dataGridViewProductList.TabIndex = 9;
            // 
            // colProductId
            // 
            colProductId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colProductId.DataPropertyName = "product_id";
            colProductId.HeaderText = "商品ID";
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            colProductId.Width = 67;
            // 
            // colProductName
            // 
            colProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colProductName.DataPropertyName = "product_name";
            colProductName.HeaderText = "商品名";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 68;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "price";
            colPrice.HeaderText = "価格";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 54;
            // 
            // colCategoryId
            // 
            colCategoryId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCategoryId.DataPropertyName = "category_id";
            colCategoryId.HeaderText = "カテゴリID";
            colCategoryId.Name = "colCategoryId";
            colCategoryId.ReadOnly = true;
            colCategoryId.Width = 78;
            // 
            // colCategoryName
            // 
            colCategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCategoryName.DataPropertyName = "category_name";
            colCategoryName.HeaderText = "カテゴリ名";
            colCategoryName.Name = "colCategoryName";
            colCategoryName.ReadOnly = true;
            colCategoryName.Width = 79;
            // 
            // colMemo
            // 
            colMemo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMemo.DataPropertyName = "memo";
            colMemo.HeaderText = "メモ";
            colMemo.Name = "colMemo";
            colMemo.ReadOnly = true;
            // 
            // Form52Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 415);
            Controls.Add(dataGridViewProductList);
            Controls.Add(textBoxCategoryId);
            Controls.Add(buttonSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MinimumSize = new Size(716, 454);
            Name = "Form52Search";
            StartPosition = FormStartPosition.CenterParent;
            Text = "5-2. 商品データの検索";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCategoryId;
        private DataGridView dataGridViewProductList;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCategoryId;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colMemo;
    }
}