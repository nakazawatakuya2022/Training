namespace AdoNetEx
{
    partial class Form42
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
            label3 = new Label();
            textBoxList = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label4 = new Label();
            textBoxAuthority = new TextBox();
            numericUpDownReward = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReward).BeginInit();
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
            label1.Text = "資格ID";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(419, 28);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(83, 34);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "更新";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonInsert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 209);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "資格一覧";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 73);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "資格名";
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
            label4.Location = new Point(35, 126);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 1;
            label4.Text = "認定団体";
            // 
            // textBoxAuthority
            // 
            textBoxAuthority.Location = new Point(35, 144);
            textBoxAuthority.Name = "textBoxAuthority";
            textBoxAuthority.Size = new Size(357, 23);
            textBoxAuthority.TabIndex = 4;
            // 
            // numericUpDownReward
            // 
            numericUpDownReward.Location = new Point(214, 36);
            numericUpDownReward.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownReward.Name = "numericUpDownReward";
            numericUpDownReward.Size = new Size(120, 23);
            numericUpDownReward.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(214, 18);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 1;
            label5.Text = "資格手当";
            // 
            // Form42
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 395);
            Controls.Add(textBoxAuthority);
            Controls.Add(textBoxName);
            Controls.Add(textBoxList);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(buttonUpdate);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(numericUpDownReward);
            Controls.Add(numericUpDownId);
            MaximizeBox = false;
            MinimumSize = new Size(530, 434);
            Name = "Form42";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "4-2";
            Load += Form42InsertRecord_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownReward).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownId;
        private Label label1;
        private Button buttonUpdate;
        private Label label3;
        private TextBox textBoxList;
        private Label label2;
        private TextBox textBoxName;
        private Label label4;
        private TextBox textBoxAuthority;
        private NumericUpDown numericUpDownReward;
        private Label label5;
    }
}