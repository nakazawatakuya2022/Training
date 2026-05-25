namespace Umineko
{
    partial class FormMain
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
            menuStrip = new MenuStrip();
            toolStripMenuItemHelp = new ToolStripMenuItem();
            toolStripMenuItemVersion = new ToolStripMenuItem();
            buttonList = new Button();
            pictureBoxLogo = new PictureBox();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemHelp });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(513, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemHelp
            // 
            toolStripMenuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemVersion });
            toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            toolStripMenuItemHelp.Size = new Size(65, 20);
            toolStripMenuItemHelp.Text = "ヘルプ(&H)";
            // 
            // toolStripMenuItemVersion
            // 
            toolStripMenuItemVersion.Name = "toolStripMenuItemVersion";
            toolStripMenuItemVersion.Size = new Size(180, 22);
            toolStripMenuItemVersion.Text = "バージョン(&V)";
            toolStripMenuItemVersion.Click += toolStripMenuItemVersion_Click;
            // 
            // buttonList
            // 
            buttonList.Font = new Font("Yu Gothic UI", 11.25F);
            buttonList.Location = new Point(12, 44);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(105, 39);
            buttonList.TabIndex = 1;
            buttonList.Text = "蔵書一覧";
            buttonList.UseVisualStyleBackColor = true;
            buttonList.Click += buttonList_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.umineko;
            pictureBoxLogo.Location = new Point(12, 184);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(275, 59);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 255);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonList);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            Text = "うみねこ町立図書館";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private ToolStripMenuItem toolStripMenuItemVersion;
        private Button buttonList;
        private PictureBox pictureBoxLogo;
    }
}