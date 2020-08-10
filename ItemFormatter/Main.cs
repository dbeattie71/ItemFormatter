using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ItemFormatter.Common;
using ItemFormatter.Models;
using Microsoft.Extensions.Options;

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

        private string getClipboard()
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

        private void uxBonusesPathLinkLabel_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                Filter = "xml files (*.xml)|*.xml",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(openFileDialog.FileName)) return;

            uxBonusesPathLinkLabel.Text = openFileDialog.FileName;
            Properties.Settings.Default["BonusesPath"] = openFileDialog.FileName;
            Properties.Settings.Default.Save();
        }

        private void uxSavePathLinkLabel_Click(object sender, EventArgs e)
        {
            using var folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();

            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath)) return;
            uxSavePathLinkLabel.Text = folderBrowserDialog.SelectedPath;
            Properties.Settings.Default["SavePath"] = folderBrowserDialog.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void uxChatLogPathLinkLabel_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "log files (*.log)|*.log",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(openFileDialog.FileName)) return;

            uxChatLogPathLinkLabel.Text = openFileDialog.FileName;
            Properties.Settings.Default["ChatLogPath"] = openFileDialog.FileName;
            Properties.Settings.Default.Save();
        }

        private void uxSaveItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                var mapper = new Mapper(Properties.Settings.Default["BonusesPath"].ToString());

                var clipBoard = getClipboard();
                //validate

                mapper.SaveScItem(clipBoard, Properties.Settings.Default["SavePath"].ToString());

                //
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void uxImportItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                var chatLogParser = new ChatLogParser();
                var mostRecentItem = chatLogParser.GetMostRecentItem(Properties.Settings.Default["ChatLogPath"].ToString());

                var mapper = new Mapper(Properties.Settings.Default["BonusesPath"].ToString());

                var clipBoard = getClipboard();
                //validate

                mapper.SaveScItem(clipBoard, Properties.Settings.Default["SavePath"].ToString());

                //
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        
    }
}