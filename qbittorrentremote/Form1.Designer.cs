namespace qbittorrentremote
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTorrentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusLine = new System.Windows.Forms.StatusStrip();
            this.VersionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusListBox = new System.Windows.Forms.ListBox();
            this.TorrentListGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new qbittorrentremote.DataGridViewProgressColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seeds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlspeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upspeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timecompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.OpenTorrentFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TorrentStatusUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.StatusLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TorrentListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTorrentFileToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // addTorrentFileToolStripMenuItem
            // 
            this.addTorrentFileToolStripMenuItem.Name = "addTorrentFileToolStripMenuItem";
            this.addTorrentFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTorrentFileToolStripMenuItem.Text = "Add torrent file";
            this.addTorrentFileToolStripMenuItem.Click += new System.EventHandler(this.addTorrentFileToolStripMenuItem_Click);
            // 
            // StatusLine
            // 
            this.StatusLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionStatusLabel});
            this.StatusLine.Location = new System.Drawing.Point(0, 428);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(800, 22);
            this.StatusLine.TabIndex = 1;
            this.StatusLine.Text = "StatusLine";
            // 
            // VersionStatusLabel
            // 
            this.VersionStatusLabel.Name = "VersionStatusLabel";
            this.VersionStatusLabel.Size = new System.Drawing.Size(785, 17);
            this.VersionStatusLabel.Spring = true;
            this.VersionStatusLabel.ToolTipText = "qBittorrent version";
            // 
            // StatusListBox
            // 
            this.StatusListBox.FormattingEnabled = true;
            this.StatusListBox.Items.AddRange(new object[] {
            "All",
            "Downloading",
            "Completed",
            "Paused",
            "Active",
            "Inactive"});
            this.StatusListBox.Location = new System.Drawing.Point(0, 27);
            this.StatusListBox.Name = "StatusListBox";
            this.StatusListBox.Size = new System.Drawing.Size(103, 82);
            this.StatusListBox.TabIndex = 2;
            this.StatusListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // TorrentListGridView
            // 
            this.TorrentListGridView.AllowUserToAddRows = false;
            this.TorrentListGridView.AllowUserToDeleteRows = false;
            this.TorrentListGridView.AllowUserToResizeRows = false;
            this.TorrentListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TorrentListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TorrentListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.size,
            this.progress,
            this.status,
            this.seeds,
            this.peers,
            this.dlspeed,
            this.upspeed,
            this.shared,
            this.timecompleted,
            this.category,
            this.save_path});
            this.TorrentListGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.TorrentListGridView.Location = new System.Drawing.Point(109, 24);
            this.TorrentListGridView.Name = "TorrentListGridView";
            this.TorrentListGridView.RowHeadersVisible = false;
            this.TorrentListGridView.Size = new System.Drawing.Size(691, 404);
            this.TorrentListGridView.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 60;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.Width = 52;
            // 
            // progress
            // 
            this.progress.HeaderText = "Progress";
            this.progress.Name = "progress";
            this.progress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.progress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.progress.Width = 73;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Width = 62;
            // 
            // seeds
            // 
            this.seeds.HeaderText = "Seeds";
            this.seeds.Name = "seeds";
            this.seeds.Width = 62;
            // 
            // peers
            // 
            this.peers.HeaderText = "Peers";
            this.peers.Name = "peers";
            this.peers.Width = 59;
            // 
            // dlspeed
            // 
            this.dlspeed.HeaderText = "Download speed";
            this.dlspeed.Name = "dlspeed";
            this.dlspeed.Width = 103;
            // 
            // upspeed
            // 
            this.upspeed.HeaderText = "Upload speed";
            this.upspeed.Name = "upspeed";
            this.upspeed.Width = 90;
            // 
            // shared
            // 
            this.shared.HeaderText = "Shared";
            this.shared.Name = "shared";
            this.shared.Width = 66;
            // 
            // timecompleted
            // 
            this.timecompleted.HeaderText = "Time completed";
            this.timecompleted.Name = "timecompleted";
            this.timecompleted.Width = 98;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.Width = 74;
            // 
            // save_path
            // 
            this.save_path.HeaderText = "Save path";
            this.save_path.Name = "save_path";
            this.save_path.Width = 75;
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Location = new System.Drawing.Point(0, 115);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(103, 212);
            this.CategoryListBox.TabIndex = 4;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesListBox_SelectedIndexChangedAsync);
            // 
            // OpenTorrentFileDialog
            // 
            this.OpenTorrentFileDialog.Filter = "Torrent Files (*.torrent)|*.torrent";
            // 
            // TorrentStatusUpdateTimer
            // 
            this.TorrentStatusUpdateTimer.Interval = 1000;
            this.TorrentStatusUpdateTimer.Tick += new System.EventHandler(this.TorrentStatusUpdateTimer_TickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryListBox);
            this.Controls.Add(this.TorrentListGridView);
            this.Controls.Add(this.StatusListBox);
            this.Controls.Add(this.StatusLine);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusLine.ResumeLayout(false);
            this.StatusLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TorrentListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusLine;
        private System.Windows.Forms.ToolStripStatusLabel VersionStatusLabel;
        private System.Windows.Forms.ListBox StatusListBox;
        private System.Windows.Forms.DataGridView TorrentListGridView;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.ToolStripMenuItem addTorrentFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenTorrentFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private DataGridViewProgressColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn seeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn peers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlspeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn upspeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn shared;
        private System.Windows.Forms.DataGridViewTextBoxColumn timecompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn save_path;
        private System.Windows.Forms.Timer TorrentStatusUpdateTimer;
    }
}

