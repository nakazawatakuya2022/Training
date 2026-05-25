namespace AdoNetEx
{
    partial class Form44
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
            buttonUpdate = new Button();
            numericUpDownLicenseId = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            dateTimePickerCertifiedDate = new DateTimePicker();
            textBoxList = new TextBox();
            label3 = new Label();
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
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(419, 28);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(83, 34);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "更新";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // numericUpDownLicenseId
            // 
            numericUpDownLicenseId.Location = new Point(214, 36);
            numericUpDownLicenseId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownLicenseId.Name = "numericUpDownLicenseId";
            numericUpDownLicenseId.Size = new Size(120, 23);
            numericUpDownLicenseId.TabIndex = 0;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 84);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 1;
            label4.Text = "取得日";
            // 
            // dateTimePickerCertifiedDate
            // 
            dateTimePickerCertifiedDate.Location = new Point(35, 102);
            dateTimePickerCertifiedDate.Name = "dateTimePickerCertifiedDate";
            dateTimePickerCertifiedDate.Size = new Size(156, 23);
            dateTimePickerCertifiedDate.TabIndex = 5;
            // 
            // textBoxList
            // 
            textBoxList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxList.Location = new Point(35, 171);
            textBoxList.Multiline = true;
            textBoxList.Name = "textBoxList";
            textBoxList.ReadOnly = true;
            textBoxList.ScrollBars = ScrollBars.Both;
            textBoxList.Size = new Size(450, 212);
            textBoxList.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 153);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 6;
            label3.Text = "資格実績一覧";
            // 
            // Form44
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 395);
            Controls.Add(textBoxList);
            Controls.Add(label3);
            Controls.Add(dateTimePickerCertifiedDate);
            Controls.Add(label4);
            Controls.Add(buttonUpdate);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(numericUpDownLicenseId);
            Controls.Add(numericUpDownId);
            MaximizeBox = false;
            MinimumSize = new Size(530, 434);
            Name = "Form44";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "4-4";
            Load += Form44_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLicenseId).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownId;
        private Label label1;
        private Button buttonUpdate;
        private NumericUpDown numericUpDownLicenseId;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePickerCertifiedDate;
        private TextBox textBoxList;
        private Label label3;
    }
}