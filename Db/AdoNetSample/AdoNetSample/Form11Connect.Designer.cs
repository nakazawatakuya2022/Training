namespace AdoNetSample
{
    partial class Form11Connect
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
            buttonConnect.Location = new Point(210, 165);
            buttonConnect.Margin = new Padding(4);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(170, 86);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "接続テスト";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // Form11Connect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 409);
            Controls.Add(buttonConnect);
            Margin = new Padding(4);
            Name = "Form11Connect";
            StartPosition = FormStartPosition.CenterParent;
            Text = "1-1. データベースの接続と切断";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
    }
}