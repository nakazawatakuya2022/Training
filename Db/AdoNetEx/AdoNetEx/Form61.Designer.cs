namespace AdoNetEx
{
    partial class Form61
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
            buttonCount = new Button();
            label3 = new Label();
            textBoxList = new TextBox();
            label2 = new Label();
            textBoxEmployeesCount = new TextBox();
            textBoxLicensesCount = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "社員数";
            // 
            // buttonCount
            // 
            buttonCount.Location = new Point(419, 28);
            buttonCount.Name = "buttonCount";
            buttonCount.Size = new Size(83, 34);
            buttonCount.TabIndex = 2;
            buttonCount.Text = "カウント";
            buttonCount.UseVisualStyleBackColor = true;
            buttonCount.Click += buttonCount_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 165);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 1;
            label3.Text = "資格ごとの取得している社員数";
            // 
            // textBoxList
            // 
            textBoxList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxList.Location = new Point(35, 183);
            textBoxList.Multiline = true;
            textBoxList.Name = "textBoxList";
            textBoxList.ReadOnly = true;
            textBoxList.ScrollBars = ScrollBars.Both;
            textBoxList.Size = new Size(450, 200);
            textBoxList.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 79);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "資格数";
            // 
            // textBoxEmployeesCount
            // 
            textBoxEmployeesCount.Location = new Point(35, 39);
            textBoxEmployeesCount.Name = "textBoxEmployeesCount";
            textBoxEmployeesCount.ReadOnly = true;
            textBoxEmployeesCount.Size = new Size(155, 23);
            textBoxEmployeesCount.TabIndex = 4;
            // 
            // textBoxLicensesCount
            // 
            textBoxLicensesCount.Location = new Point(35, 97);
            textBoxLicensesCount.Name = "textBoxLicensesCount";
            textBoxLicensesCount.ReadOnly = true;
            textBoxLicensesCount.Size = new Size(155, 23);
            textBoxLicensesCount.TabIndex = 4;
            // 
            // Form61
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 395);
            Controls.Add(textBoxLicensesCount);
            Controls.Add(textBoxEmployeesCount);
            Controls.Add(textBoxList);
            Controls.Add(label3);
            Controls.Add(buttonCount);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimumSize = new Size(530, 434);
            Name = "Form61";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "6-1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label label1;
        private Button buttonCount;
        private Label label3;
        private TextBox textBoxList;
        private Label label2;
        private TextBox textBoxEmployeesCount;
        private TextBox textBoxLicensesCount;
    }
}