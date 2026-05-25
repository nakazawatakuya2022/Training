namespace AdoNetEx
{
    partial class Form12
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
            textBoxLicenseName = new TextBox();
            label3 = new Label();
            textBoxAuthority = new TextBox();
            label4 = new Label();
            textBoxReward = new TextBox();
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
            // textBoxLicenseName
            // 
            textBoxLicenseName.Location = new Point(35, 109);
            textBoxLicenseName.Name = "textBoxLicenseName";
            textBoxLicenseName.ReadOnly = true;
            textBoxLicenseName.Size = new Size(450, 23);
            textBoxLicenseName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 149);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "認定団体";
            // 
            // textBoxAuthority
            // 
            textBoxAuthority.Location = new Point(35, 167);
            textBoxAuthority.Name = "textBoxAuthority";
            textBoxAuthority.ReadOnly = true;
            textBoxAuthority.Size = new Size(450, 23);
            textBoxAuthority.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 209);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 1;
            label4.Text = "資格手当の金額";
            // 
            // textBoxReward
            // 
            textBoxReward.Location = new Point(35, 227);
            textBoxReward.Name = "textBoxReward";
            textBoxReward.ReadOnly = true;
            textBoxReward.Size = new Size(450, 23);
            textBoxReward.TabIndex = 3;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 282);
            Controls.Add(textBoxReward);
            Controls.Add(textBoxAuthority);
            Controls.Add(label4);
            Controls.Add(textBoxLicenseName);
            Controls.Add(label3);
            Controls.Add(buttonDisplay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownLicenseId);
            MaximizeBox = false;
            MaximumSize = new Size(535, 321);
            MinimumSize = new Size(535, 321);
            Name = "Form12";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "1-2";
            ((System.ComponentModel.ISupportInitialize)numericUpDownLicenseId).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownLicenseId;
        private Label label1;
        private Button buttonDisplay;
        private Label label2;
        private TextBox textBoxLicenseName;
        private Label label3;
        private TextBox textBoxAuthority;
        private Label label4;
        private TextBox textBoxReward;
    }
}