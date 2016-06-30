﻿namespace exeowatcher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратнаяСвязьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьПроектуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewSites = new System.Windows.Forms.ListView();
            this.colProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecentScan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKeyword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTagP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTagB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTagH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCompareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBtnStart = new System.Windows.Forms.Timer(this.components);
            this.timerBtnStop = new System.Windows.Forms.Timer(this.components);
            this.timerBtnAdd = new System.Windows.Forms.Timer(this.components);
            this.timerBtnDelete = new System.Windows.Forms.Timer(this.components);
            this.timerBtnEdit = new System.Windows.Forms.Timer(this.components);
            this.openPicBox = new System.Windows.Forms.PictureBox();
            this.createPicBox = new System.Windows.Forms.PictureBox();
            this.picBoxExeoLogo = new System.Windows.Forms.PictureBox();
            this.btnImgEdit = new System.Windows.Forms.PictureBox();
            this.btnImgStart = new System.Windows.Forms.PictureBox();
            this.btnImgDelete = new System.Windows.Forms.PictureBox();
            this.btnImgStop = new System.Windows.Forms.PictureBox();
            this.btnImgAdd = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExeoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createBicBox_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openPicBox_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.SettingsToolStripMenuItem.Text = "Настройка";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обратнаяСвязьToolStripMenuItem,
            this.помощьПроектуToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // обратнаяСвязьToolStripMenuItem
            // 
            this.обратнаяСвязьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.обратнаяСвязьToolStripMenuItem.Name = "обратнаяСвязьToolStripMenuItem";
            this.обратнаяСвязьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.обратнаяСвязьToolStripMenuItem.Text = "Обратная связь";
            this.обратнаяСвязьToolStripMenuItem.Click += new System.EventHandler(this.обратнаяСвязьToolStripMenuItem_Click);
            // 
            // помощьПроектуToolStripMenuItem
            // 
            this.помощьПроектуToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.помощьПроектуToolStripMenuItem.Name = "помощьПроектуToolStripMenuItem";
            this.помощьПроектуToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.помощьПроектуToolStripMenuItem.Text = "Помощь проекту";
            this.помощьПроектуToolStripMenuItem.Click += new System.EventHandler(this.помощьПроектуToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picBoxExeoLogo);
            this.panel2.Controls.Add(this.btnImgEdit);
            this.panel2.Controls.Add(this.btnImgStart);
            this.panel2.Controls.Add(this.btnImgDelete);
            this.panel2.Controls.Add(this.btnImgStop);
            this.panel2.Controls.Add(this.btnImgAdd);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 66);
            this.panel2.TabIndex = 10;
            // 
            // listViewSites
            // 
            this.listViewSites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.listViewSites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSites.CheckBoxes = true;
            this.listViewSites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProject,
            this.colRecentScan,
            this.colPages,
            this.colTitle,
            this.colDescription,
            this.colKeyword,
            this.colContent,
            this.colTagP,
            this.colTagB,
            this.colTagH});
            this.listViewSites.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewSites.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSites.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewSites.FullRowSelect = true;
            this.listViewSites.Location = new System.Drawing.Point(0, 99);
            this.listViewSites.Name = "listViewSites";
            this.listViewSites.Size = new System.Drawing.Size(816, 462);
            this.listViewSites.TabIndex = 11;
            this.listViewSites.UseCompatibleStateImageBehavior = false;
            this.listViewSites.View = System.Windows.Forms.View.Details;
            // 
            // colProject
            // 
            this.colProject.Text = "Проект";
            this.colProject.Width = 174;
            // 
            // colRecentScan
            // 
            this.colRecentScan.Text = "Последнее сканирование";
            this.colRecentScan.Width = 152;
            // 
            // colPages
            // 
            this.colPages.Text = "Страницы";
            this.colPages.Width = 68;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            // 
            // colDescription
            // 
            this.colDescription.Text = "Desc";
            // 
            // colKeyword
            // 
            this.colKeyword.DisplayIndex = 6;
            this.colKeyword.Text = "Keyw";
            // 
            // colContent
            // 
            this.colContent.DisplayIndex = 5;
            this.colContent.Text = "Cont";
            // 
            // colTagP
            // 
            this.colTagP.Text = "p";
            // 
            // colTagB
            // 
            this.colTagB.Text = "b";
            // 
            // colTagH
            // 
            this.colTagH.Text = "h1-h6";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCompareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 26);
            // 
            // showCompareToolStripMenuItem
            // 
            this.showCompareToolStripMenuItem.Name = "showCompareToolStripMenuItem";
            this.showCompareToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.showCompareToolStripMenuItem.Text = "Просмотр различий";
            this.showCompareToolStripMenuItem.Click += new System.EventHandler(this.showCompareToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // timerBtnStart
            // 
            this.timerBtnStart.Tick += new System.EventHandler(this.timerBtnStart_Tick);
            // 
            // timerBtnStop
            // 
            this.timerBtnStop.Tick += new System.EventHandler(this.timerBtnStop_Tick);
            // 
            // timerBtnAdd
            // 
            this.timerBtnAdd.Tick += new System.EventHandler(this.timerBtnAdd_Tick);
            // 
            // timerBtnDelete
            // 
            this.timerBtnDelete.Tick += new System.EventHandler(this.timerBtnDelete_Tick);
            // 
            // timerBtnEdit
            // 
            this.timerBtnEdit.Tick += new System.EventHandler(this.timerBtnEdit_Tick);
            // 
            // openPicBox
            // 
            this.openPicBox.Image = global::exeowatcher.Properties.Resources.Open;
            this.openPicBox.Location = new System.Drawing.Point(12, 209);
            this.openPicBox.Name = "openPicBox";
            this.openPicBox.Size = new System.Drawing.Size(135, 50);
            this.openPicBox.TabIndex = 13;
            this.openPicBox.TabStop = false;
            this.openPicBox.Click += new System.EventHandler(this.openPicBox_Click);
            // 
            // createPicBox
            // 
            this.createPicBox.Image = global::exeowatcher.Properties.Resources.create;
            this.createPicBox.Location = new System.Drawing.Point(12, 138);
            this.createPicBox.Name = "createPicBox";
            this.createPicBox.Size = new System.Drawing.Size(135, 50);
            this.createPicBox.TabIndex = 12;
            this.createPicBox.TabStop = false;
            this.createPicBox.Click += new System.EventHandler(this.createBicBox_Click);
            // 
            // picBoxExeoLogo
            // 
            this.picBoxExeoLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBoxExeoLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxExeoLogo.Image")));
            this.picBoxExeoLogo.Location = new System.Drawing.Point(560, -6);
            this.picBoxExeoLogo.Name = "picBoxExeoLogo";
            this.picBoxExeoLogo.Size = new System.Drawing.Size(244, 72);
            this.picBoxExeoLogo.TabIndex = 5;
            this.picBoxExeoLogo.TabStop = false;
            // 
            // btnImgEdit
            // 
            this.btnImgEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnImgEdit.Image = global::exeowatcher.Properties.Resources.edit;
            this.btnImgEdit.Location = new System.Drawing.Point(409, 8);
            this.btnImgEdit.Name = "btnImgEdit";
            this.btnImgEdit.Size = new System.Drawing.Size(145, 50);
            this.btnImgEdit.TabIndex = 16;
            this.btnImgEdit.TabStop = false;
            this.btnImgEdit.Click += new System.EventHandler(this.btnImgEdit_Click);
            this.btnImgEdit.MouseEnter += new System.EventHandler(this.btnImgEdit_MouseEnter);
            this.btnImgEdit.MouseLeave += new System.EventHandler(this.btnImgEdit_MouseLeave);
            // 
            // btnImgStart
            // 
            this.btnImgStart.Image = global::exeowatcher.Properties.Resources.play;
            this.btnImgStart.Location = new System.Drawing.Point(3, 8);
            this.btnImgStart.Name = "btnImgStart";
            this.btnImgStart.Size = new System.Drawing.Size(51, 50);
            this.btnImgStart.TabIndex = 12;
            this.btnImgStart.TabStop = false;
            this.btnImgStart.Click += new System.EventHandler(this.btnImgStart_Click);
            this.btnImgStart.MouseEnter += new System.EventHandler(this.btnImgStart_MouseEnter);
            this.btnImgStart.MouseLeave += new System.EventHandler(this.btnImgStart_MouseLeave);
            // 
            // btnImgDelete
            // 
            this.btnImgDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnImgDelete.Image = global::exeowatcher.Properties.Resources.delete;
            this.btnImgDelete.Location = new System.Drawing.Point(263, 8);
            this.btnImgDelete.Name = "btnImgDelete";
            this.btnImgDelete.Size = new System.Drawing.Size(140, 50);
            this.btnImgDelete.TabIndex = 15;
            this.btnImgDelete.TabStop = false;
            this.btnImgDelete.Click += new System.EventHandler(this.btnImgDelete_Click);
            this.btnImgDelete.MouseEnter += new System.EventHandler(this.btnImgDelete_MouseEnter);
            this.btnImgDelete.MouseLeave += new System.EventHandler(this.btnImgDelete_MouseLeave);
            // 
            // btnImgStop
            // 
            this.btnImgStop.Image = global::exeowatcher.Properties.Resources.stop;
            this.btnImgStop.Location = new System.Drawing.Point(60, 8);
            this.btnImgStop.Name = "btnImgStop";
            this.btnImgStop.Size = new System.Drawing.Size(51, 50);
            this.btnImgStop.TabIndex = 13;
            this.btnImgStop.TabStop = false;
            this.btnImgStop.Click += new System.EventHandler(this.btnImgStop_Click);
            this.btnImgStop.MouseEnter += new System.EventHandler(this.btnImgStop_MouseEnter);
            this.btnImgStop.MouseLeave += new System.EventHandler(this.btnImgStop_MouseLeave);
            // 
            // btnImgAdd
            // 
            this.btnImgAdd.BackgroundImage = global::exeowatcher.Properties.Resources.add;
            this.btnImgAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnImgAdd.Image = global::exeowatcher.Properties.Resources.add;
            this.btnImgAdd.Location = new System.Drawing.Point(117, 8);
            this.btnImgAdd.Name = "btnImgAdd";
            this.btnImgAdd.Size = new System.Drawing.Size(140, 50);
            this.btnImgAdd.TabIndex = 14;
            this.btnImgAdd.TabStop = false;
            this.btnImgAdd.Click += new System.EventHandler(this.btnImgAdd_Click);
            this.btnImgAdd.MouseEnter += new System.EventHandler(this.btnImgAdd_MouseEnter);
            this.btnImgAdd.MouseLeave += new System.EventHandler(this.btnImgAdd_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(816, 566);
            this.Controls.Add(this.openPicBox);
            this.Controls.Add(this.createPicBox);
            this.Controls.Add(this.listViewSites);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ExeoWatcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExeoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратнаяСвязьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьПроектуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBoxExeoLogo;
        private System.Windows.Forms.ColumnHeader colRecentScan;
        private System.Windows.Forms.ColumnHeader colPages;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colKeyword;
        private System.Windows.Forms.ColumnHeader colContent;
        private System.Windows.Forms.ColumnHeader colTagP;
        private System.Windows.Forms.ColumnHeader colTagB;
        private System.Windows.Forms.ColumnHeader colTagH;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ListView listViewSites;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showCompareToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnImgStart;
        private System.Windows.Forms.PictureBox btnImgStop;
        private System.Windows.Forms.PictureBox btnImgAdd;
        private System.Windows.Forms.PictureBox btnImgDelete;
        private System.Windows.Forms.PictureBox btnImgEdit;
        private System.Windows.Forms.Timer timerBtnStart;
        private System.Windows.Forms.Timer timerBtnStop;
        private System.Windows.Forms.Timer timerBtnAdd;
        private System.Windows.Forms.Timer timerBtnDelete;
        private System.Windows.Forms.Timer timerBtnEdit;
        private System.Windows.Forms.ColumnHeader colProject;
        private System.Windows.Forms.PictureBox createPicBox;
        private System.Windows.Forms.PictureBox openPicBox;
    }
}

