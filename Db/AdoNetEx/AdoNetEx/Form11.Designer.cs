namespace AdoNetEx
{
    partial class Form11
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
            buttonConnect = new Button();
            SuspendLayout();
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(98, 70);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(127, 68);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "接続";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 221);
            Controls.Add(buttonConnect);
            Name = "Form11";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "1-1";
            ResumeLayout(false);

        }

        #endregion

        private Button buttonConnect;
    }
}