namespace Umineko
{
    partial class FormLentHistory
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
            buttonOk = new Button();
            textBoxHistory = new TextBox();
            label1 = new Label();
            numericUpDownBookId = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookId).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOk.DialogResult = DialogResult.Cancel;
            buttonOk.Font = new Font("Yu Gothic UI", 11.25F);
            buttonOk.Location = new Point(257, 421);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(77, 32);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "閉じる";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // textBoxHistory
            // 
            textBoxHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxHistory.Location = new Point(15, 89);
            textBoxHistory.Multiline = true;
            textBoxHistory.Name = "textBoxHistory";
            textBoxHistory.ReadOnly = true;
            textBoxHistory.ScrollBars = ScrollBars.Both;
            textBoxHistory.Size = new Size(577, 312);
            textBoxHistory.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F);
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "蔵書ID";
            // 
            // numericUpDownBookId
            // 
            numericUpDownBookId.Location = new Point(75, 12);
            numericUpDownBookId.Name = "numericUpDownBookId";
            numericUpDownBookId.ReadOnly = true;
            numericUpDownBookId.Size = new Size(84, 23);
            numericUpDownBookId.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F);
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "貸出履歴";
            // 
            // FormLentHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 465);
            Controls.Add(numericUpDownBookId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxHistory);
            Controls.Add(buttonOk);
            Name = "FormLentHistory";
            Text = "貸出履歴一覧";
            Load += FormLentHistory_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonOk;
        private TextBox textBoxHistory;
        private Label label1;
        private NumericUpDown numericUpDownBookId;
        private Label label2;
    }
}