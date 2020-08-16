using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ItemFormatter.Common;

namespace ItemFormatter
{
    public partial class Main : Form
    {
        //public Main(IServiceProvider serviceProvider,
        //    IOptions<AppSettings> settings)
        //{
        //    InitializeComponent();
        //}

        public Main()
        {
            InitializeComponent();
        }



        private void Main_Load(object sender, EventArgs e)
        {
            var bonusesPath = Properties.Settings.Default["BonusesPath"].ToString();
            uxBonusesPathLinkLabel.Text = string.IsNullOrEmpty(bonusesPath)
                ? Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
                : bonusesPath;

            var savePath = Properties.Settings.Default["SavePath"].ToString();
            uxSavePathLinkLabel.Text = string.IsNullOrEmpty(savePath)
                ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                : savePath;

            var chatLogPath = Properties.Settings.Default["ChatLogPath"].ToString();
            uxChatLogPathLinkLabel.Text = string.IsNullOrEmpty(chatLogPath)
                ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                : chatLogPath;
        }

        private void uxBonusesPathButton_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                Filter = "xml files (*.xml)|*.xml",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK ||
                string.IsNullOrWhiteSpace(openFileDialog.FileName)) return;

            uxBonusesPathLinkLabel.Text = openFileDialog.FileName;
            Properties.Settings.Default["BonusesPath"] = openFileDialog.FileName;
            Properties.Settings.Default.Save();
        }

        private void uxBonusesPathLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFolder(Path.GetDirectoryName(uxBonusesPathLinkLabel.Text));
        }

        private void uxChatLogButton_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "log files (*.log)|*.log",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK ||
                string.IsNullOrWhiteSpace(openFileDialog.FileName)) return;

            uxChatLogPathLinkLabel.Text = openFileDialog.FileName;
            Properties.Settings.Default["ChatLogPath"] = openFileDialog.FileName;
            Properties.Settings.Default.Save();
        }

        private void uxChatLogPathLinkLabel_Click(object sender, EventArgs e)
        {
            OpenFolder(uxChatLogPathLinkLabel.Text);
        }

        private void uxSavePathButton_Click(object sender, EventArgs e)
        {
            using var folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();

            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath)) return;
            uxSavePathLinkLabel.Text = folderBrowserDialog.SelectedPath;
            Properties.Settings.Default["SavePath"] = folderBrowserDialog.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void uxSavePathLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFolder(uxSavePathLinkLabel.Text);
        }

        private void uxSaveItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                var bonusListHelper = new BonusListHelper(Properties.Settings.Default["BonusesPath"].ToString());
                var mapper = new Mapper(bonusListHelper);

                var clipBoard = GetClipboard();

                //validate

                mapper.SaveScItem(clipBoard, Properties.Settings.Default["SavePath"].ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private string GetClipboard()
        {
            string result = null;
            var iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text))
            {
                result = iData.GetData(DataFormats.Text) as string;
            }

            Clipboard.Clear();

            return result;
        }

        private void uxImportItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                var chatLogParser = new ChatLogParser();
                var mostRecentItem =
                    chatLogParser.GetMostRecentItem(Properties.Settings.Default["ChatLogPath"].ToString());

                var bonusListHelper = new BonusListHelper(Properties.Settings.Default["BonusesPath"].ToString());
                var mapper = new Mapper(bonusListHelper);

                //validate

                mapper.SaveScItem(mostRecentItem, Properties.Settings.Default["SavePath"].ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void OpenFolder(string folderPath)
        {
            var path = Path.GetDirectoryName(folderPath);

            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show($"{folderPath} Directory does not exist!");
            }
        }
    }
}