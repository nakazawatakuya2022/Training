namespace Umineko
{
    partial class FormReturn
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
            numericUpDownBookId = new NumericUpDown();
            buttonOk = new Button();
            label2 = new Label();
            textBoxMemberCode = new TextBox();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "蔵書ID";
            // 
            // numericUpDownBookId
            // 
            numericUpDownBookId.Enabled = false;
            numericUpDownBookId.Font = new Font("Yu Gothic UI", 11.25F);
            numericUpDownBookId.Location = new Point(87, 19);
            numericUpDownBookId.Name = "numericUpDownBookId";
            numericUpDownBookId.ReadOnly = true;
            numericUpDownBookId.Size = new Size(139, 27);
            numericUpDownBookId.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Font = new Font("Yu Gothic UI", 11.25F);
            buttonOk.Location = new Point(133, 116);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(93, 40);
            buttonOk.TabIndex = 6;
            buttonOk.Text = "返却確定";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "会員番号";
            // 
            // textBoxMemberCode
            // 
            textBoxMemberCode.Font = new Font("Yu Gothic UI", 11.25F);
            textBoxMemberCode.Location = new Point(87, 55);
            textBoxMemberCode.Name = "textBoxMemberCode";
            textBoxMemberCode.ReadOnly = true;
            textBoxMemberCode.Size = new Size(395, 27);
            textBoxMemberCode.TabIndex = 7;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Yu Gothic UI", 11.25F);
            buttonCancel.Location = new Point(287, 116);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(93, 40);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 168);
            Controls.Add(textBoxMemberCode);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(label2);
            Controls.Add(numericUpDownBookId);
            Controls.Add(label1);
            Name = "FormReturn";
            Text = "返却処理";
            ((System.ComponentModel.ISupportInitialize)numericUpDownBookId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownBookId;
        private Button buttonOk;
        private Label label2;
        private TextBox textBoxMemberCode;
        private Button buttonCancel;
    }
}