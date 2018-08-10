namespace qbittorrentremote
{
    partial class AddTorrent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SavePathAsDefault = new System.Windows.Forms.CheckBox();
            this.SavePathComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveCategoryAsDefautl = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.AddTorrentBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TorrentStructureTreeView = new System.Windows.Forms.TreeView();
            this.Commentlbl = new System.Windows.Forms.Label();
            this.Hashlbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Sizelbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SavePathAsDefault);
            this.groupBox1.Controls.Add(this.SavePathComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save to";
            // 
            // SavePathAsDefault
            // 
            this.SavePathAsDefault.AutoSize = true;
            this.SavePathAsDefault.Location = new System.Drawing.Point(61, 46);
            this.SavePathAsDefault.Name = "SavePathAsDefault";
            this.SavePathAsDefault.Size = new System.Drawing.Size(172, 17);
            this.SavePathAsDefault.TabIndex = 5;
            this.SavePathAsDefault.Text = "Remember last used save path";
            this.SavePathAsDefault.UseVisualStyleBackColor = true;
            // 
            // SavePathComboBox
            // 
            this.SavePathComboBox.FormattingEnabled = true;
            this.SavePathComboBox.Location = new System.Drawing.Point(61, 19);
            this.SavePathComboBox.Name = "SavePathComboBox";
            this.SavePathComboBox.Size = new System.Drawing.Size(281, 21);
            this.SavePathComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Save to:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveCategoryAsDefautl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CategoriesComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Torrent settings";
            // 
            // SaveCategoryAsDefautl
            // 
            this.SaveCategoryAsDefautl.AutoSize = true;
            this.SaveCategoryAsDefautl.Location = new System.Drawing.Point(61, 46);
            this.SaveCategoryAsDefautl.Name = "SaveCategoryAsDefautl";
            this.SaveCategoryAsDefautl.Size = new System.Drawing.Size(166, 17);
            this.SaveCategoryAsDefautl.TabIndex = 7;
            this.SaveCategoryAsDefautl.Text = "Remember last used category";
            this.SaveCategoryAsDefautl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category:";
            // 
            // CategoriesComboBox
            // 
            this.CategoriesComboBox.FormattingEnabled = true;
            this.CategoriesComboBox.Location = new System.Drawing.Point(61, 19);
            this.CategoriesComboBox.Name = "CategoriesComboBox";
            this.CategoriesComboBox.Size = new System.Drawing.Size(281, 21);
            this.CategoriesComboBox.TabIndex = 5;
            // 
            // AddTorrentBtn
            // 
            this.AddTorrentBtn.Location = new System.Drawing.Point(206, 492);
            this.AddTorrentBtn.Name = "AddTorrentBtn";
            this.AddTorrentBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTorrentBtn.TabIndex = 7;
            this.AddTorrentBtn.Text = "Add torrent";
            this.AddTorrentBtn.UseVisualStyleBackColor = true;
            this.AddTorrentBtn.Click += new System.EventHandler(this.AddTorrentBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(287, 492);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TorrentStructureTreeView);
            this.groupBox3.Controls.Add(this.Commentlbl);
            this.groupBox3.Controls.Add(this.Hashlbl);
            this.groupBox3.Controls.Add(this.Datelbl);
            this.groupBox3.Controls.Add(this.Sizelbl);
            this.groupBox3.Location = new System.Drawing.Point(12, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 302);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Torrent information";
            // 
            // TorrentStructureTreeView
            // 
            this.TorrentStructureTreeView.Location = new System.Drawing.Point(6, 71);
            this.TorrentStructureTreeView.Name = "TorrentStructureTreeView";
            this.TorrentStructureTreeView.Size = new System.Drawing.Size(338, 220);
            this.TorrentStructureTreeView.TabIndex = 4;
            // 
            // Commentlbl
            // 
            this.Commentlbl.AutoSize = true;
            this.Commentlbl.Location = new System.Drawing.Point(8, 55);
            this.Commentlbl.Name = "Commentlbl";
            this.Commentlbl.Size = new System.Drawing.Size(54, 13);
            this.Commentlbl.TabIndex = 3;
            this.Commentlbl.Text = "Comment:";
            // 
            // Hashlbl
            // 
            this.Hashlbl.AutoSize = true;
            this.Hashlbl.Location = new System.Drawing.Point(8, 42);
            this.Hashlbl.Name = "Hashlbl";
            this.Hashlbl.Size = new System.Drawing.Size(35, 13);
            this.Hashlbl.TabIndex = 2;
            this.Hashlbl.Text = "Hash:";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Location = new System.Drawing.Point(8, 29);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(33, 13);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "Date:";
            // 
            // Sizelbl
            // 
            this.Sizelbl.AutoSize = true;
            this.Sizelbl.Location = new System.Drawing.Point(8, 16);
            this.Sizelbl.Name = "Sizelbl";
            this.Sizelbl.Size = new System.Drawing.Size(30, 13);
            this.Sizelbl.TabIndex = 0;
            this.Sizelbl.Text = "Size:";
            // 
            // AddTorrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddTorrentBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddTorrent";
            this.Text = "AddTorrent";
            this.Load += new System.EventHandler(this.AddTorrent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SavePathAsDefault;
        private System.Windows.Forms.ComboBox SavePathComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoriesComboBox;
        private System.Windows.Forms.Button AddTorrentBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox SaveCategoryAsDefautl;
        private System.Windows.Forms.Label Sizelbl;
        private System.Windows.Forms.Label Hashlbl;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label Commentlbl;
        private System.Windows.Forms.TreeView TorrentStructureTreeView;
    }
}