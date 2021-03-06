﻿namespace exeowatcher
{
    partial class AddSiteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSiteForm));
            this.groupBoxSite = new System.Windows.Forms.GroupBox();
            this.txtBoxSite = new System.Windows.Forms.TextBox();
            this.groupBoxPages = new System.Windows.Forms.GroupBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAddPage = new System.Windows.Forms.GroupBox();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.txtBoxPage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImportOfTxt = new System.Windows.Forms.Button();
            this.btnImportOfSiteMap = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBoxSite.SuspendLayout();
            this.groupBoxPages.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.groupBoxAddPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSite
            // 
            this.groupBoxSite.Controls.Add(this.txtBoxSite);
            this.groupBoxSite.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSite.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSite.Name = "groupBoxSite";
            this.groupBoxSite.Size = new System.Drawing.Size(287, 55);
            this.groupBoxSite.TabIndex = 0;
            this.groupBoxSite.TabStop = false;
            this.groupBoxSite.Text = "Сайт";
            // 
            // txtBoxSite
            // 
            this.txtBoxSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtBoxSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSite.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxSite.Location = new System.Drawing.Point(7, 20);
            this.txtBoxSite.Name = "txtBoxSite";
            this.txtBoxSite.Size = new System.Drawing.Size(273, 20);
            this.txtBoxSite.TabIndex = 0;
            this.txtBoxSite.Text = "http://";
            this.txtBoxSite.TextChanged += new System.EventHandler(this.txtBoxSite_TextChanged);
            // 
            // groupBoxPages
            // 
            this.groupBoxPages.Controls.Add(this.listBoxPages);
            this.groupBoxPages.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxPages.Location = new System.Drawing.Point(12, 73);
            this.groupBoxPages.Name = "groupBoxPages";
            this.groupBoxPages.Size = new System.Drawing.Size(287, 181);
            this.groupBoxPages.TabIndex = 1;
            this.groupBoxPages.TabStop = false;
            this.groupBoxPages.Text = "Страницы";
            // 
            // listBoxPages
            // 
            this.listBoxPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.listBoxPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPages.ContextMenuStrip = this.contextMenuStrip;
            this.listBoxPages.ForeColor = System.Drawing.Color.DarkGray;
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(6, 21);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(273, 145);
            this.listBoxPages.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // groupBoxAddPage
            // 
            this.groupBoxAddPage.Controls.Add(this.btnAddPage);
            this.groupBoxAddPage.Controls.Add(this.txtBoxPage);
            this.groupBoxAddPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxAddPage.Location = new System.Drawing.Point(13, 261);
            this.groupBoxAddPage.Name = "groupBoxAddPage";
            this.groupBoxAddPage.Size = new System.Drawing.Size(279, 53);
            this.groupBoxAddPage.TabIndex = 2;
            this.groupBoxAddPage.TabStop = false;
            this.groupBoxAddPage.Text = "Добавить страницу";
            // 
            // btnAddPage
            // 
            this.btnAddPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddPage.Location = new System.Drawing.Point(204, 18);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(69, 23);
            this.btnAddPage.TabIndex = 1;
            this.btnAddPage.Text = "Добавить";
            this.btnAddPage.UseVisualStyleBackColor = true;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // txtBoxPage
            // 
            this.txtBoxPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPage.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxPage.Location = new System.Drawing.Point(6, 19);
            this.txtBoxPage.Name = "txtBoxPage";
            this.txtBoxPage.Size = new System.Drawing.Size(192, 20);
            this.txtBoxPage.TabIndex = 0;
            this.txtBoxPage.Text = "http://";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImportOfTxt);
            this.groupBox1.Controls.Add(this.btnImportOfSiteMap);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(13, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Импорт";
            // 
            // btnImportOfTxt
            // 
            this.btnImportOfTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImportOfTxt.Location = new System.Drawing.Point(145, 19);
            this.btnImportOfTxt.Name = "btnImportOfTxt";
            this.btnImportOfTxt.Size = new System.Drawing.Size(128, 23);
            this.btnImportOfTxt.TabIndex = 3;
            this.btnImportOfTxt.Text = "Из файла txt";
            this.btnImportOfTxt.UseVisualStyleBackColor = true;
            this.btnImportOfTxt.Click += new System.EventHandler(this.btnImportOfTxt_Click);
            // 
            // btnImportOfSiteMap
            // 
            this.btnImportOfSiteMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImportOfSiteMap.Location = new System.Drawing.Point(6, 19);
            this.btnImportOfSiteMap.Name = "btnImportOfSiteMap";
            this.btnImportOfSiteMap.Size = new System.Drawing.Size(133, 23);
            this.btnImportOfSiteMap.TabIndex = 2;
            this.btnImportOfSiteMap.Text = "Из файла sitemap";
            this.btnImportOfSiteMap.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 378);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(134, 34);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddSiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(304, 423);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAddPage);
            this.Controls.Add(this.groupBoxPages);
            this.Controls.Add(this.groupBoxSite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSiteForm";
            this.Text = "AddSite";
            this.Load += new System.EventHandler(this.AddSite_Load);
            this.groupBoxSite.ResumeLayout(false);
            this.groupBoxSite.PerformLayout();
            this.groupBoxPages.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBoxAddPage.ResumeLayout(false);
            this.groupBoxAddPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSite;
        private System.Windows.Forms.TextBox txtBoxSite;
        private System.Windows.Forms.GroupBox groupBoxPages;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.GroupBox groupBoxAddPage;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.TextBox txtBoxPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImportOfTxt;
        private System.Windows.Forms.Button btnImportOfSiteMap;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}