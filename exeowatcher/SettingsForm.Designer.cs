namespace exeowatcher
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabCntrlSettings = new System.Windows.Forms.TabControl();
            this.tabPgSettingTag = new System.Windows.Forms.TabPage();
            this.groupBoxChooseTag = new System.Windows.Forms.GroupBox();
            this.checkedListBoxTags = new System.Windows.Forms.CheckedListBox();
            this.tabPgProxy = new System.Windows.Forms.TabPage();
            this.btnSettingsRemoveAll = new System.Windows.Forms.Button();
            this.btnSettingsOfFile = new System.Windows.Forms.Button();
            this.btnSettingsOfBuffer = new System.Windows.Forms.Button();
            this.groupBoxProxy = new System.Windows.Forms.GroupBox();
            this.listViewProxy = new System.Windows.Forms.ListView();
            this.columnIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSettingsOk = new System.Windows.Forms.Button();
            this.btnSettingsCancel = new System.Windows.Forms.Button();
            this.radioBtnHTTP = new System.Windows.Forms.RadioButton();
            this.radioBtnSocks4 = new System.Windows.Forms.RadioButton();
            this.radioBtnSocks5 = new System.Windows.Forms.RadioButton();
            this.lblProxyType = new System.Windows.Forms.Label();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.tabCntrlSettings.SuspendLayout();
            this.tabPgSettingTag.SuspendLayout();
            this.groupBoxChooseTag.SuspendLayout();
            this.tabPgProxy.SuspendLayout();
            this.groupBoxProxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCntrlSettings
            // 
            this.tabCntrlSettings.Controls.Add(this.tabPgSettingTag);
            this.tabCntrlSettings.Controls.Add(this.tabPgProxy);
            this.tabCntrlSettings.Location = new System.Drawing.Point(13, 13);
            this.tabCntrlSettings.Name = "tabCntrlSettings";
            this.tabCntrlSettings.SelectedIndex = 0;
            this.tabCntrlSettings.Size = new System.Drawing.Size(364, 322);
            this.tabCntrlSettings.TabIndex = 0;
            this.tabCntrlSettings.SelectedIndexChanged += new System.EventHandler(this.tabCntrlSettings_SelectedIndexChanged);
            // 
            // tabPgSettingTag
            // 
            this.tabPgSettingTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tabPgSettingTag.Controls.Add(this.groupBoxChooseTag);
            this.tabPgSettingTag.Location = new System.Drawing.Point(4, 22);
            this.tabPgSettingTag.Name = "tabPgSettingTag";
            this.tabPgSettingTag.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgSettingTag.Size = new System.Drawing.Size(356, 296);
            this.tabPgSettingTag.TabIndex = 0;
            this.tabPgSettingTag.Text = "Настройка тегов";
            // 
            // groupBoxChooseTag
            // 
            this.groupBoxChooseTag.Controls.Add(this.checkedListBoxTags);
            this.groupBoxChooseTag.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBoxChooseTag.Location = new System.Drawing.Point(7, 7);
            this.groupBoxChooseTag.Name = "groupBoxChooseTag";
            this.groupBoxChooseTag.Size = new System.Drawing.Size(343, 283);
            this.groupBoxChooseTag.TabIndex = 0;
            this.groupBoxChooseTag.TabStop = false;
            this.groupBoxChooseTag.Text = "Выберите тег";
            // 
            // checkedListBoxTags
            // 
            this.checkedListBoxTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.checkedListBoxTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxTags.ForeColor = System.Drawing.Color.DarkGray;
            this.checkedListBoxTags.FormattingEnabled = true;
            this.checkedListBoxTags.Items.AddRange(new object[] {
            "h1",
            "h2",
            "h3",
            "h4",
            "h5",
            "h6",
            "Title",
            "Description",
            "Keywords",
            "Strong",
            "p",
            "b"});
            this.checkedListBoxTags.Location = new System.Drawing.Point(7, 20);
            this.checkedListBoxTags.Name = "checkedListBoxTags";
            this.checkedListBoxTags.Size = new System.Drawing.Size(330, 255);
            this.checkedListBoxTags.TabIndex = 0;
            // 
            // tabPgProxy
            // 
            this.tabPgProxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tabPgProxy.Controls.Add(this.btnSettingsRemoveAll);
            this.tabPgProxy.Controls.Add(this.btnSettingsOfFile);
            this.tabPgProxy.Controls.Add(this.btnSettingsOfBuffer);
            this.tabPgProxy.Controls.Add(this.groupBoxProxy);
            this.tabPgProxy.Location = new System.Drawing.Point(4, 22);
            this.tabPgProxy.Name = "tabPgProxy";
            this.tabPgProxy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgProxy.Size = new System.Drawing.Size(356, 296);
            this.tabPgProxy.TabIndex = 1;
            this.tabPgProxy.Text = "Прокси-сервер";
            // 
            // btnSettingsRemoveAll
            // 
            this.btnSettingsRemoveAll.Location = new System.Drawing.Point(264, 267);
            this.btnSettingsRemoveAll.Name = "btnSettingsRemoveAll";
            this.btnSettingsRemoveAll.Size = new System.Drawing.Size(83, 23);
            this.btnSettingsRemoveAll.TabIndex = 3;
            this.btnSettingsRemoveAll.Text = "Удалить всё";
            this.btnSettingsRemoveAll.UseVisualStyleBackColor = true;
            this.btnSettingsRemoveAll.Click += new System.EventHandler(this.btnSettingsRemoveAll_Click);
            // 
            // btnSettingsOfFile
            // 
            this.btnSettingsOfFile.Location = new System.Drawing.Point(134, 267);
            this.btnSettingsOfFile.Name = "btnSettingsOfFile";
            this.btnSettingsOfFile.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsOfFile.TabIndex = 2;
            this.btnSettingsOfFile.Text = "Из файла";
            this.btnSettingsOfFile.UseVisualStyleBackColor = true;
            this.btnSettingsOfFile.Click += new System.EventHandler(this.btnSettingsOfFile_Click);
            // 
            // btnSettingsOfBuffer
            // 
            this.btnSettingsOfBuffer.Location = new System.Drawing.Point(6, 267);
            this.btnSettingsOfBuffer.Name = "btnSettingsOfBuffer";
            this.btnSettingsOfBuffer.Size = new System.Drawing.Size(83, 23);
            this.btnSettingsOfBuffer.TabIndex = 1;
            this.btnSettingsOfBuffer.Text = "Из буффера";
            this.btnSettingsOfBuffer.UseVisualStyleBackColor = true;
            this.btnSettingsOfBuffer.Click += new System.EventHandler(this.btnSettingsOfBuffer_Click);
            // 
            // groupBoxProxy
            // 
            this.groupBoxProxy.Controls.Add(this.listViewProxy);
            this.groupBoxProxy.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxProxy.Location = new System.Drawing.Point(6, 6);
            this.groupBoxProxy.Name = "groupBoxProxy";
            this.groupBoxProxy.Size = new System.Drawing.Size(344, 255);
            this.groupBoxProxy.TabIndex = 0;
            this.groupBoxProxy.TabStop = false;
            this.groupBoxProxy.Text = "Прокси";
            // 
            // listViewProxy
            // 
            this.listViewProxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.listViewProxy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProxy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIp,
            this.columnPort,
            this.columnLogin,
            this.columnPassword});
            this.listViewProxy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProxy.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listViewProxy.Location = new System.Drawing.Point(3, 16);
            this.listViewProxy.Name = "listViewProxy";
            this.listViewProxy.Size = new System.Drawing.Size(338, 236);
            this.listViewProxy.TabIndex = 0;
            this.listViewProxy.UseCompatibleStateImageBehavior = false;
            this.listViewProxy.View = System.Windows.Forms.View.Details;
            // 
            // columnIp
            // 
            this.columnIp.Text = "Ip";
            this.columnIp.Width = 126;
            // 
            // columnPort
            // 
            this.columnPort.Text = "Port";
            this.columnPort.Width = 40;
            // 
            // columnLogin
            // 
            this.columnLogin.Text = "Login";
            this.columnLogin.Width = 67;
            // 
            // columnPassword
            // 
            this.columnPassword.Text = "Password";
            this.columnPassword.Width = 105;
            // 
            // btnSettingsOk
            // 
            this.btnSettingsOk.Location = new System.Drawing.Point(383, 35);
            this.btnSettingsOk.Name = "btnSettingsOk";
            this.btnSettingsOk.Size = new System.Drawing.Size(98, 23);
            this.btnSettingsOk.TabIndex = 2;
            this.btnSettingsOk.Text = "OK";
            this.btnSettingsOk.UseVisualStyleBackColor = true;
            this.btnSettingsOk.Click += new System.EventHandler(this.btnSettingsOk_Click);
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.Location = new System.Drawing.Point(383, 64);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(98, 23);
            this.btnSettingsCancel.TabIndex = 3;
            this.btnSettingsCancel.Text = "Отмена";
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            this.btnSettingsCancel.Click += new System.EventHandler(this.btnSettingsCancel_Click);
            // 
            // radioBtnHTTP
            // 
            this.radioBtnHTTP.AutoSize = true;
            this.radioBtnHTTP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioBtnHTTP.Location = new System.Drawing.Point(382, 229);
            this.radioBtnHTTP.Name = "radioBtnHTTP";
            this.radioBtnHTTP.Size = new System.Drawing.Size(57, 17);
            this.radioBtnHTTP.TabIndex = 4;
            this.radioBtnHTTP.Text = "HTTP ";
            this.radioBtnHTTP.UseVisualStyleBackColor = true;
            // 
            // radioBtnSocks4
            // 
            this.radioBtnSocks4.AutoSize = true;
            this.radioBtnSocks4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioBtnSocks4.Location = new System.Drawing.Point(382, 164);
            this.radioBtnSocks4.Name = "radioBtnSocks4";
            this.radioBtnSocks4.Size = new System.Drawing.Size(73, 17);
            this.radioBtnSocks4.TabIndex = 5;
            this.radioBtnSocks4.Text = "Socks4(a)";
            this.radioBtnSocks4.UseVisualStyleBackColor = true;
            // 
            // radioBtnSocks5
            // 
            this.radioBtnSocks5.AutoSize = true;
            this.radioBtnSocks5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioBtnSocks5.Location = new System.Drawing.Point(382, 197);
            this.radioBtnSocks5.Name = "radioBtnSocks5";
            this.radioBtnSocks5.Size = new System.Drawing.Size(64, 17);
            this.radioBtnSocks5.TabIndex = 6;
            this.radioBtnSocks5.Text = "Socks5 ";
            this.radioBtnSocks5.UseVisualStyleBackColor = true;
            // 
            // lblProxyType
            // 
            this.lblProxyType.AutoSize = true;
            this.lblProxyType.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblProxyType.Location = new System.Drawing.Point(383, 99);
            this.lblProxyType.Name = "lblProxyType";
            this.lblProxyType.Size = new System.Drawing.Size(68, 13);
            this.lblProxyType.TabIndex = 7;
            this.lblProxyType.Text = "Тип прокси:";
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Checked = true;
            this.radioBtnNo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioBtnNo.Location = new System.Drawing.Point(382, 129);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(113, 17);
            this.radioBtnNo.TabIndex = 8;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "Не использовать";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(493, 347);
            this.Controls.Add(this.radioBtnNo);
            this.Controls.Add(this.lblProxyType);
            this.Controls.Add(this.radioBtnSocks5);
            this.Controls.Add(this.radioBtnSocks4);
            this.Controls.Add(this.radioBtnHTTP);
            this.Controls.Add(this.btnSettingsCancel);
            this.Controls.Add(this.btnSettingsOk);
            this.Controls.Add(this.tabCntrlSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabCntrlSettings.ResumeLayout(false);
            this.tabPgSettingTag.ResumeLayout(false);
            this.groupBoxChooseTag.ResumeLayout(false);
            this.tabPgProxy.ResumeLayout(false);
            this.groupBoxProxy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCntrlSettings;
        private System.Windows.Forms.TabPage tabPgSettingTag;
        private System.Windows.Forms.TabPage tabPgProxy;
        private System.Windows.Forms.GroupBox groupBoxChooseTag;
        private System.Windows.Forms.CheckedListBox checkedListBoxTags;
        private System.Windows.Forms.Button btnSettingsOk;
        private System.Windows.Forms.Button btnSettingsCancel;
        private System.Windows.Forms.GroupBox groupBoxProxy;
        private System.Windows.Forms.ListView listViewProxy;
        private System.Windows.Forms.Button btnSettingsRemoveAll;
        private System.Windows.Forms.Button btnSettingsOfFile;
        private System.Windows.Forms.Button btnSettingsOfBuffer;
        private System.Windows.Forms.ColumnHeader columnIp;
        private System.Windows.Forms.ColumnHeader columnPort;
        private System.Windows.Forms.ColumnHeader columnLogin;
        private System.Windows.Forms.ColumnHeader columnPassword;
        private System.Windows.Forms.RadioButton radioBtnHTTP;
        private System.Windows.Forms.RadioButton radioBtnSocks4;
        private System.Windows.Forms.RadioButton radioBtnSocks5;
        private System.Windows.Forms.Label lblProxyType;
        private System.Windows.Forms.RadioButton radioBtnNo;
    }
}