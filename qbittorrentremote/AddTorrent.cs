using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BencodeNET.Parsing;
using BencodeNET.Torrents;

namespace qbittorrentremote
{
    public partial class AddTorrent : Form
    {
        public string TorrentFilePath { get; set; }

        public string SavePathResult { get; set; }
        public string CategoryResult { get; set; }

        public AddTorrent()
        {
            InitializeComponent();
        }

        private void AddTorrent_Load(object sender, EventArgs e)
        {
            List<string> SavePathsList = WebWorker.GetSavePaths();
            foreach (string SavePath in SavePathsList)
                SavePathComboBox.Items.Add(SavePath);

            if (Properties.Settings.Default.DefaultSavePath == String.Empty)
                SavePathComboBox.Text = SavePathsList[0];
            else
                SavePathComboBox.Text = Properties.Settings.Default.DefaultSavePath;


            List<string> CategoriesList = WebWorker.GetCategories();
            foreach (string Category in CategoriesList)
                CategoriesComboBox.Items.Add(Category);

            if (Properties.Settings.Default.DefaultCategory != String.Empty)
                CategoriesComboBox.Text = Properties.Settings.Default.DefaultCategory;


            BencodeParser TorrentParser = new BencodeParser();
            Torrent ParsedTorrent = TorrentParser.Parse<Torrent>(TorrentFilePath);

            this.Text = ParsedTorrent.DisplayName;

            Sizelbl.Text = "Size: " + SizeConverter.SizeSuffix(ParsedTorrent.TotalSize);
            Datelbl.Text = "Date: " + ParsedTorrent.CreationDate;
            Hashlbl.Text = "Hash: " + ParsedTorrent.OriginalInfoHash.ToLower();

            /*Uri uriResult;
            if (Uri.TryCreate(ParsedTorrent.Comment, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                Console.WriteLine("LINK");*/

            Commentlbl.Text = "Comment: " + ParsedTorrent.Comment;

            if(ParsedTorrent.File == null)
                Console.WriteLine(ParsedTorrent.Files);
            else if(ParsedTorrent.Files == null)
                Console.WriteLine(ParsedTorrent.File);
        }

        private void AddTorrentBtn_Click(object sender, EventArgs e)
        {
            if (SavePathAsDefault.Checked == true)
            {
                Properties.Settings.Default.DefaultSavePath = SavePathComboBox.Text;
                Properties.Settings.Default.Save();
            }

            if (SaveCategoryAsDefautl.Checked == true)
            {
                Properties.Settings.Default.DefaultCategory = CategoriesComboBox.Text;
                Properties.Settings.Default.Save();
            }

            SavePathResult = SavePathComboBox.Text;
            CategoryResult = CategoriesComboBox.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
       
    }
}
