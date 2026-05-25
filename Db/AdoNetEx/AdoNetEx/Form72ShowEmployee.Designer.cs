namespace AdoNetEx
{
    partial class Form72ShowEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.numericUpDownDepartmentId = new System.Windows.Forms.NumericUpDown();
            this.textBoxManagerId = new System.Windows.Forms.TextBox();
            this.dateTimePickerHireDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartmentId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "社員ID";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(104, 25);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.ReadOnly = true;
            this.numericUpDownId.Size = new System.Drawing.Size(166, 23);
            this.numericUpDownId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "氏名";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(104, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(166, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "入社日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "上司の社員ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "部署ID";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(107, 182);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(88, 43);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDepartmentId
            // 
            this.numericUpDownDepartmentId.Location = new System.Drawing.Point(104, 142);
            this.numericUpDownDepartmentId.Name = "numericUpDownDepartmentId";
            this.numericUpDownDepartmentId.ReadOnly = true;
            this.numericUpDownDepartmentId.Size = new System.Drawing.Size(166, 23);
            this.numericUpDownDepartmentId.TabIndex = 1;
            // 
            // textBoxManagerId
            // 
            this.textBoxManagerId.Location = new System.Drawing.Point(104, 113);
            this.textBoxManagerId.Name = "textBoxManagerId";
            this.textBoxManagerId.ReadOnly = true;
            this.textBoxManagerId.Size = new System.Drawing.Size(166, 23);
            this.textBoxManagerId.TabIndex = 3;
            // 
            // dateTimePickerHireDate
            // 
            this.dateTimePickerHireDate.Enabled = false;
            this.dateTimePickerHireDate.Location = new System.Drawing.Point(104, 84);
            this.dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            this.dateTimePickerHireDate.Size = new System.Drawing.Size(166, 23);
            this.dateTimePickerHireDate.TabIndex = 4;
            // 
            // Form72ShowEmployee
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 246);
            this.Controls.Add(this.dateTimePickerHireDate);
            this.Controls.Add(this.textBoxManagerId);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownDepartmentId);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form72ShowEmployee";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社員詳細";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepartmentId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownId;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonOk;
        private NumericUpDown numericUpDownDepartmentId;
        private TextBox textBoxManagerId;
        private DateTimePicker dateTimePickerHireDate;
    }
}