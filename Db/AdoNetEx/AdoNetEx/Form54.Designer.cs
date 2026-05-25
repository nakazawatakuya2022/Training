namespace AdoNetEx
{
    partial class Form54
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
            numericUpDownId = new NumericUpDown();
            label1 = new Label();
            buttonDelete = new Button();
            textBoxList = new TextBox();
            label3 = new Label();
            label5 = new Label();
            numericUpDownLicenseId = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLicenseId).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(35, 36);
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(120, 23);
            numericUpDownId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "社員ID";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(419, 28);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(83, 34);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "削除";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxList
            // 
            textBoxList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxList.Location = new Point(35, 100);
            textBoxList.Multiline = true;
            textBoxList.Name = "textBoxList";
            textBoxList.ReadOnly = true;
            textBoxList.ScrollBars = ScrollBars.Both;
            textBoxList.Size = new Size(450, 283);
            textBoxList.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 82);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 6;
            label3.Text = "資格実績一覧";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(214, 18);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 1;
            label5.Text = "資格ID";
            // 
            // numericUpDownLicenseId
            // 
            numericUpDownLicenseId.Location = new Point(214, 36);
            numericUpDownLicenseId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownLicenseId.Name = "numericUpDownLicenseId";
            numericUpDownLicenseId.Size = new Size(120, 23);
            numericUpDownLicenseId.TabIndex = 0;
            // 
            // Form54
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 395);
            Controls.Add(textBoxList);
            Controls.Add(label3);
            Controls.Add(buttonDelete);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(numericUpDownLicenseId);
            Controls.Add(numericUpDownId);
            MaximizeBox = false;
            MinimumSize = new Size(530, 434);
            Name = "Form54";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "5-4";
            Load += Form54_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLicenseId).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownId;
        private Label label1;
        private Button buttonDelete;
        private TextBox textBoxList;
        private Label label3;
        private Label label5;
        private NumericUpDown numericUpDownLicenseId;
    }
}