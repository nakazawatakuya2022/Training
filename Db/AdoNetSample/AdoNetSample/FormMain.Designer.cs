namespace AdoNetSample
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button11Connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button22GetRecords = new System.Windows.Forms.Button();
            this.button21GetRecord = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button33DeleteRecord = new System.Windows.Forms.Button();
            this.button32UpdateRecord = new System.Windows.Forms.Button();
            this.button31InsertRecord = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button41CountRecord = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button52Search = new System.Windows.Forms.Button();
            this.button51DataGridView = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button64ComplicatedList = new System.Windows.Forms.Button();
            this.button63OtherControls = new System.Windows.Forms.Button();
            this.button62UpdateList = new System.Windows.Forms.Button();
            this.button61DisplayList = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "C#コース データベース編 研修用プログラム";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button11Connect);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. DB接続・切断";
            // 
            // button11Connect
            // 
            this.button11Connect.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11Connect.Location = new System.Drawing.Point(6, 22);
            this.button11Connect.Name = "button11Connect";
            this.button11Connect.Size = new System.Drawing.Size(377, 39);
            this.button11Connect.TabIndex = 0;
            this.button11Connect.Text = "1-1. DB接続と切断";
            this.button11Connect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11Connect.UseVisualStyleBackColor = true;
            this.button11Connect.Click += new System.EventHandler(this.button11Connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button22GetRecords);
            this.groupBox2.Controls.Add(this.button21GetRecord);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. レコードの取得・表示";
            // 
            // button22GetRecords
            // 
            this.button22GetRecords.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button22GetRecords.Location = new System.Drawing.Point(6, 67);
            this.button22GetRecords.Name = "button22GetRecords";
            this.button22GetRecords.Size = new System.Drawing.Size(377, 39);
            this.button22GetRecords.TabIndex = 1;
            this.button22GetRecords.Text = "2-2. 複数レコードの取得";
            this.button22GetRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button22GetRecords.UseVisualStyleBackColor = true;
            this.button22GetRecords.Click += new System.EventHandler(this.button22GetRecords_Click);
            // 
            // button21GetRecord
            // 
            this.button21GetRecord.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button21GetRecord.Location = new System.Drawing.Point(6, 22);
            this.button21GetRecord.Name = "button21GetRecord";
            this.button21GetRecord.Size = new System.Drawing.Size(377, 39);
            this.button21GetRecord.TabIndex = 0;
            this.button21GetRecord.Text = "2-1. レコードの取得";
            this.button21GetRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button21GetRecord.UseVisualStyleBackColor = true;
            this.button21GetRecord.Click += new System.EventHandler(this.button21GetRecord_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button33DeleteRecord);
            this.groupBox3.Controls.Add(this.button32UpdateRecord);
            this.groupBox3.Controls.Add(this.button31InsertRecord);
            this.groupBox3.Location = new System.Drawing.Point(12, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 163);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. レコードの追加・更新・削除";
            // 
            // button33DeleteRecord
            // 
            this.button33DeleteRecord.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button33DeleteRecord.Location = new System.Drawing.Point(6, 112);
            this.button33DeleteRecord.Name = "button33DeleteRecord";
            this.button33DeleteRecord.Size = new System.Drawing.Size(377, 39);
            this.button33DeleteRecord.TabIndex = 2;
            this.button33DeleteRecord.Text = "3-3. レコードの削除";
            this.button33DeleteRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button33DeleteRecord.UseVisualStyleBackColor = true;
            this.button33DeleteRecord.Click += new System.EventHandler(this.button33DeleteRecord_Click);
            // 
            // button32UpdateRecord
            // 
            this.button32UpdateRecord.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button32UpdateRecord.Location = new System.Drawing.Point(6, 67);
            this.button32UpdateRecord.Name = "button32UpdateRecord";
            this.button32UpdateRecord.Size = new System.Drawing.Size(377, 39);
            this.button32UpdateRecord.TabIndex = 1;
            this.button32UpdateRecord.Text = "3-2. レコードの更新";
            this.button32UpdateRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button32UpdateRecord.UseVisualStyleBackColor = true;
            this.button32UpdateRecord.Click += new System.EventHandler(this.button32UpdateRecord_Click);
            // 
            // button31InsertRecord
            // 
            this.button31InsertRecord.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button31InsertRecord.Location = new System.Drawing.Point(6, 22);
            this.button31InsertRecord.Name = "button31InsertRecord";
            this.button31InsertRecord.Size = new System.Drawing.Size(377, 39);
            this.button31InsertRecord.TabIndex = 0;
            this.button31InsertRecord.Text = "3-1. レコードの追加";
            this.button31InsertRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button31InsertRecord.UseVisualStyleBackColor = true;
            this.button31InsertRecord.Click += new System.EventHandler(this.button31InsertRecord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::AdoNetSample.Properties.Resources.PandaPharmacy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button41CountRecord);
            this.groupBox4.Location = new System.Drawing.Point(422, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 74);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4. レコードのカウント";
            // 
            // button41CountRecord
            // 
            this.button41CountRecord.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button41CountRecord.Location = new System.Drawing.Point(6, 22);
            this.button41CountRecord.Name = "button41CountRecord";
            this.button41CountRecord.Size = new System.Drawing.Size(377, 39);
            this.button41CountRecord.TabIndex = 0;
            this.button41CountRecord.Text = "4-1. レコードのカウント";
            this.button41CountRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button41CountRecord.UseVisualStyleBackColor = true;
            this.button41CountRecord.Click += new System.EventHandler(this.button41CountRecord_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button52Search);
            this.groupBox5.Controls.Add(this.button51DataGridView);
            this.groupBox5.Location = new System.Drawing.Point(422, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(389, 117);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "5. DatagridView";
            // 
            // button52Search
            // 
            this.button52Search.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button52Search.Location = new System.Drawing.Point(6, 67);
            this.button52Search.Name = "button52Search";
            this.button52Search.Size = new System.Drawing.Size(377, 39);
            this.button52Search.TabIndex = 1;
            this.button52Search.Text = "5-2. データの検索とイベント";
            this.button52Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button52Search.UseVisualStyleBackColor = true;
            this.button52Search.Click += new System.EventHandler(this.button52Search_Click);
            // 
            // button51DataGridView
            // 
            this.button51DataGridView.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button51DataGridView.Location = new System.Drawing.Point(6, 22);
            this.button51DataGridView.Name = "button51DataGridView";
            this.button51DataGridView.Size = new System.Drawing.Size(377, 39);
            this.button51DataGridView.TabIndex = 0;
            this.button51DataGridView.Text = "5-1. DataGridViewコントロール";
            this.button51DataGridView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button51DataGridView.UseVisualStyleBackColor = true;
            this.button51DataGridView.Click += new System.EventHandler(this.button51DataGridView_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button64ComplicatedList);
            this.groupBox6.Controls.Add(this.button63OtherControls);
            this.groupBox6.Controls.Add(this.button62UpdateList);
            this.groupBox6.Controls.Add(this.button61DisplayList);
            this.groupBox6.Location = new System.Drawing.Point(422, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(389, 208);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "6. フォーム間での値の受け渡し";
            // 
            // button64ComplicatedList
            // 
            this.button64ComplicatedList.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button64ComplicatedList.Location = new System.Drawing.Point(6, 157);
            this.button64ComplicatedList.Name = "button64ComplicatedList";
            this.button64ComplicatedList.Size = new System.Drawing.Size(377, 39);
            this.button64ComplicatedList.TabIndex = 3;
            this.button64ComplicatedList.Text = "6-4. 複雑な一覧とカード画面";
            this.button64ComplicatedList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button64ComplicatedList.UseVisualStyleBackColor = true;
            this.button64ComplicatedList.Click += new System.EventHandler(this.button64ComplicatedList_Click);
            // 
            // button63OtherControls
            // 
            this.button63OtherControls.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button63OtherControls.Location = new System.Drawing.Point(6, 112);
            this.button63OtherControls.Name = "button63OtherControls";
            this.button63OtherControls.Size = new System.Drawing.Size(377, 39);
            this.button63OtherControls.TabIndex = 2;
            this.button63OtherControls.Text = "6-3. その他のコントロール";
            this.button63OtherControls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button63OtherControls.UseVisualStyleBackColor = true;
            this.button63OtherControls.Click += new System.EventHandler(this.button63OtherControls_Click);
            // 
            // button62UpdateList
            // 
            this.button62UpdateList.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button62UpdateList.Location = new System.Drawing.Point(6, 67);
            this.button62UpdateList.Name = "button62UpdateList";
            this.button62UpdateList.Size = new System.Drawing.Size(377, 39);
            this.button62UpdateList.TabIndex = 1;
            this.button62UpdateList.Text = "6-2. 一覧とカード画面の更新";
            this.button62UpdateList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button62UpdateList.UseVisualStyleBackColor = true;
            this.button62UpdateList.Click += new System.EventHandler(this.button62UpdateList_Click);
            // 
            // button61DisplayList
            // 
            this.button61DisplayList.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button61DisplayList.Location = new System.Drawing.Point(6, 22);
            this.button61DisplayList.Name = "button61DisplayList";
            this.button61DisplayList.Size = new System.Drawing.Size(377, 39);
            this.button61DisplayList.TabIndex = 0;
            this.button61DisplayList.Text = "6-1. 一覧とカード画面の表示";
            this.button61DisplayList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button61DisplayList.UseVisualStyleBackColor = true;
            this.button61DisplayList.Click += new System.EventHandler(this.button61DisplayList_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(702, 535);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 38);
            this.buttonClose.TabIndex = 99;
            this.buttonClose.Text = "終了";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(828, 587);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(844, 626);
            this.MinimumSize = new System.Drawing.Size(844, 626);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "メインメニュー";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button11Connect;
        private GroupBox groupBox2;
        private Button button22GetRecords;
        private Button button21GetRecord;
        private GroupBox groupBox3;
        private Button button33DeleteRecord;
        private Button button32UpdateRecord;
        private Button button31InsertRecord;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private Button button41CountRecord;
        private GroupBox groupBox5;
        private Button button52Search;
        private Button button51DataGridView;
        private GroupBox groupBox6;
        private Button button64ComplicatedList;
        private Button button63OtherControls;
        private Button button62UpdateList;
        private Button button61DisplayList;
        private Button buttonClose;
    }
}