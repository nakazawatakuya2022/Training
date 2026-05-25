namespace AdoNetSample
{
    partial class Form41CountRecord
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCountCategories = new System.Windows.Forms.TextBox();
            this.textBoxCountProducts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCountProductsList = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "カテゴリの総数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "商品の総数";
            // 
            // textBoxCountCategories
            // 
            this.textBoxCountCategories.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountCategories.Location = new System.Drawing.Point(14, 114);
            this.textBoxCountCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCountCategories.Name = "textBoxCountCategories";
            this.textBoxCountCategories.ReadOnly = true;
            this.textBoxCountCategories.Size = new System.Drawing.Size(149, 23);
            this.textBoxCountCategories.TabIndex = 1;
            // 
            // textBoxCountProducts
            // 
            this.textBoxCountProducts.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountProducts.Location = new System.Drawing.Point(18, 192);
            this.textBoxCountProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCountProducts.Name = "textBoxCountProducts";
            this.textBoxCountProducts.ReadOnly = true;
            this.textBoxCountProducts.Size = new System.Drawing.Size(149, 23);
            this.textBoxCountProducts.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "カテゴリごとの商品数";
            // 
            // textBoxCountProductsList
            // 
            this.textBoxCountProductsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCountProductsList.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountProductsList.Location = new System.Drawing.Point(18, 288);
            this.textBoxCountProductsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCountProductsList.Multiline = true;
            this.textBoxCountProductsList.Name = "textBoxCountProductsList";
            this.textBoxCountProductsList.ReadOnly = true;
            this.textBoxCountProductsList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCountProductsList.Size = new System.Drawing.Size(641, 343);
            this.textBoxCountProductsList.TabIndex = 1;
            this.textBoxCountProductsList.WordWrap = false;
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(18, 15);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(122, 46);
            this.buttonCount.TabIndex = 2;
            this.buttonCount.Text = "カウント";
            this.buttonCount.UseVisualStyleBackColor = true;
            // 
            // Form41CountRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 646);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxCountProductsList);
            this.Controls.Add(this.textBoxCountProducts);
            this.Controls.Add(this.textBoxCountCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(689, 685);
            this.Name = "Form41CountRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "4-1. レコードのカウント";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCountCategories;
        private System.Windows.Forms.TextBox textBoxCountProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCountProductsList;
        private System.Windows.Forms.Button buttonCount;
    }
}