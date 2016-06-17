namespace exeowatcher
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabCntrlSettings = new System.Windows.Forms.TabControl();
            this.tabPgSettingTag = new System.Windows.Forms.TabPage();
            this.groupBoxChooseTag = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPgProxy = new System.Windows.Forms.TabPage();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSettingsOk = new System.Windows.Forms.Button();
            this.btnSettingsCancel = new System.Windows.Forms.Button();
            this.groupBoxProxy = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSettingsOfBuffer = new System.Windows.Forms.Button();
            this.btnSettingsOfFile = new System.Windows.Forms.Button();
            this.btnSettingsRemoveAll = new System.Windows.Forms.Button();
            this.tabCntrlSettings.SuspendLayout();
            this.tabPgSettingTag.SuspendLayout();
            this.groupBoxChooseTag.SuspendLayout();
            this.tabPgProxy.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
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
            this.tabCntrlSettings.Size = new System.Drawing.Size(364, 222);
            this.tabCntrlSettings.TabIndex = 0;
            // 
            // tabPgSettingTag
            // 
            this.tabPgSettingTag.Controls.Add(this.groupBoxChooseTag);
            this.tabPgSettingTag.Location = new System.Drawing.Point(4, 22);
            this.tabPgSettingTag.Name = "tabPgSettingTag";
            this.tabPgSettingTag.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgSettingTag.Size = new System.Drawing.Size(356, 196);
            this.tabPgSettingTag.TabIndex = 0;
            this.tabPgSettingTag.Text = "Настройка тегов";
            this.tabPgSettingTag.UseVisualStyleBackColor = true;
            // 
            // groupBoxChooseTag
            // 
            this.groupBoxChooseTag.Controls.Add(this.checkedListBox1);
            this.groupBoxChooseTag.Location = new System.Drawing.Point(7, 7);
            this.groupBoxChooseTag.Name = "groupBoxChooseTag";
            this.groupBoxChooseTag.Size = new System.Drawing.Size(343, 183);
            this.groupBoxChooseTag.TabIndex = 0;
            this.groupBoxChooseTag.TabStop = false;
            this.groupBoxChooseTag.Text = "Выберите тег";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "H1-H6",
            "Title",
            "Description",
            "Keywords",
            "Strong",
            "<p>",
            "<b>"});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 20);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(330, 150);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tabPgProxy
            // 
            this.tabPgProxy.Controls.Add(this.btnSettingsRemoveAll);
            this.tabPgProxy.Controls.Add(this.btnSettingsOfFile);
            this.tabPgProxy.Controls.Add(this.btnSettingsOfBuffer);
            this.tabPgProxy.Controls.Add(this.groupBoxProxy);
            this.tabPgProxy.Location = new System.Drawing.Point(4, 22);
            this.tabPgProxy.Name = "tabPgProxy";
            this.tabPgProxy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgProxy.Size = new System.Drawing.Size(356, 196);
            this.tabPgProxy.TabIndex = 1;
            this.tabPgProxy.Text = "Прокси-сервер";
            this.tabPgProxy.UseVisualStyleBackColor = true;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.lblDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(13, 241);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(360, 99);
            this.groupBoxDescription.TabIndex = 1;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Описание";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(57, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Описание";
            // 
            // btnSettingsOk
            // 
            this.btnSettingsOk.Location = new System.Drawing.Point(383, 35);
            this.btnSettingsOk.Name = "btnSettingsOk";
            this.btnSettingsOk.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsOk.TabIndex = 2;
            this.btnSettingsOk.Text = "OK";
            this.btnSettingsOk.UseVisualStyleBackColor = true;
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.Location = new System.Drawing.Point(383, 64);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsCancel.TabIndex = 3;
            this.btnSettingsCancel.Text = "Отмена";
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxProxy
            // 
            this.groupBoxProxy.Controls.Add(this.listView1);
            this.groupBoxProxy.Location = new System.Drawing.Point(6, 6);
            this.groupBoxProxy.Name = "groupBoxProxy";
            this.groupBoxProxy.Size = new System.Drawing.Size(344, 145);
            this.groupBoxProxy.TabIndex = 0;
            this.groupBoxProxy.TabStop = false;
            this.groupBoxProxy.Text = "Прокси";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIp,
            this.columnPort,
            this.columnLogin,
            this.columnPassword});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(338, 126);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // btnSettingsOfBuffer
            // 
            this.btnSettingsOfBuffer.Location = new System.Drawing.Point(6, 167);
            this.btnSettingsOfBuffer.Name = "btnSettingsOfBuffer";
            this.btnSettingsOfBuffer.Size = new System.Drawing.Size(83, 23);
            this.btnSettingsOfBuffer.TabIndex = 1;
            this.btnSettingsOfBuffer.Text = "Из буффера";
            this.btnSettingsOfBuffer.UseVisualStyleBackColor = true;
            // 
            // btnSettingsOfFile
            // 
            this.btnSettingsOfFile.Location = new System.Drawing.Point(133, 167);
            this.btnSettingsOfFile.Name = "btnSettingsOfFile";
            this.btnSettingsOfFile.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsOfFile.TabIndex = 2;
            this.btnSettingsOfFile.Text = "Из файла";
            this.btnSettingsOfFile.UseVisualStyleBackColor = true;
            // 
            // btnSettingsRemoveAll
            // 
            this.btnSettingsRemoveAll.Location = new System.Drawing.Point(264, 167);
            this.btnSettingsRemoveAll.Name = "btnSettingsRemoveAll";
            this.btnSettingsRemoveAll.Size = new System.Drawing.Size(83, 23);
            this.btnSettingsRemoveAll.TabIndex = 3;
            this.btnSettingsRemoveAll.Text = "Удалить всё";
            this.btnSettingsRemoveAll.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 347);
            this.Controls.Add(this.btnSettingsCancel);
            this.Controls.Add(this.btnSettingsOk);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.tabCntrlSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.tabCntrlSettings.ResumeLayout(false);
            this.tabPgSettingTag.ResumeLayout(false);
            this.groupBoxChooseTag.ResumeLayout(false);
            this.tabPgProxy.ResumeLayout(false);
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.groupBoxProxy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCntrlSettings;
        private System.Windows.Forms.TabPage tabPgSettingTag;
        private System.Windows.Forms.TabPage tabPgProxy;
        private System.Windows.Forms.GroupBox groupBoxChooseTag;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSettingsOk;
        private System.Windows.Forms.Button btnSettingsCancel;
        private System.Windows.Forms.GroupBox groupBoxProxy;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSettingsRemoveAll;
        private System.Windows.Forms.Button btnSettingsOfFile;
        private System.Windows.Forms.Button btnSettingsOfBuffer;
        private System.Windows.Forms.ColumnHeader columnIp;
        private System.Windows.Forms.ColumnHeader columnPort;
        private System.Windows.Forms.ColumnHeader columnLogin;
        private System.Windows.Forms.ColumnHeader columnPassword;
    }
}