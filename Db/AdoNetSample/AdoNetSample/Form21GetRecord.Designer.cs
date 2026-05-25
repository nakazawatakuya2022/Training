namespace AdoNetSample
{
    partial class Form21GetRecord
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
            numericUpDownProductId = new NumericUpDown();
            buttonExecute = new Button();
            label2 = new Label();
            textBoxProductName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 16);
            label1.TabIndex = 0;
            label1.Text = "商品IDを入力してください";
            // 
            // numericUpDownProductId
            // 
            numericUpDownProductId.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownProductId.Location = new Point(217, 14);
            numericUpDownProductId.Margin = new Padding(4);
            numericUpDownProductId.Name = "numericUpDownProductId";
            numericUpDownProductId.Size = new Size(59, 23);
            numericUpDownProductId.TabIndex = 1;
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(295, 9);
            buttonExecute.Margin = new Padding(4);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(111, 41);
            buttonExecute.TabIndex = 2;
            buttonExecute.Text = "実行";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 16);
            label2.TabIndex = 0;
            label2.Text = "該当する商品名";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProductName.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProductName.Location = new Point(14, 125);
            textBoxProductName.Margin = new Padding(4);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.ReadOnly = true;
            textBoxProductName.Size = new Size(606, 23);
            textBoxProductName.TabIndex = 3;
            // 
            // Form21GetRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 341);
            Controls.Add(textBoxProductName);
            Controls.Add(buttonExecute);
            Controls.Add(numericUpDownProductId);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MinimumSize = new Size(651, 380);
            Name = "Form21GetRecord";
            StartPosition = FormStartPosition.CenterParent;
            Text = "2-1. レコードの取得";
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownProductId;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductName;
    }
}