namespace AdoNetEx
{
    partial class Form22
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
            numericUpDownLicenseId = new NumericUpDown();
            label1 = new Label();
            buttonDisplay = new Button();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxEmployees = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLicenseId).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownLicenseId
            // 
            numericUpDownLicenseId.Location = new Point(35, 36);
            numericUpDownLicenseId.Name = "numericUpDownLicenseId";
            numericUpDownLicenseId.Size = new Size(120, 23);
            numericUpDownLicenseId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 1;
            label1.Text = "資格IDを入力してください";
            // 
            // buttonDisplay
            // 
            buttonDisplay.Location = new Point(177, 28);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Size = new Size(83, 34);
            buttonDisplay.TabIndex = 2;
            buttonDisplay.Text = "表示";
            buttonDisplay.UseVisualStyleBackColor = true;
            buttonDisplay.Click += buttonExecute_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 91);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "該当する資格名";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(35, 109);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(450, 23);
            textBoxName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 149);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 1;
            label3.Text = "取得している社員一覧";
            // 
            // textBoxEmployees
            // 
            textBoxEmployees.Location = new Point(35, 167);
            textBoxEmployees.Multiline = true;
            textBoxEmployees.Name = "textBoxEmployees";
            textBoxEmployees.ReadOnly = true;
            textBoxEmployees.ScrollBars = ScrollBars.Both;
            textBoxEmployees.Size = new Size(450, 216);
            textBoxEmployees.TabIndex = 3;
            // 
            // Form22
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 395);
            Controls.Add(textBoxEmployees);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(buttonDisplay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownLicenseId);
            MaximizeBox = false;
            MaximumSize = new Size(530, 434);
            MinimumSize = new Size(530, 434);
            Name = "Form22";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2-2";
            ((System.ComponentModel.ISupportInitialize)numericUpDownLicenseId).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownLicenseId;
        private Label label1;
        private Button buttonDisplay;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxEmployees;
    }
}