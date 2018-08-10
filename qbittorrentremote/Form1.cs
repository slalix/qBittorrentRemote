using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qbittorrentremote
{
    public partial class Form1 : Form
    {
        string StatusFilter = "all";
        string CategoryFilter = "";
        string SID = "";
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            VersionStatusLabel.Text = await WebWorker.GetqBitTorrentVersion();

            SID = WebWorker.Auth("login", "password");
            List<WebUITorrent> WebUITorrentList = await WebWorker.GetTorrentListAsync(SID, StatusFilter, CategoryFilter);

            FillTorrentGridView(WebUITorrentList);

            List<string> CategoriesList = WebWorker.GetCategories();

            foreach (string Category in CategoriesList)
                CategoryListBox.Items.Add(Category);

            //TorrentStatusUpdateTimer.Start();
        }
        
        private async void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TorrentListGridView.Rows.Clear();
            StatusFilter = StatusListBox.SelectedItem.ToString();

            List<WebUITorrent> WebUITorrentList = await WebWorker.GetTorrentListAsync(SID, StatusFilter, CategoryFilter);

            FillTorrentGridView(WebUITorrentList);
        }

        private void FillTorrentGridView(List<WebUITorrent> webUITorrentList)
        {
            foreach (WebUITorrent Torrent in webUITorrentList)
            {
                if (Torrent.Progress.Contains("E"))
                    continue;
                
                TorrentListGridView.Rows.Add(Torrent.Name,
                                             SizeConverter.SizeSuffix(Convert.ToInt64(Torrent.Size)),
                                             Convert.ToInt32(Math.Round(Convert.ToDouble(Torrent.Progress) * 100)),
                                             Torrent.State,
                                             Torrent.Num_seeds,
                                             Torrent.Num_leechs,
                                             SizeConverter.SizeSuffix(Convert.ToInt64(Torrent.Dlspeed))+"/s",
                                             SizeConverter.SizeSuffix(Convert.ToInt64(Torrent.Upspeed)) + "/s",
                                             SizeConverter.SizeSuffix(Convert.ToInt64(Torrent.Uploaded)),
                                             Torrent.Seen_complete,
                                             Torrent.Category,
                                             Torrent.Save_path);
            }
        }

        private void addTorrentFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TorrentFilePath = "";
            if (OpenTorrentFileDialog.ShowDialog() == DialogResult.OK)
                TorrentFilePath = OpenTorrentFileDialog.FileName;
            else
                return;


            
            AddTorrent AddTorrentDialog = new AddTorrent();
            AddTorrentDialog.TorrentFilePath = TorrentFilePath;


            if (AddTorrentDialog.ShowDialog(this) == DialogResult.OK)
            {
                Console.WriteLine(AddTorrentDialog.TorrentFilePath);
                Console.WriteLine(AddTorrentDialog.SavePathResult);
                Console.WriteLine(AddTorrentDialog.CategoryResult);
            }
            AddTorrentDialog.Dispose();
        }

        private async void CategoriesListBox_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            TorrentListGridView.Rows.Clear();
            CategoryFilter = CategoryListBox.SelectedItem.ToString();

            List<WebUITorrent> WebUITorrentList = await WebWorker.GetTorrentListAsync(SID, StatusFilter, CategoryFilter);

            FillTorrentGridView(WebUITorrentList);
        }

        private async void TorrentStatusUpdateTimer_TickAsync(object sender, EventArgs e)
        {
            List<WebUITorrent> WebUITorrentList = await WebWorker.GetTorrentListAsync(SID, StatusFilter, CategoryFilter);
            TorrentListGridView.Rows.Clear();
            FillTorrentGridView(WebUITorrentList);
        }
    }
}
