namespace AdoNetSample
{
    partial class Form64ShowProductInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownProductId = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.dataGridViewOrderList = new System.Windows.Forms.DataGridView();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCraeteOrder = new System.Windows.Forms.Button();
            this.buttonEditOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "商品名";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProductName.Location = new System.Drawing.Point(102, 49);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(392, 23);
            this.textBoxProductName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "価格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "メモ";
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMemo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMemo.Location = new System.Drawing.Point(102, 121);
            this.textBoxMemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMemo.Multiline = true;
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.ReadOnly = true;
            this.textBoxMemo.Size = new System.Drawing.Size(392, 88);
            this.textBoxMemo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "カテゴリ名";
            // 
            // numericUpDownProductId
            // 
            this.numericUpDownProductId.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownProductId.Location = new System.Drawing.Point(102, 12);
            this.numericUpDownProductId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownProductId.Name = "numericUpDownProductId";
            this.numericUpDownProductId.ReadOnly = true;
            this.numericUpDownProductId.Size = new System.Drawing.Size(140, 23);
            this.numericUpDownProductId.TabIndex = 1;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownPrice.Location = new System.Drawing.Point(102, 85);
            this.numericUpDownPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.ReadOnly = true;
            this.numericUpDownPrice.Size = new System.Drawing.Size(140, 23);
            this.numericUpDownPrice.TabIndex = 3;
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCategoryName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCategoryName.Location = new System.Drawing.Point(102, 232);
            this.textBoxCategoryName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.ReadOnly = true;
            this.textBoxCategoryName.Size = new System.Drawing.Size(392, 23);
            this.textBoxCategoryName.TabIndex = 5;
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(19, 289);
            this.buttonEditProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(119, 40);
            this.buttonEditProduct.TabIndex = 6;
            this.buttonEditProduct.Text = "商品編集";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrderList
            // 
            this.dataGridViewOrderList.AllowUserToAddRows = false;
            this.dataGridViewOrderList.AllowUserToDeleteRows = false;
            this.dataGridViewOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderId,
            this.colOrderDate,
            this.colCustomerNo,
            this.colCustomerName,
            this.colOrderQuantity});
            this.dataGridViewOrderList.Location = new System.Drawing.Point(14, 379);
            this.dataGridViewOrderList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewOrderList.MultiSelect = false;
            this.dataGridViewOrderList.Name = "dataGridViewOrderList";
            this.dataGridViewOrderList.ReadOnly = true;
            this.dataGridViewOrderList.RowTemplate.Height = 21;
            this.dataGridViewOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderList.Size = new System.Drawing.Size(817, 226);
            this.dataGridViewOrderList.TabIndex = 0;
            // 
            // colOrderId
            // 
            this.colOrderId.DataPropertyName = "order_id";
            this.colOrderId.HeaderText = "注文ID";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DataPropertyName = "order_date";
            this.colOrderDate.HeaderText = "注文日";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            // 
            // colCustomerNo
            // 
            this.colCustomerNo.DataPropertyName = "customer_no";
            this.colCustomerNo.HeaderText = "顧客No";
            this.colCustomerNo.Name = "colCustomerNo";
            this.colCustomerNo.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "customer_name";
            this.colCustomerName.HeaderText = "顧客名";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colOrderQuantity
            // 
            this.colOrderQuantity.DataPropertyName = "quantity";
            this.colOrderQuantity.HeaderText = "注文数";
            this.colOrderQuantity.Name = "colOrderQuantity";
            this.colOrderQuantity.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "注文情報";
            // 
            // buttonCraeteOrder
            // 
            this.buttonCraeteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCraeteOrder.Location = new System.Drawing.Point(19, 626);
            this.buttonCraeteOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCraeteOrder.Name = "buttonCraeteOrder";
            this.buttonCraeteOrder.Size = new System.Drawing.Size(119, 40);
            this.buttonCraeteOrder.TabIndex = 8;
            this.buttonCraeteOrder.Text = "新規注文";
            this.buttonCraeteOrder.UseVisualStyleBackColor = true;
            // 
            // buttonEditOrder
            // 
            this.buttonEditOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditOrder.Location = new System.Drawing.Point(145, 626);
            this.buttonEditOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditOrder.Name = "buttonEditOrder";
            this.buttonEditOrder.Size = new System.Drawing.Size(119, 40);
            this.buttonEditOrder.TabIndex = 9;
            this.buttonEditOrder.Text = "注文編集";
            this.buttonEditOrder.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteOrder.Location = new System.Drawing.Point(271, 626);
            this.buttonDeleteOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(119, 40);
            this.buttonDeleteOrder.TabIndex = 10;
            this.buttonDeleteOrder.Text = "注文削除";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // Form64ShowProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 694);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewOrderList);
            this.Controls.Add(this.buttonDeleteOrder);
            this.Controls.Add(this.buttonEditOrder);
            this.Controls.Add(this.buttonCraeteOrder);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownProductId);
            this.Controls.Add(this.textBoxMemo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(865, 733);
            this.Name = "Form64ShowProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "商品詳細";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownProductId;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.DataGridView dataGridViewOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCraeteOrder;
        private System.Windows.Forms.Button buttonEditOrder;
        private System.Windows.Forms.Button buttonDeleteOrder;
    }
}