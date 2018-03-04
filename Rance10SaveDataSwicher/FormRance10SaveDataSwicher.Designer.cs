namespace Rance10SaveDataSwicher
{
    partial class FormRance10SaveDataSwicher
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSaveDataDir = new System.Windows.Forms.TextBox();
            this.btnSaveDataDirRef = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBackupDir = new System.Windows.Forms.ListBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtBackupDirName = new System.Windows.Forms.TextBox();
            this.btnNow = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSaveDataDir);
            this.groupBox1.Controls.Add(this.btnSaveDataDirRef);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // txtSaveDataDir
            // 
            this.txtSaveDataDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveDataDir.Location = new System.Drawing.Point(179, 12);
            this.txtSaveDataDir.Name = "txtSaveDataDir";
            this.txtSaveDataDir.ReadOnly = true;
            this.txtSaveDataDir.Size = new System.Drawing.Size(368, 19);
            this.txtSaveDataDir.TabIndex = 2;
            // 
            // btnSaveDataDirRef
            // 
            this.btnSaveDataDirRef.Location = new System.Drawing.Point(98, 12);
            this.btnSaveDataDirRef.Name = "btnSaveDataDirRef";
            this.btnSaveDataDirRef.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDataDirRef.TabIndex = 1;
            this.btnSaveDataDirRef.Text = "Ref";
            this.btnSaveDataDirRef.UseVisualStyleBackColor = true;
            this.btnSaveDataDirRef.Click += new System.EventHandler(this.btnSaveDataDirRef_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SaveDataFolder";
            // 
            // lstBackupDir
            // 
            this.lstBackupDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstBackupDir.FormattingEnabled = true;
            this.lstBackupDir.ItemHeight = 12;
            this.lstBackupDir.Location = new System.Drawing.Point(12, 68);
            this.lstBackupDir.Name = "lstBackupDir";
            this.lstBackupDir.Size = new System.Drawing.Size(173, 184);
            this.lstBackupDir.TabIndex = 1;
            this.lstBackupDir.DoubleClick += new System.EventHandler(this.lstBackupDir_DoubleClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(191, 68);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "<- Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(191, 132);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "-> Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtBackupDirName
            // 
            this.txtBackupDirName.Location = new System.Drawing.Point(321, 68);
            this.txtBackupDirName.Name = "txtBackupDirName";
            this.txtBackupDirName.Size = new System.Drawing.Size(238, 19);
            this.txtBackupDirName.TabIndex = 4;
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(272, 68);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(43, 23);
            this.btnNow.TabIndex = 5;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(191, 97);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 6;
            this.btnMove.Text = "<- Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // FormRance10SaveDataSwicher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 261);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.txtBackupDirName);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lstBackupDir);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRance10SaveDataSwicher";
            this.Text = "Rance10SaveDataSwicher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSaveDataDir;
        private System.Windows.Forms.Button btnSaveDataDirRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBackupDir;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtBackupDirName;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnMove;
    }
}

