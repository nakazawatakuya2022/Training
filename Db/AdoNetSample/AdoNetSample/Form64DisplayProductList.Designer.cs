namespace AdoNetSample
{
    partial class Form64DisplayProductList
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
            buttonShowDetail = new Button();
            label3 = new Label();
            textBoxProductName = new TextBox();
            comboBoxCategory = new ComboBox();
            dataGridViewProductList = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colOrderCount = new DataGridViewTextBoxColumn();
            colSalesAmount = new DataGridViewTextBoxColumn();
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
            label2.Size = new Size(51, 16);
            label2.TabIndex = 0;
            label2.Text = "カテゴリ";
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.Location = new Point(476, 11);
            buttonSearch.Margin = new Padding(4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(120, 42);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "検索";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonShowDetail
            // 
            buttonShowDetail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonShowDetail.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonShowDetail.Location = new Point(21, 421);
            buttonShowDetail.Margin = new Padding(4);
            buttonShowDetail.Name = "buttonShowDetail";
            buttonShowDetail.Size = new Size(120, 42);
            buttonShowDetail.TabIndex = 7;
            buttonShowDetail.Text = "詳細表示";
            buttonShowDetail.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(241, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 16);
            label3.TabIndex = 0;
            label3.Text = "商品名";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductName.Location = new Point(313, 19);
            textBoxProductName.Margin = new Padding(4);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(116, 23);
            textBoxProductName.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(85, 18);
            comboBoxCategory.Margin = new Padding(4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(140, 24);
            comboBoxCategory.TabIndex = 8;
            // 
            // dataGridViewProductList
            // 
            dataGridViewProductList.AllowUserToAddRows = false;
            dataGridViewProductList.AllowUserToDeleteRows = false;
            dataGridViewProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductList.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colPrice, colOrderCount, colSalesAmount, colCategoryName, colMemo });
            dataGridViewProductList.Location = new Point(18, 119);
            dataGridViewProductList.Margin = new Padding(4);
            dataGridViewProductList.MultiSelect = false;
            dataGridViewProductList.Name = "dataGridViewProductList";
            dataGridViewProductList.ReadOnly = true;
            dataGridViewProductList.RowTemplate.Height = 21;
            dataGridViewProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductList.Size = new Size(790, 295);
            dataGridViewProductList.TabIndex = 10;
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
            // colOrderCount
            // 
            colOrderCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colOrderCount.DataPropertyName = "order_count";
            colOrderCount.HeaderText = "注文数";
            colOrderCount.Name = "colOrderCount";
            colOrderCount.ReadOnly = true;
            colOrderCount.Width = 68;
            // 
            // colSalesAmount
            // 
            colSalesAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSalesAmount.DataPropertyName = "sales_amount";
            colSalesAmount.HeaderText = "合計売上";
            colSalesAmount.Name = "colSalesAmount";
            colSalesAmount.ReadOnly = true;
            colSalesAmount.Width = 80;
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
            // Form64DisplayProductList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 484);
            Controls.Add(dataGridViewProductList);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxProductName);
            Controls.Add(buttonShowDetail);
            Controls.Add(label3);
            Controls.Add(buttonSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MinimumSize = new Size(841, 518);
            Name = "Form64DisplayProductList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "6-4. 複雑な一覧と詳細画面";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonShowDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalesAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemo;
    }
}