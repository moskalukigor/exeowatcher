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
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.backgroundWorkerWaitThread = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxExeoLogo = new System.Windows.Forms.PictureBox();
            this.btnImgEdit = new System.Windows.Forms.PictureBox();
            this.btnImgStart = new System.Windows.Forms.PictureBox();
            this.btnImgDelete = new System.Windows.Forms.PictureBox();
            this.btnImgStop = new System.Windows.Forms.PictureBox();
            this.btnImgAdd = new System.Windows.Forms.PictureBox();
            this.openPicBox = new System.Windows.Forms.PictureBox();
            this.createPicBox = new System.Windows.Forms.PictureBox();
            this.materialFlatBtnClose = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatBtnHide = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatBtnMax = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelBtnSys = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExeoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createPicBox)).BeginInit();
            this.panelBtnSys.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
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
            this.createToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createBicBox_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.открытьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openPicBox_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.SaveAsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.AboutToolStripMenuItem});
            this.помощьToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // обратнаяСвязьToolStripMenuItem
            // 
            this.обратнаяСвязьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.обратнаяСвязьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.обратнаяСвязьToolStripMenuItem.Name = "обратнаяСвязьToolStripMenuItem";
            this.обратнаяСвязьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.обратнаяСвязьToolStripMenuItem.Text = "Обратная связь";
            this.обратнаяСвязьToolStripMenuItem.Click += new System.EventHandler(this.обратнаяСвязьToolStripMenuItem_Click);
            // 
            // помощьПроектуToolStripMenuItem
            // 
            this.помощьПроектуToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.помощьПроектуToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.помощьПроектуToolStripMenuItem.Name = "помощьПроектуToolStripMenuItem";
            this.помощьПроектуToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.помощьПроектуToolStripMenuItem.Text = "Помощь проекту";
            this.помощьПроектуToolStripMenuItem.Click += new System.EventHandler(this.помощьПроектуToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // listViewSites
            // 
            this.listViewSites.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewSites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.listViewSites.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listViewSites.FullRowSelect = true;
            this.listViewSites.Location = new System.Drawing.Point(0, 99);
            this.listViewSites.Name = "listViewSites";
            this.listViewSites.Size = new System.Drawing.Size(816, 460);
            this.listViewSites.TabIndex = 11;
            this.listViewSites.UseCompatibleStateImageBehavior = false;
            this.listViewSites.View = System.Windows.Forms.View.Details;
            this.listViewSites.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewSites_MouseDoubleClick);
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
            // backgroundWorkerWaitThread
            // 
            this.backgroundWorkerWaitThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerWaitThread_DoWork);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // picBoxExeoLogo
            // 
            this.picBoxExeoLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxExeoLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBoxExeoLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxExeoLogo.Image")));
            this.picBoxExeoLogo.Location = new System.Drawing.Point(568, -2);
            this.picBoxExeoLogo.Name = "picBoxExeoLogo";
            this.picBoxExeoLogo.Size = new System.Drawing.Size(233, 72);
            this.picBoxExeoLogo.TabIndex = 5;
            this.picBoxExeoLogo.TabStop = false;
            // 
            // btnImgEdit
            // 
            this.btnImgEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnImgEdit.Image = global::exeowatcher.Properties.Resources.edit;
            this.btnImgEdit.Location = new System.Drawing.Point(366, 8);
            this.btnImgEdit.Name = "btnImgEdit";
            this.btnImgEdit.Size = new System.Drawing.Size(195, 50);
            this.btnImgEdit.TabIndex = 16;
            this.btnImgEdit.TabStop = false;
            this.btnImgEdit.Click += new System.EventHandler(this.btnImgEdit_Click);
            this.btnImgEdit.MouseEnter += new System.EventHandler(this.btnImgEdit_MouseEnter);
            this.btnImgEdit.MouseLeave += new System.EventHandler(this.btnImgEdit_MouseLeave);
            // 
            // btnImgStart
            // 
            this.btnImgStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.btnImgDelete.BackgroundImage = global::exeowatcher.Properties.Resources.delete;
            this.btnImgDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnImgDelete.Location = new System.Drawing.Point(216, 8);
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
            this.btnImgStop.Location = new System.Drawing.Point(27, 8);
            this.btnImgStop.Name = "btnImgStop";
            this.btnImgStop.Size = new System.Drawing.Size(51, 50);
            this.btnImgStop.TabIndex = 13;
            this.btnImgStop.TabStop = false;
            this.btnImgStop.Visible = false;
            this.btnImgStop.Click += new System.EventHandler(this.btnImgStop_Click);
            this.btnImgStop.MouseEnter += new System.EventHandler(this.btnImgStop_MouseEnter);
            this.btnImgStop.MouseLeave += new System.EventHandler(this.btnImgStop_MouseLeave);
            // 
            // btnImgAdd
            // 
            this.btnImgAdd.BackgroundImage = global::exeowatcher.Properties.Resources.add;
            this.btnImgAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnImgAdd.Location = new System.Drawing.Point(66, 8);
            this.btnImgAdd.Name = "btnImgAdd";
            this.btnImgAdd.Size = new System.Drawing.Size(140, 50);
            this.btnImgAdd.TabIndex = 14;
            this.btnImgAdd.TabStop = false;
            this.btnImgAdd.Click += new System.EventHandler(this.btnImgAdd_Click);
            this.btnImgAdd.MouseEnter += new System.EventHandler(this.btnImgAdd_MouseEnter);
            this.btnImgAdd.MouseLeave += new System.EventHandler(this.btnImgAdd_MouseLeave);
            // 
            // openPicBox
            // 
            this.openPicBox.BackgroundImage = global::exeowatcher.Properties.Resources.Open;
            this.openPicBox.Location = new System.Drawing.Point(12, 209);
            this.openPicBox.Name = "openPicBox";
            this.openPicBox.Size = new System.Drawing.Size(135, 50);
            this.openPicBox.TabIndex = 13;
            this.openPicBox.TabStop = false;
            this.openPicBox.Click += new System.EventHandler(this.openPicBox_Click);
            // 
            // createPicBox
            // 
            this.createPicBox.BackgroundImage = global::exeowatcher.Properties.Resources.create;
            this.createPicBox.Location = new System.Drawing.Point(12, 138);
            this.createPicBox.Name = "createPicBox";
            this.createPicBox.Size = new System.Drawing.Size(135, 50);
            this.createPicBox.TabIndex = 12;
            this.createPicBox.TabStop = false;
            this.createPicBox.Click += new System.EventHandler(this.createBicBox_Click);
            // 
            // materialFlatBtnClose
            // 
            this.materialFlatBtnClose.AutoSize = true;
            this.materialFlatBtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatBtnClose.Depth = 0;
            this.materialFlatBtnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatBtnClose.Location = new System.Drawing.Point(64, -3);
            this.materialFlatBtnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatBtnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatBtnClose.Name = "materialFlatBtnClose";
            this.materialFlatBtnClose.Primary = false;
            this.materialFlatBtnClose.Size = new System.Drawing.Size(21, 36);
            this.materialFlatBtnClose.TabIndex = 14;
            this.materialFlatBtnClose.Text = "X";
            this.materialFlatBtnClose.UseVisualStyleBackColor = true;
            this.materialFlatBtnClose.Click += new System.EventHandler(this.materialFlatBtnClose_Click);
            // 
            // materialFlatBtnHide
            // 
            this.materialFlatBtnHide.AutoSize = true;
            this.materialFlatBtnHide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatBtnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.materialFlatBtnHide.Depth = 0;
            this.materialFlatBtnHide.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatBtnHide.Location = new System.Drawing.Point(8, -3);
            this.materialFlatBtnHide.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatBtnHide.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatBtnHide.Name = "materialFlatBtnHide";
            this.materialFlatBtnHide.Primary = false;
            this.materialFlatBtnHide.Size = new System.Drawing.Size(18, 36);
            this.materialFlatBtnHide.TabIndex = 15;
            this.materialFlatBtnHide.Text = "_";
            this.materialFlatBtnHide.UseVisualStyleBackColor = false;
            this.materialFlatBtnHide.Click += new System.EventHandler(this.materialFlatBtnHide_Click);
            // 
            // materialFlatBtnMax
            // 
            this.materialFlatBtnMax.AutoSize = true;
            this.materialFlatBtnMax.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatBtnMax.Depth = 0;
            this.materialFlatBtnMax.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatBtnMax.Location = new System.Drawing.Point(32, -2);
            this.materialFlatBtnMax.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatBtnMax.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatBtnMax.Name = "materialFlatBtnMax";
            this.materialFlatBtnMax.Primary = false;
            this.materialFlatBtnMax.Size = new System.Drawing.Size(27, 36);
            this.materialFlatBtnMax.TabIndex = 16;
            this.materialFlatBtnMax.Text = "❐";
            this.materialFlatBtnMax.UseVisualStyleBackColor = true;
            this.materialFlatBtnMax.Click += new System.EventHandler(this.materialFlatBtnMax_Click);
            // 
            // panelBtnSys
            // 
            this.panelBtnSys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtnSys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelBtnSys.Controls.Add(this.materialFlatBtnMax);
            this.panelBtnSys.Controls.Add(this.materialFlatBtnClose);
            this.panelBtnSys.Controls.Add(this.materialFlatBtnHide);
            this.panelBtnSys.Location = new System.Drawing.Point(726, -1);
            this.panelBtnSys.Name = "panelBtnSys";
            this.panelBtnSys.Size = new System.Drawing.Size(90, 29);
            this.panelBtnSys.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(816, 561);
            this.Controls.Add(this.panelBtnSys);
            this.Controls.Add(this.openPicBox);
            this.Controls.Add(this.createPicBox);
            this.Controls.Add(this.listViewSites);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 561);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExeoWatcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExeoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImgAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createPicBox)).EndInit();
            this.panelBtnSys.ResumeLayout(false);
            this.panelBtnSys.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showCompareToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnImgStart;
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
        private System.ComponentModel.BackgroundWorker backgroundWorkerWaitThread;
        private System.Windows.Forms.ListView listViewSites;
        private System.Windows.Forms.PictureBox btnImgStop;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatBtnClose;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatBtnHide;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatBtnMax;
        private System.Windows.Forms.Panel panelBtnSys;
    }
}

