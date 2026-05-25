namespace AdoNetEx
{
    partial class Form31
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
            label3 = new Label();
            textBoxList = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 139);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "部署一覧";
            // 
            // textBoxList
            // 
            textBoxList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxList.Location = new Point(35, 157);
            textBoxList.Multiline = true;
            textBoxList.Name = "textBoxList";
            textBoxList.ReadOnly = true;
            textBoxList.ScrollBars = ScrollBars.Both;
            textBoxList.Size = new Size(450, 182);
            textBoxList.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 21);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "部署名";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(35, 39);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(357, 23);
            textBoxName.TabIndex = 4;
            // 
            // Form31
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 351);
            Controls.Add(textBoxName);
            Controls.Add(textBoxList);
            Controls.Add(label3);
            Controls.Add(buttonInsert);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimumSize = new Size(530, 390);
            Name = "Form31";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "3-1";
            Load += Form31InsertRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonInsert;
        private Label label3;
        private TextBox textBoxList;
        private Label label2;
        private TextBox textBoxName;
    }
}