namespace SIS_Renamer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxSisFiles = new System.Windows.Forms.ListBox();
            this.listBoxNewNames = new System.Windows.Forms.ListBox();
            this.buttonRenameFiles = new System.Windows.Forms.Button();
            this.showAppUID = new System.Windows.Forms.CheckBox();
            this.onlyFileName = new System.Windows.Forms.CheckBox();
            this.showVendorName = new System.Windows.Forms.CheckBox();
            this.showVersionInfo = new System.Windows.Forms.CheckBox();
            this.fileNamePrefixTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.showAppType = new System.Windows.Forms.CheckBox();
            this.showSupportedDevices = new System.Windows.Forms.CheckBox();
            this.showInstallationType = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.sisNamingTemplateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.useNamingTemplateCheckBox = new System.Windows.Forms.CheckBox();
            this.previewNames = new System.Windows.Forms.Button();
            this.buttonResetListboxes = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSisFiles
            // 
            this.listBoxSisFiles.AllowDrop = true;
            this.listBoxSisFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSisFiles.FormattingEnabled = true;
            this.listBoxSisFiles.ItemHeight = 12;
            this.listBoxSisFiles.Location = new System.Drawing.Point(6, 18);
            this.listBoxSisFiles.Name = "listBoxSisFiles";
            this.listBoxSisFiles.Size = new System.Drawing.Size(439, 280);
            this.listBoxSisFiles.TabIndex = 0;
            this.listBoxSisFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxSisFiles_DragDrop);
            this.listBoxSisFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxSisFiles_DragEnter);
            // 
            // listBoxNewNames
            // 
            this.listBoxNewNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNewNames.FormattingEnabled = true;
            this.listBoxNewNames.ItemHeight = 12;
            this.listBoxNewNames.Location = new System.Drawing.Point(452, 18);
            this.listBoxNewNames.Name = "listBoxNewNames";
            this.listBoxNewNames.Size = new System.Drawing.Size(378, 280);
            this.listBoxNewNames.TabIndex = 1;
            this.listBoxNewNames.DoubleClick += new System.EventHandler(this.listBoxNewNames_DoubleClick);
            // 
            // buttonRenameFiles
            // 
            this.buttonRenameFiles.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRenameFiles.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRenameFiles.ForeColor = System.Drawing.Color.Snow;
            this.buttonRenameFiles.Location = new System.Drawing.Point(858, 370);
            this.buttonRenameFiles.Name = "buttonRenameFiles";
            this.buttonRenameFiles.Size = new System.Drawing.Size(179, 36);
            this.buttonRenameFiles.TabIndex = 2;
            this.buttonRenameFiles.Text = "Rename Files";
            this.buttonRenameFiles.UseVisualStyleBackColor = false;
            this.buttonRenameFiles.Click += new System.EventHandler(this.buttonRenameFiles_Click);
            // 
            // showAppUID
            // 
            this.showAppUID.AutoSize = true;
            this.showAppUID.Location = new System.Drawing.Point(6, 67);
            this.showAppUID.Name = "showAppUID";
            this.showAppUID.Size = new System.Drawing.Size(97, 17);
            this.showAppUID.TabIndex = 3;
            this.showAppUID.Text = "Show App UID";
            this.showAppUID.UseVisualStyleBackColor = true;
            // 
            // onlyFileName
            // 
            this.onlyFileName.AutoSize = true;
            this.onlyFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyFileName.ForeColor = System.Drawing.Color.Red;
            this.onlyFileName.Location = new System.Drawing.Point(6, 160);
            this.onlyFileName.Name = "onlyFileName";
            this.onlyFileName.Size = new System.Drawing.Size(146, 17);
            this.onlyFileName.TabIndex = 4;
            this.onlyFileName.Text = "Only File Name Mode";
            this.onlyFileName.UseVisualStyleBackColor = true;
            this.onlyFileName.CheckedChanged += new System.EventHandler(this.onlyFileName_CheckedChanged);
            // 
            // showVendorName
            // 
            this.showVendorName.AutoSize = true;
            this.showVendorName.Location = new System.Drawing.Point(6, 44);
            this.showVendorName.Name = "showVendorName";
            this.showVendorName.Size = new System.Drawing.Size(121, 17);
            this.showVendorName.TabIndex = 5;
            this.showVendorName.Text = "Show Vendor Name";
            this.showVendorName.UseVisualStyleBackColor = true;
            // 
            // showVersionInfo
            // 
            this.showVersionInfo.AutoSize = true;
            this.showVersionInfo.Checked = true;
            this.showVersionInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showVersionInfo.Location = new System.Drawing.Point(6, 21);
            this.showVersionInfo.Name = "showVersionInfo";
            this.showVersionInfo.Size = new System.Drawing.Size(112, 17);
            this.showVersionInfo.TabIndex = 6;
            this.showVersionInfo.Text = "Show Version Info";
            this.showVersionInfo.UseVisualStyleBackColor = true;
            // 
            // fileNamePrefixTextBox
            // 
            this.fileNamePrefixTextBox.Location = new System.Drawing.Point(6, 18);
            this.fileNamePrefixTextBox.Name = "fileNamePrefixTextBox";
            this.fileNamePrefixTextBox.Size = new System.Drawing.Size(152, 20);
            this.fileNamePrefixTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(858, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 266);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renaming Settings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.showAppType);
            this.groupBox5.Controls.Add(this.showSupportedDevices);
            this.groupBox5.Controls.Add(this.showInstallationType);
            this.groupBox5.Controls.Add(this.onlyFileName);
            this.groupBox5.Controls.Add(this.showVersionInfo);
            this.groupBox5.Controls.Add(this.showVendorName);
            this.groupBox5.Controls.Add(this.showAppUID);
            this.groupBox5.Location = new System.Drawing.Point(7, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(166, 192);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "What to include in name:";
            // 
            // showAppType
            // 
            this.showAppType.AutoSize = true;
            this.showAppType.Checked = true;
            this.showAppType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAppType.Location = new System.Drawing.Point(6, 137);
            this.showAppType.Name = "showAppType";
            this.showAppType.Size = new System.Drawing.Size(102, 17);
            this.showAppType.TabIndex = 12;
            this.showAppType.Text = "Show App Type";
            this.showAppType.UseVisualStyleBackColor = true;
            // 
            // showSupportedDevices
            // 
            this.showSupportedDevices.AutoSize = true;
            this.showSupportedDevices.Checked = true;
            this.showSupportedDevices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSupportedDevices.Location = new System.Drawing.Point(6, 114);
            this.showSupportedDevices.Name = "showSupportedDevices";
            this.showSupportedDevices.Size = new System.Drawing.Size(147, 17);
            this.showSupportedDevices.TabIndex = 11;
            this.showSupportedDevices.Text = "Show Supported Devices";
            this.showSupportedDevices.UseVisualStyleBackColor = true;
            // 
            // showInstallationType
            // 
            this.showInstallationType.AutoSize = true;
            this.showInstallationType.Location = new System.Drawing.Point(6, 90);
            this.showInstallationType.Name = "showInstallationType";
            this.showInstallationType.Size = new System.Drawing.Size(133, 17);
            this.showInstallationType.TabIndex = 10;
            this.showInstallationType.Text = "Show Installation Type";
            this.showInstallationType.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fileNamePrefixTextBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 44);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prefix for file names:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAddDir);
            this.groupBox3.Controls.Add(this.buttonAddFiles);
            this.groupBox3.Controls.Add(this.listBoxNewNames);
            this.groupBox3.Controls.Add(this.listBoxSisFiles);
            this.groupBox3.Location = new System.Drawing.Point(14, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(838, 343);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SIS Files";
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(6, 311);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(87, 23);
            this.buttonAddFiles.TabIndex = 2;
            this.buttonAddFiles.Text = "Add files ...";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // sisNamingTemplateTextBox
            // 
            this.sisNamingTemplateTextBox.Enabled = false;
            this.sisNamingTemplateTextBox.Location = new System.Drawing.Point(6, 18);
            this.sisNamingTemplateTextBox.Name = "sisNamingTemplateTextBox";
            this.sisNamingTemplateTextBox.Size = new System.Drawing.Size(672, 20);
            this.sisNamingTemplateTextBox.TabIndex = 11;
            this.sisNamingTemplateTextBox.Text = "{name} - {version} - {vendor} - {uid} - {install_type} - {supported_devices}{app_" +
    "type}.sis{x}";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.useNamingTemplateCheckBox);
            this.groupBox6.Controls.Add(this.sisNamingTemplateTextBox);
            this.groupBox6.Location = new System.Drawing.Point(14, 362);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(838, 44);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Use Naming Template (overwrites all other settings):";
            // 
            // useNamingTemplateCheckBox
            // 
            this.useNamingTemplateCheckBox.AutoSize = true;
            this.useNamingTemplateCheckBox.Location = new System.Drawing.Point(685, 21);
            this.useNamingTemplateCheckBox.Name = "useNamingTemplateCheckBox";
            this.useNamingTemplateCheckBox.Size = new System.Drawing.Size(131, 17);
            this.useNamingTemplateCheckBox.TabIndex = 12;
            this.useNamingTemplateCheckBox.Text = "Use Naming Template";
            this.useNamingTemplateCheckBox.UseVisualStyleBackColor = true;
            this.useNamingTemplateCheckBox.CheckedChanged += new System.EventHandler(this.disableNamingTemplateCheckBox_CheckedChanged);
            // 
            // previewNames
            // 
            this.previewNames.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewNames.Location = new System.Drawing.Point(858, 327);
            this.previewNames.Name = "previewNames";
            this.previewNames.Size = new System.Drawing.Size(179, 36);
            this.previewNames.TabIndex = 11;
            this.previewNames.Text = "Preview Names";
            this.previewNames.UseVisualStyleBackColor = true;
            this.previewNames.Click += new System.EventHandler(this.previewNames_Click);
            // 
            // buttonResetListboxes
            // 
            this.buttonResetListboxes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetListboxes.Location = new System.Drawing.Point(858, 285);
            this.buttonResetListboxes.Name = "buttonResetListboxes";
            this.buttonResetListboxes.Size = new System.Drawing.Size(179, 36);
            this.buttonResetListboxes.TabIndex = 12;
            this.buttonResetListboxes.Text = "Reset Listboxes";
            this.buttonResetListboxes.UseVisualStyleBackColor = true;
            this.buttonResetListboxes.Click += new System.EventHandler(this.clearBothListboxes);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "SIS(X) files|*.sis;*.sisx";
            this.openFileDialog1.Multiselect = true;
            // 
            // buttonAddDir
            // 
            this.buttonAddDir.Location = new System.Drawing.Point(109, 311);
            this.buttonAddDir.Name = "buttonAddDir";
            this.buttonAddDir.Size = new System.Drawing.Size(124, 23);
            this.buttonAddDir.TabIndex = 3;
            this.buttonAddDir.Text = "Add directory ...";
            this.buttonAddDir.UseVisualStyleBackColor = true;
            this.buttonAddDir.Click += new System.EventHandler(this.buttonAddDir_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 414);
            this.Controls.Add(this.buttonResetListboxes);
            this.Controls.Add(this.previewNames);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.buttonRenameFiles);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SIS File Renamer by Nuru TaşDemir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSisFiles;
        private System.Windows.Forms.ListBox listBoxNewNames;
        private System.Windows.Forms.Button buttonRenameFiles;
        private System.Windows.Forms.CheckBox showAppUID;
        private System.Windows.Forms.CheckBox onlyFileName;
        private System.Windows.Forms.CheckBox showVendorName;
        private System.Windows.Forms.CheckBox showVersionInfo;
        private System.Windows.Forms.TextBox fileNamePrefixTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox showInstallationType;
        private System.Windows.Forms.CheckBox showSupportedDevices;
        private System.Windows.Forms.TextBox sisNamingTemplateTextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox useNamingTemplateCheckBox;
        private System.Windows.Forms.Button previewNames;
        private System.Windows.Forms.CheckBox showAppType;
        private System.Windows.Forms.Button buttonResetListboxes;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonAddDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

