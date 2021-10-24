﻿
namespace SageReportsApp.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutMenu = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.reportRegisters = new System.Windows.Forms.TabPage();
            this.dataGridRegisters = new System.Windows.Forms.DataGridView();
            this.reportDocuments = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatedFirmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridDocuments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.reportRegisters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegisters)).BeginInit();
            this.reportDocuments.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(969, 532);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutMenu
            // 
            this.tableLayoutMenu.ColumnCount = 4;
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMenu.Name = "tableLayoutMenu";
            this.tableLayoutMenu.RowCount = 2;
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMenu.Size = new System.Drawing.Size(969, 56);
            this.tableLayoutMenu.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.reportRegisters);
            this.tabControl1.Controls.Add(this.reportDocuments);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // reportRegisters
            // 
            this.reportRegisters.Controls.Add(this.dataGridRegisters);
            this.reportRegisters.Location = new System.Drawing.Point(4, 29);
            this.reportRegisters.Name = "reportRegisters";
            this.reportRegisters.Padding = new System.Windows.Forms.Padding(3);
            this.reportRegisters.Size = new System.Drawing.Size(961, 442);
            this.reportRegisters.TabIndex = 0;
            this.reportRegisters.Text = "Zestawienie - rejestr";
            this.reportRegisters.UseVisualStyleBackColor = true;
            // 
            // dataGridRegisters
            // 
            this.dataGridRegisters.AllowUserToAddRows = false;
            this.dataGridRegisters.AllowUserToDeleteRows = false;
            this.dataGridRegisters.AllowUserToOrderColumns = true;
            this.dataGridRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRegisters.Location = new System.Drawing.Point(3, 3);
            this.dataGridRegisters.Name = "dataGridRegisters";
            this.dataGridRegisters.ReadOnly = true;
            this.dataGridRegisters.RowHeadersWidth = 51;
            this.dataGridRegisters.RowTemplate.Height = 29;
            this.dataGridRegisters.Size = new System.Drawing.Size(955, 436);
            this.dataGridRegisters.TabIndex = 0;
            // 
            // reportDocuments
            // 
            this.reportDocuments.Controls.Add(this.dataGridDocuments);
            this.reportDocuments.Location = new System.Drawing.Point(4, 29);
            this.reportDocuments.Name = "reportDocuments";
            this.reportDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.reportDocuments.Size = new System.Drawing.Size(961, 442);
            this.reportDocuments.TabIndex = 1;
            this.reportDocuments.Text = "Powiązane dokumenty";
            this.reportDocuments.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatedFirmsToolStripMenuItem,
            this.sourceSystemToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // relatedFirmsToolStripMenuItem
            // 
            this.relatedFirmsToolStripMenuItem.Name = "relatedFirmsToolStripMenuItem";
            this.relatedFirmsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.relatedFirmsToolStripMenuItem.Text = "Podmioty powiązane";
            this.relatedFirmsToolStripMenuItem.Click += new System.EventHandler(this.relatedFirmsToolStripMenuItem_Click);
            // 
            // sourceSystemToolStripMenuItem
            // 
            this.sourceSystemToolStripMenuItem.Name = "sourceSystemToolStripMenuItem";
            this.sourceSystemToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.sourceSystemToolStripMenuItem.Text = "System źródłowy";
            this.sourceSystemToolStripMenuItem.Click += new System.EventHandler(this.sourceSystemToolStripMenuItem_Click);
            // 
            // dataGridDocuments
            // 
            this.dataGridDocuments.AllowUserToAddRows = false;
            this.dataGridDocuments.AllowUserToDeleteRows = false;
            this.dataGridDocuments.AllowUserToOrderColumns = true;
            this.dataGridDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDocuments.Location = new System.Drawing.Point(3, 3);
            this.dataGridDocuments.Name = "dataGridDocuments";
            this.dataGridDocuments.ReadOnly = true;
            this.dataGridDocuments.RowHeadersWidth = 51;
            this.dataGridDocuments.RowTemplate.Height = 29;
            this.dataGridDocuments.Size = new System.Drawing.Size(955, 436);
            this.dataGridDocuments.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 560);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AJK Sage Reports";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.reportRegisters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegisters)).EndInit();
            this.reportDocuments.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage reportRegisters;
        private System.Windows.Forms.TabPage reportDocuments;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatedFirmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceSystemToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridRegisters;
        private System.Windows.Forms.DataGridView dataGridDocuments;
    }
}

