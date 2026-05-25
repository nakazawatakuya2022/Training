namespace AdoNetSample
{
    partial class Form62EditProductInfo
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
            buttonUpdate = new Button();
            buttonCancel = new Button();
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
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonUpdate.DialogResult = DialogResult.OK;
            buttonUpdate.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(164, 411);
            buttonUpdate.Margin = new Padding(4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(110, 45);
            buttonUpdate.TabIndex = 0;
            buttonUpdate.Text = "更新";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(301, 411);
            buttonCancel.Margin = new Padding(4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(106, 45);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownProductId
            // 
            numericUpDownProductId.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownProductId.Location = new Point(102, 12);
            numericUpDownProductId.Margin = new Padding(4);
            numericUpDownProductId.Name = "numericUpDownProductId";
            numericUpDownProductId.Size = new Size(140, 23);
            numericUpDownProductId.TabIndex = 5;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownPrice.Location = new Point(102, 85);
            numericUpDownPrice.Margin = new Padding(4);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(140, 23);
            numericUpDownPrice.TabIndex = 5;
            // 
            // numericUpDownCategoryId
            // 
            numericUpDownCategoryId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDownCategoryId.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownCategoryId.Location = new Point(102, 296);
            numericUpDownCategoryId.Margin = new Padding(4);
            numericUpDownCategoryId.Name = "numericUpDownCategoryId";
            numericUpDownCategoryId.Size = new Size(140, 23);
            numericUpDownCategoryId.TabIndex = 5;
            // 
            // Form62EditProductInfo
            // 
            AcceptButton = buttonUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(422, 471);
            Controls.Add(numericUpDownCategoryId);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownProductId);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxMemo);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBoxProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MinimumSize = new Size(438, 510);
            Name = "Form62EditProductInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "商品編集";
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
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownProductId;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownCategoryId;
    }
}