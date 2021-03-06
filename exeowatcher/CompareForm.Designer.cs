﻿namespace exeowatcher
{
    partial class CompareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompareForm));
            this.tabControlCompare = new System.Windows.Forms.TabControl();
            this.tabSelect = new System.Windows.Forms.TabPage();
            this.listViewSites = new System.Windows.Forms.ListView();
            this.columnSite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDistinction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPrev = new System.Windows.Forms.TabPage();
            this.richTextBoxPrev = new System.Windows.Forms.RichTextBox();
            this.tabCurrent = new System.Windows.Forms.TabPage();
            this.richTextBoxCurrent = new System.Windows.Forms.RichTextBox();
            this.tabCompare = new System.Windows.Forms.TabPage();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.richTextBoxCompare = new System.Windows.Forms.RichTextBox();
            this.tabControlCompare.SuspendLayout();
            this.tabSelect.SuspendLayout();
            this.tabPrev.SuspendLayout();
            this.tabCurrent.SuspendLayout();
            this.tabCompare.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCompare
            // 
            this.tabControlCompare.Controls.Add(this.tabSelect);
            this.tabControlCompare.Controls.Add(this.tabPrev);
            this.tabControlCompare.Controls.Add(this.tabCurrent);
            this.tabControlCompare.Controls.Add(this.tabCompare);
            this.tabControlCompare.Location = new System.Drawing.Point(12, 12);
            this.tabControlCompare.Name = "tabControlCompare";
            this.tabControlCompare.SelectedIndex = 0;
            this.tabControlCompare.Size = new System.Drawing.Size(792, 453);
            this.tabControlCompare.TabIndex = 0;
            // 
            // tabSelect
            // 
            this.tabSelect.Controls.Add(this.listViewSites);
            this.tabSelect.Location = new System.Drawing.Point(4, 22);
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelect.Size = new System.Drawing.Size(784, 427);
            this.tabSelect.TabIndex = 4;
            this.tabSelect.Text = "Выбор сайта";
            this.tabSelect.UseVisualStyleBackColor = true;
            // 
            // listViewSites
            // 
            this.listViewSites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSite,
            this.columnDistinction});
            this.listViewSites.Location = new System.Drawing.Point(0, 0);
            this.listViewSites.Name = "listViewSites";
            this.listViewSites.Size = new System.Drawing.Size(784, 427);
            this.listViewSites.TabIndex = 1;
            this.listViewSites.UseCompatibleStateImageBehavior = false;
            this.listViewSites.View = System.Windows.Forms.View.Details;
            this.listViewSites.DoubleClick += new System.EventHandler(this.listViewSites_DoubleClick);
            // 
            // columnSite
            // 
            this.columnSite.Text = "Сайт";
            this.columnSite.Width = 720;
            // 
            // columnDistinction
            // 
            this.columnDistinction.Text = "Отличия";
            // 
            // tabPrev
            // 
            this.tabPrev.Controls.Add(this.richTextBoxPrev);
            this.tabPrev.Location = new System.Drawing.Point(4, 22);
            this.tabPrev.Name = "tabPrev";
            this.tabPrev.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrev.Size = new System.Drawing.Size(784, 427);
            this.tabPrev.TabIndex = 1;
            this.tabPrev.Text = "Старая версия";
            this.tabPrev.UseVisualStyleBackColor = true;
            // 
            // richTextBoxPrev
            // 
            this.richTextBoxPrev.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.richTextBoxPrev.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxPrev.Name = "richTextBoxPrev";
            this.richTextBoxPrev.ReadOnly = true;
            this.richTextBoxPrev.Size = new System.Drawing.Size(784, 424);
            this.richTextBoxPrev.TabIndex = 0;
            this.richTextBoxPrev.Text = "";
            // 
            // tabCurrent
            // 
            this.tabCurrent.Controls.Add(this.richTextBoxCurrent);
            this.tabCurrent.Location = new System.Drawing.Point(4, 22);
            this.tabCurrent.Name = "tabCurrent";
            this.tabCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrent.Size = new System.Drawing.Size(784, 427);
            this.tabCurrent.TabIndex = 2;
            this.tabCurrent.Text = "Новая версия";
            this.tabCurrent.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCurrent
            // 
            this.richTextBoxCurrent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.richTextBoxCurrent.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxCurrent.Name = "richTextBoxCurrent";
            this.richTextBoxCurrent.ReadOnly = true;
            this.richTextBoxCurrent.Size = new System.Drawing.Size(784, 424);
            this.richTextBoxCurrent.TabIndex = 1;
            this.richTextBoxCurrent.Text = "";
            // 
            // tabCompare
            // 
            this.tabCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.tabCompare.Controls.Add(this.lblRed);
            this.tabCompare.Controls.Add(this.lblGreen);
            this.tabCompare.Controls.Add(this.richTextBoxCompare);
            this.tabCompare.Location = new System.Drawing.Point(4, 22);
            this.tabCompare.Name = "tabCompare";
            this.tabCompare.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompare.Size = new System.Drawing.Size(784, 427);
            this.tabCompare.TabIndex = 3;
            this.tabCompare.Text = "Сравнение";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(154, 408);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(131, 13);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "Красный цвет - Удалено";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.ForeColor = System.Drawing.Color.Green;
            this.lblGreen.Location = new System.Drawing.Point(4, 408);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(144, 13);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "Зелёный цвет - Добавлено";
            // 
            // richTextBoxCompare
            // 
            this.richTextBoxCompare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxCompare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCompare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.richTextBoxCompare.Location = new System.Drawing.Point(0, 1);
            this.richTextBoxCompare.Name = "richTextBoxCompare";
            this.richTextBoxCompare.ReadOnly = true;
            this.richTextBoxCompare.Size = new System.Drawing.Size(784, 404);
            this.richTextBoxCompare.TabIndex = 1;
            this.richTextBoxCompare.Text = "";
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(816, 477);
            this.Controls.Add(this.tabControlCompare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompareForm";
            this.Text = "Просмотр различий";
            this.Load += new System.EventHandler(this.CompareForm_Load);
            this.tabControlCompare.ResumeLayout(false);
            this.tabSelect.ResumeLayout(false);
            this.tabPrev.ResumeLayout(false);
            this.tabCurrent.ResumeLayout(false);
            this.tabCompare.ResumeLayout(false);
            this.tabCompare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCompare;
        private System.Windows.Forms.TabPage tabPrev;
        private System.Windows.Forms.RichTextBox richTextBoxPrev;
        private System.Windows.Forms.TabPage tabCurrent;
        private System.Windows.Forms.RichTextBox richTextBoxCurrent;
        private System.Windows.Forms.TabPage tabCompare;
        private System.Windows.Forms.RichTextBox richTextBoxCompare;
        private System.Windows.Forms.TabPage tabSelect;
        private System.Windows.Forms.ListView listViewSites;
        private System.Windows.Forms.ColumnHeader columnSite;
        private System.Windows.Forms.ColumnHeader columnDistinction;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
    }
}