namespace AdoNetEx
{
    partial class Form33
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
            textBoxName = new TextBox();
            label4 = new Label();
            numericUpDownDepartmentId = new NumericUpDown();
            label5 = new Label();
            dateTimePickerHireDate = new DateTimePicker();
            label3 = new Label();
            textBoxList = new TextBox();
            label6 = new Label();
            numericUpDownManagerId = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepartmentId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownManagerId).BeginInit();
            SuspendLayout();
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(419, 28);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(83, 34);
            buttonInsert.TabIndex = 2;
            buttonInsert.Text = "登録";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 73);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "社員名";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(35, 91);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(357, 23);
            textBoxName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 134);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 1;
            label4.Text = "入社日";
            // 
            // numericUpDownDepartmentId
            // 
            numericUpDownDepartmentId.Location = new Point(212, 36);
            numericUpDownDepartmentId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownDepartmentId.Name = "numericUpDownDepartmentId";
            numericUpDownDepartmentId.Size = new Size(120, 23);
            numericUpDownDepartmentId.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 18);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 1;
            label5.Text = "部署ID";
            // 
            // dateTimePickerHireDate
            // 
            dateTimePickerHireDate.Location = new Point(236, 152);
            dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            dateTimePickerHireDate.Size = new Size(156, 23);
            dateTimePickerHireDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 209);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "社員一覧";
            // 
            // textBoxList
            // 
            textBoxList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxList.Location = new Point(35, 227);
            textBoxList.Multiline = true;
            textBoxList.Name = "textBoxList";
            textBoxList.ReadOnly = true;
            textBoxList.ScrollBars = ScrollBars.Both;
            textBoxList.Size = new Size(450, 156);
            textBoxList.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 134);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 1;
            label6.Text = "上司の社員ID";
            // 
            // numericUpDownManagerId
            // 
            numericUpDownManagerId.Location = new Point(36, 156);
            numericUpDownManagerId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownManagerId.Name = "numericUpDownManagerId";
            numericUpDownManagerId.Size = new Size(120, 23);
            numericUpDownManagerId.TabIndex = 6;
            // 
            // Form33
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 395);
            Controls.Add(numericUpDownManagerId);
            Controls.Add(dateTimePickerHireDate);
            Controls.Add(textBoxName);
            Controls.Add(textBoxList);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(buttonInsert);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numericUpDownDepartmentId);
            MaximizeBox = false;
            MinimumSize = new Size(530, 434);
            Name = "Form33";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "3-3";
            Load += Form33_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepartmentId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownManagerId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonInsert;
        private Label label2;
        private TextBox textBoxName;
        private Label label4;
        private NumericUpDown numericUpDownDepartmentId;
        private Label label5;
        private DateTimePicker dateTimePickerHireDate;
        private Label label3;
        private TextBox textBoxList;
        private Label label6;
        private NumericUpDown numericUpDownManagerId;
    }
}