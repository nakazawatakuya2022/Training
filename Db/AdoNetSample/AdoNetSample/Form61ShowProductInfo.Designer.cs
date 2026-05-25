namespace AdoNetSample
{
    partial class Form61ShowProductInfo
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
            textBoxProductName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxMemo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxCategoryName = new TextBox();
            buttonOK = new Button();
            numericUpDownProductId = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownCategoryId = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCategoryId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 16);
            label1.TabIndex = 0;
            label1.Text = "商品ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 0;
            label2.Text = "商品名";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProductName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductName.Location = new Point(102, 49);
            textBoxProductName.Margin = new Padding(4);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.ReadOnly = true;
            textBoxProductName.Size = new Size(306, 23);
            textBoxProductName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 0;
            label3.Text = "価格";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 125);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 16);
            label4.TabIndex = 0;
            label4.Text = "メモ";
            // 
            // textBoxMemo
            // 
            textBoxMemo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMemo.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMemo.Location = new Point(102, 121);
            textBoxMemo.Margin = new Padding(4);
            textBoxMemo.Multiline = true;
            textBoxMemo.Name = "textBoxMemo";
            textBoxMemo.ReadOnly = true;
            textBoxMemo.Size = new Size(306, 159);
            textBoxMemo.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 300);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 0;
            label5.Text = "カテゴリID";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 336);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 16);
            label6.TabIndex = 0;
            label6.Text = "カテゴリ名";
            // 
            // textBoxCategoryName
            // 
            textBoxCategoryName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCategoryName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCategoryName.Location = new Point(100, 332);
            textBoxCategoryName.Margin = new Padding(4);
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.ReadOnly = true;
            textBoxCategoryName.Size = new Size(306, 23);
            textBoxCategoryName.TabIndex = 6;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOK.Location = new Point(166, 411);
            buttonOK.Margin = new Padding(4);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(88, 45);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // numericUpDownProductId
            // 
            numericUpDownProductId.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownProductId.Location = new Point(100, 12);
            numericUpDownProductId.Margin = new Padding(4);
            numericUpDownProductId.Name = "numericUpDownProductId";
            numericUpDownProductId.ReadOnly = true;
            numericUpDownProductId.Size = new Size(140, 23);
            numericUpDownProductId.TabIndex = 1;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownPrice.Location = new Point(102, 86);
            numericUpDownPrice.Margin = new Padding(4);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.ReadOnly = true;
            numericUpDownPrice.Size = new Size(140, 23);
            numericUpDownPrice.TabIndex = 3;
            // 
            // numericUpDownCategoryId
            // 
            numericUpDownCategoryId.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownCategoryId.Location = new Point(102, 296);
            numericUpDownCategoryId.Margin = new Padding(4);
            numericUpDownCategoryId.Name = "numericUpDownCategoryId";
            numericUpDownCategoryId.ReadOnly = true;
            numericUpDownCategoryId.Size = new Size(140, 23);
            numericUpDownCategoryId.TabIndex = 5;
            // 
            // Form61ShowProductInfo
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 471);
            Controls.Add(numericUpDownCategoryId);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownProductId);
            Controls.Add(buttonOK);
            Controls.Add(textBoxMemo);
            Controls.Add(label4);
            Controls.Add(textBoxCategoryName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBoxProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MinimumSize = new Size(438, 510);
            Name = "Form61ShowProductInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "商品詳細";
            Load += Form61ShowProductInfo_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCategoryId).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown numericUpDownProductId;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownCategoryId;
    }
}