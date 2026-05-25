namespace AdoNetSample
{
    partial class Form31InsertRecord
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
            buttonInsert = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownCategoryId = new NumericUpDown();
            textBoxProductName = new TextBox();
            label5 = new Label();
            textBoxProductList = new TextBox();
            label6 = new Label();
            textBoxMemo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCategoryId).BeginInit();
            SuspendLayout();
            // 
            // buttonInsert
            // 
            buttonInsert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInsert.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInsert.Location = new Point(849, 202);
            buttonInsert.Margin = new Padding(4);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(139, 59);
            buttonInsert.TabIndex = 1;
            buttonInsert.Text = "登録";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 0;
            label2.Text = "商品名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 110);
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
            label4.Location = new Point(14, 205);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 0;
            label4.Text = "カテゴリID";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownPrice.Location = new Point(104, 101);
            numericUpDownPrice.Margin = new Padding(4);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(140, 23);
            numericUpDownPrice.TabIndex = 2;
            // 
            // numericUpDownCategoryId
            // 
            numericUpDownCategoryId.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownCategoryId.Location = new Point(104, 202);
            numericUpDownCategoryId.Margin = new Padding(4);
            numericUpDownCategoryId.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCategoryId.Name = "numericUpDownCategoryId";
            numericUpDownCategoryId.Size = new Size(140, 23);
            numericUpDownCategoryId.TabIndex = 2;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProductName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductName.Location = new Point(104, 52);
            textBoxProductName.Margin = new Padding(4);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(884, 23);
            textBoxProductName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 272);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 16);
            label5.TabIndex = 0;
            label5.Text = "商品一覧";
            // 
            // textBoxProductList
            // 
            textBoxProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProductList.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductList.Location = new Point(18, 296);
            textBoxProductList.Margin = new Padding(4);
            textBoxProductList.Multiline = true;
            textBoxProductList.Name = "textBoxProductList";
            textBoxProductList.ReadOnly = true;
            textBoxProductList.ScrollBars = ScrollBars.Both;
            textBoxProductList.Size = new Size(970, 274);
            textBoxProductList.TabIndex = 3;
            textBoxProductList.WordWrap = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 155);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 16);
            label6.TabIndex = 0;
            label6.Text = "商品説明";
            // 
            // textBoxMemo
            // 
            textBoxMemo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMemo.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMemo.Location = new Point(104, 150);
            textBoxMemo.Margin = new Padding(4);
            textBoxMemo.Name = "textBoxMemo";
            textBoxMemo.Size = new Size(884, 23);
            textBoxMemo.TabIndex = 3;
            // 
            // Form31InsertRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1002, 590);
            Controls.Add(textBoxProductList);
            Controls.Add(textBoxMemo);
            Controls.Add(textBoxProductName);
            Controls.Add(numericUpDownCategoryId);
            Controls.Add(numericUpDownPrice);
            Controls.Add(buttonInsert);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4);
            MinimumSize = new Size(1018, 629);
            Name = "Form31InsertRecord";
            StartPosition = FormStartPosition.CenterParent;
            Text = "3-1. レコードの追加";
            Load += Form31InsertRecord_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCategoryId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonInsert;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownCategoryId;
        private TextBox textBoxProductName;
        private Label label5;
        private TextBox textBoxProductList;
        private Label label6;
        private TextBox textBoxMemo;
    }
}