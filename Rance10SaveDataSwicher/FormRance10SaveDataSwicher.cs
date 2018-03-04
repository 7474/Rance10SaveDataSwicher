using Rance10SaveDataSwicher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rance10SaveDataSwicher
{
    public partial class FormRance10SaveDataSwicher : Form
    {
        string SaveDataDir
        {
            get { return txtSaveDataDir.Text; }
            set
            {
                txtSaveDataDir.Text = value;
                Settings.Default.SaveDataDir = txtSaveDataDir.Text;
                Settings.Default.Save();
            }
        }
        string BackupName
        {
            get { return txtBackupDirName.Text; }
            set
            {
                txtBackupDirName.Text = value;
            }
        }

        public FormRance10SaveDataSwicher()
        {
            InitializeComponent();

            string dir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                @"AliceSoft\ランス１０\SaveData");

            if (!string.IsNullOrEmpty(Settings.Default.SaveDataDir))
            {
                dir = Settings.Default.SaveDataDir;
            }
            SaveDataDir = dir;
            refreshBackupDir();
        }

        private void btnSaveDataDirRef_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                fbd.SelectedPath = txtSaveDataDir.Text;
                fbd.ShowNewFolderButton = true;

                if (fbd.ShowDialog(this) == DialogResult.OK)
                {
                    SaveDataDir = fbd.SelectedPath;
                }
            }
        }

        private void refreshBackupDir()
        {
            lstBackupDir.DisplayMember = "Name";
            lstBackupDir.ValueMember = "FullName";
            lstBackupDir.DataSource = GetBackupDirs(SaveDataDir);
            BackupName = "bk" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            refreshBackupDir();
        }

        private void lstBackupDir_DoubleClick(object sender, EventArgs e)
        {
            //Process.Start("EXPLORER.EXE", lstBackupDir.SelectedValue as string);
            BackupName = lstBackupDir.Text;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupInternal(false);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            BackupInternal(true);
        }

        private void BackupInternal(bool isMove)
        {
            if (string.IsNullOrEmpty(BackupName))
            {
                MessageBox.Show("バックアップフォルダ名が空です。");
                return;
            }
            var buckupDir = Path.Combine(SaveDataDir, BackupName);
            if (Directory.Exists(buckupDir))
            {
                if (MessageBox.Show(
                    "バックアップフォルダが存在します。上書きしてよろしいですか？",
                    "確認",
                    MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }
            }
            Directory.CreateDirectory(buckupDir);
            if (isMove)
            {
                GetSaveDataFiles(SaveDataDir).ToList().ForEach(x => x.MoveTo(Path.Combine(buckupDir, x.Name)));
                GetSaveDataThumbnailFiles(SaveDataDir).ToList().ForEach(x => x.MoveTo(Path.Combine(buckupDir, x.Name)));
            }
            else
            {
                GetSaveDataFiles(SaveDataDir).ToList().ForEach(x => x.CopyTo(Path.Combine(buckupDir, x.Name), true));
                GetSaveDataThumbnailFiles(SaveDataDir).ToList().ForEach(x => x.CopyTo(Path.Combine(buckupDir, x.Name), true));
            }
            refreshBackupDir();
            MessageBox.Show("バックアップしました。");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            var backupDirPath = lstBackupDir.SelectedValue as string;
            if (string.IsNullOrEmpty(backupDirPath))
            {
                MessageBox.Show("バックアップフォルダが選択されていません。");
                return;
            }

            if (GetSaveDataFiles(SaveDataDir).Any())
            {
                if (MessageBox.Show(
                    "セーブデータが存在します。上書きしてよろしいですか？",
                    "確認",
                    MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }
            }
            var backupDir = new DirectoryInfo(backupDirPath);
            backupDir.GetFiles().ToList().ForEach(x => x.CopyTo(Path.Combine(SaveDataDir, x.Name), true));
            MessageBox.Show("レストアしました。");
        }

        private Regex LocalSaveFilePattern = new Regex("^LocalSave[0-9]{2}.asd$");
        private Regex LocalSaveThumbnailFilePattern = new Regex("^Thumb00[0-9]{2}.qnt");
        private IEnumerable<FileInfo> GetSaveDataFiles(string dirPath)
        {
            var dirInfo = new DirectoryInfo(dirPath);
            return dirInfo.GetFiles("*.asd").Where(x => LocalSaveFilePattern.IsMatch(x.Name));
        }
        private IEnumerable<FileInfo> GetSaveDataThumbnailFiles(string dirPath)
        {
            var dirInfo = new DirectoryInfo(dirPath);
            return dirInfo.GetFiles("*.qnt").Where(x => LocalSaveThumbnailFilePattern.IsMatch(x.Name));
        }
        private IEnumerable<DirectoryInfo> GetBackupDirs(string dirPath)
        {
            var dirInfo = new DirectoryInfo(dirPath);
            return dirInfo.GetDirectories();
        }

    }
}
