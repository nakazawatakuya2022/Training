namespace AdoNetEx
{
    partial class Form51
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
            buttonDelete = new Button();
            label3 = new Label();
            textBoxList = new TextBox();
            numericUpDownDepartmentId = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepartmentId).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(419, 28);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(83, 34);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "削除";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonInsert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 86);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "部署一覧";
            // 
            // textBoxList
            // 
            textBoxList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxList.Location = new Point(35, 104);
            textBoxList.Multiline = true;
            textBoxList.Name = "textBoxList";
            textBoxList.ReadOnly = true;
            textBoxList.ScrollBars = ScrollBars.Both;
            textBoxList.Size = new Size(450, 235);
            textBoxList.TabIndex = 3;
            // 
            // numericUpDownDepartmentId
            // 
            numericUpDownDepartmentId.Location = new Point(35, 36);
            numericUpDownDepartmentId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownDepartmentId.Name = "numericUpDownDepartmentId";
            numericUpDownDepartmentId.Size = new Size(120, 23);
            numericUpDownDepartmentId.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 18);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 1;
            label5.Text = "部署ID";
            // 
            // Form51
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 351);
            Controls.Add(textBoxList);
            Controls.Add(label3);
            Controls.Add(buttonDelete);
            Controls.Add(label5);
            Controls.Add(numericUpDownDepartmentId);
            MaximizeBox = false;
            MinimumSize = new Size(530, 390);
            Name = "Form51";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "5-1";
            Load += Form31InsertRecord_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepartmentId).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Button buttonDelete;
        private Label label3;
        private TextBox textBoxList;
        private NumericUpDown numericUpDownDepartmentId;
        private Label label5;
    }
}