namespace AdoNetSample
{
    partial class Form22GetRecords
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
            buttonExecute = new Button();
            numericUpDownCategoryId = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            textBoxProductInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCategoryId).BeginInit();
            SuspendLayout();
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(316, 20);
            buttonExecute.Margin = new Padding(4);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(111, 41);
            buttonExecute.TabIndex = 7;
            buttonExecute.Text = "実行";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // numericUpDownCategoryId
            // 
            numericUpDownCategoryId.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownCategoryId.Location = new Point(238, 25);
            numericUpDownCategoryId.Margin = new Padding(4);
            numericUpDownCategoryId.Name = "numericUpDownCategoryId";
            numericUpDownCategoryId.Size = new Size(59, 23);
            numericUpDownCategoryId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 16);
            label2.TabIndex = 4;
            label2.Text = "該当する商品名と価格";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 16);
            label1.TabIndex = 5;
            label1.Text = "カテゴリIDを入力してください";
            // 
            // textBoxProductInfo
            // 
            textBoxProductInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProductInfo.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductInfo.Location = new Point(13, 136);
            textBoxProductInfo.Margin = new Padding(4);
            textBoxProductInfo.Multiline = true;
            textBoxProductInfo.Name = "textBoxProductInfo";
            textBoxProductInfo.ReadOnly = true;
            textBoxProductInfo.ScrollBars = ScrollBars.Vertical;
            textBoxProductInfo.Size = new Size(606, 306);
            textBoxProductInfo.TabIndex = 8;
            // 
            // Form22GetRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 459);
            Controls.Add(textBoxProductInfo);
            Controls.Add(buttonExecute);
            Controls.Add(numericUpDownCategoryId);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MinimumSize = new Size(647, 498);
            Name = "Form22GetRecords";
            StartPosition = FormStartPosition.CenterParent;
            Text = "2-2. 複数レコードの取得";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCategoryId).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.NumericUpDown numericUpDownCategoryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductInfo;
    }
}