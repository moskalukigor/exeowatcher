namespace exeowatcher
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
            this.btnScan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtBoxSite = new System.Windows.Forms.TextBox();
            this.lblPrevScan = new System.Windows.Forms.Label();
            this.lblCurScan = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBoxCurrScan = new System.Windows.Forms.TextBox();
            this.txtBoxPrevScan = new System.Windows.Forms.TextBox();
            this.richTxtResult = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратнаяСвязьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьПроектуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxExeoLogo = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.listViewSites = new System.Windows.Forms.ListView();
            this.colProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecentScan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKeyword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTagP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTagB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTagH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExeoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnScan.Location = new System.Drawing.Point(3, 17);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(118, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.txtBoxSite);
            this.panel1.Controls.Add(this.btnScan);
            this.panel1.Location = new System.Drawing.Point(12, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 380);
            this.panel1.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(3, 73);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(118, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check equal";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtBoxSite
            // 
            this.txtBoxSite.Location = new System.Drawing.Point(4, 47);
            this.txtBoxSite.Name = "txtBoxSite";
            this.txtBoxSite.Size = new System.Drawing.Size(117, 20);
            this.txtBoxSite.TabIndex = 1;
            this.txtBoxSite.Text = "http://test.exeo.local/";
            // 
            // lblPrevScan
            // 
            this.lblPrevScan.AutoSize = true;
            this.lblPrevScan.Location = new System.Drawing.Point(143, 397);
            this.lblPrevScan.Name = "lblPrevScan";
            this.lblPrevScan.Size = new System.Drawing.Size(55, 13);
            this.lblPrevScan.TabIndex = 4;
            this.lblPrevScan.Text = "Prev scan";
            // 
            // lblCurScan
            // 
            this.lblCurScan.AutoSize = true;
            this.lblCurScan.Location = new System.Drawing.Point(291, 397);
            this.lblCurScan.Name = "lblCurScan";
            this.lblCurScan.Size = new System.Drawing.Size(67, 13);
            this.lblCurScan.TabIndex = 5;
            this.lblCurScan.Text = "Current scan";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(434, 397);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(50, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "RESULT";
            // 
            // txtBoxCurrScan
            // 
            this.txtBoxCurrScan.Location = new System.Drawing.Point(294, 416);
            this.txtBoxCurrScan.Multiline = true;
            this.txtBoxCurrScan.Name = "txtBoxCurrScan";
            this.txtBoxCurrScan.ReadOnly = true;
            this.txtBoxCurrScan.Size = new System.Drawing.Size(137, 360);
            this.txtBoxCurrScan.TabIndex = 3;
            this.txtBoxCurrScan.WordWrap = false;
            // 
            // txtBoxPrevScan
            // 
            this.txtBoxPrevScan.Location = new System.Drawing.Point(142, 416);
            this.txtBoxPrevScan.Multiline = true;
            this.txtBoxPrevScan.Name = "txtBoxPrevScan";
            this.txtBoxPrevScan.ReadOnly = true;
            this.txtBoxPrevScan.Size = new System.Drawing.Size(146, 360);
            this.txtBoxPrevScan.TabIndex = 2;
            this.txtBoxPrevScan.WordWrap = false;
            // 
            // richTxtResult
            // 
            this.richTxtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtResult.Location = new System.Drawing.Point(437, 416);
            this.richTxtResult.Name = "richTxtResult";
            this.richTxtResult.ReadOnly = true;
            this.richTxtResult.Size = new System.Drawing.Size(367, 360);
            this.richTxtResult.TabIndex = 8;
            this.richTxtResult.Text = "";
            this.richTxtResult.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкаToolStripMenuItem,
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
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.закрытьВсёToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // закрытьВсёToolStripMenuItem
            // 
            this.закрытьВсёToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.закрытьВсёToolStripMenuItem.Name = "закрытьВсёToolStripMenuItem";
            this.закрытьВсёToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.W)));
            this.закрытьВсёToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.закрытьВсёToolStripMenuItem.Text = "Закрыть всё";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Gray;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обратнаяСвязьToolStripMenuItem,
            this.помощьПроектуToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // обратнаяСвязьToolStripMenuItem
            // 
            this.обратнаяСвязьToolStripMenuItem.Name = "обратнаяСвязьToolStripMenuItem";
            this.обратнаяСвязьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.обратнаяСвязьToolStripMenuItem.Text = "Обратная связь";
            // 
            // помощьПроектуToolStripMenuItem
            // 
            this.помощьПроектуToolStripMenuItem.Name = "помощьПроектуToolStripMenuItem";
            this.помощьПроектуToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.помощьПроектуToolStripMenuItem.Text = "Помощь проекту";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.picBoxExeoLogo);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 66);
            this.panel2.TabIndex = 10;
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(379, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 35);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(85, 7);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(54, 49);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(51, 49);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // listViewSites
            // 
            this.listViewSites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(97)))), ((int)(((byte)(98)))));
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
            this.listViewSites.Location = new System.Drawing.Point(0, 99);
            this.listViewSites.Name = "listViewSites";
            this.listViewSites.Size = new System.Drawing.Size(816, 283);
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
            // colContent
            // 
            this.colContent.DisplayIndex = 5;
            this.colContent.Text = "Cont";
            // 
            // colKeyword
            // 
            this.colKeyword.DisplayIndex = 6;
            this.colKeyword.Text = "Keyw";
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(816, 566);
            this.Controls.Add(this.listViewSites);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTxtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCurScan);
            this.Controls.Add(this.lblPrevScan);
            this.Controls.Add(this.txtBoxCurrScan);
            this.Controls.Add(this.txtBoxPrevScan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ExeoWatcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExeoLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrevScan;
        private System.Windows.Forms.Label lblCurScan;
        private System.Windows.Forms.TextBox txtBoxSite;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBoxCurrScan;
        private System.Windows.Forms.TextBox txtBoxPrevScan;
        private System.Windows.Forms.RichTextBox richTxtResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратнаяСвязьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьПроектуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBoxExeoLogo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView listViewSites;
        private System.Windows.Forms.ColumnHeader colProject;
        private System.Windows.Forms.ColumnHeader colRecentScan;
        private System.Windows.Forms.ColumnHeader colPages;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colKeyword;
        private System.Windows.Forms.ColumnHeader colContent;
        private System.Windows.Forms.ColumnHeader colTagP;
        private System.Windows.Forms.ColumnHeader colTagB;
        private System.Windows.Forms.ColumnHeader colTagH;
        private System.Windows.Forms.Button btnAdd;
    }
}

