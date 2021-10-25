
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutMenu = new System.Windows.Forms.TableLayoutPanel();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonReadData = new System.Windows.Forms.Button();
            this.comboSource = new System.Windows.Forms.ComboBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.reportSale = new System.Windows.Forms.TabPage();
            this.dataGridSale = new System.Windows.Forms.DataGridView();
            this.reportPurchase = new System.Windows.Forms.TabPage();
            this.dataGridPurchase = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatedFirmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tableLayoutMenu.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.reportSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSale)).BeginInit();
            this.reportPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchase)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Location = new System.Drawing.Point(0, 28);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.tableLayoutMenu);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tabMain);
            this.splitMain.Size = new System.Drawing.Size(1082, 658);
            this.splitMain.SplitterDistance = 100;
            this.splitMain.SplitterWidth = 1;
            this.splitMain.TabIndex = 0;
            // 
            // tableLayoutMenu
            // 
            this.tableLayoutMenu.ColumnCount = 4;
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMenu.Controls.Add(this.labelSource, 0, 0);
            this.tableLayoutMenu.Controls.Add(this.labelYear, 1, 0);
            this.tableLayoutMenu.Controls.Add(this.buttonReadData, 2, 1);
            this.tableLayoutMenu.Controls.Add(this.comboSource, 0, 1);
            this.tableLayoutMenu.Controls.Add(this.textBoxYear, 1, 1);
            this.tableLayoutMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMenu.Name = "tableLayoutMenu";
            this.tableLayoutMenu.RowCount = 3;
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutMenu.Size = new System.Drawing.Size(1082, 100);
            this.tableLayoutMenu.TabIndex = 0;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSource.Location = new System.Drawing.Point(5, 5);
            this.labelSource.Margin = new System.Windows.Forms.Padding(5);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(260, 20);
            this.labelSource.TabIndex = 1;
            this.labelSource.Text = "Źródło";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelYear.Location = new System.Drawing.Point(275, 5);
            this.labelYear.Margin = new System.Windows.Forms.Padding(5);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(260, 20);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Rok";
            // 
            // buttonReadData
            // 
            this.buttonReadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReadData.Location = new System.Drawing.Point(543, 33);
            this.buttonReadData.Name = "buttonReadData";
            this.buttonReadData.Size = new System.Drawing.Size(264, 29);
            this.buttonReadData.TabIndex = 0;
            this.buttonReadData.Text = "Wczytaj dane";
            this.buttonReadData.UseVisualStyleBackColor = true;
            this.buttonReadData.Click += new System.EventHandler(this.buttonReadData_Click);
            // 
            // comboSource
            // 
            this.comboSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboSource.FormattingEnabled = true;
            this.comboSource.Location = new System.Drawing.Point(3, 33);
            this.comboSource.Name = "comboSource";
            this.comboSource.Size = new System.Drawing.Size(264, 28);
            this.comboSource.TabIndex = 3;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxYear.Location = new System.Drawing.Point(273, 33);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(264, 27);
            this.textBoxYear.TabIndex = 4;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.reportSale);
            this.tabMain.Controls.Add(this.reportPurchase);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1082, 557);
            this.tabMain.TabIndex = 0;
            // 
            // reportSale
            // 
            this.reportSale.Controls.Add(this.dataGridSale);
            this.reportSale.Location = new System.Drawing.Point(4, 29);
            this.reportSale.Name = "reportSale";
            this.reportSale.Padding = new System.Windows.Forms.Padding(3);
            this.reportSale.Size = new System.Drawing.Size(1074, 524);
            this.reportSale.TabIndex = 0;
            this.reportSale.Text = "Zestawienie -sprzedaż";
            this.reportSale.UseVisualStyleBackColor = true;
            // 
            // dataGridSale
            // 
            this.dataGridSale.AllowUserToAddRows = false;
            this.dataGridSale.AllowUserToDeleteRows = false;
            this.dataGridSale.AllowUserToOrderColumns = true;
            this.dataGridSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSale.Location = new System.Drawing.Point(3, 3);
            this.dataGridSale.Name = "dataGridSale";
            this.dataGridSale.ReadOnly = true;
            this.dataGridSale.RowHeadersWidth = 51;
            this.dataGridSale.RowTemplate.Height = 29;
            this.dataGridSale.Size = new System.Drawing.Size(1068, 518);
            this.dataGridSale.TabIndex = 0;
            // 
            // reportPurchase
            // 
            this.reportPurchase.Controls.Add(this.dataGridPurchase);
            this.reportPurchase.Location = new System.Drawing.Point(4, 29);
            this.reportPurchase.Name = "reportPurchase";
            this.reportPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.reportPurchase.Size = new System.Drawing.Size(1074, 524);
            this.reportPurchase.TabIndex = 1;
            this.reportPurchase.Text = "Zestawienie - zakup";
            this.reportPurchase.UseVisualStyleBackColor = true;
            // 
            // dataGridPurchase
            // 
            this.dataGridPurchase.AllowUserToAddRows = false;
            this.dataGridPurchase.AllowUserToDeleteRows = false;
            this.dataGridPurchase.AllowUserToOrderColumns = true;
            this.dataGridPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPurchase.Location = new System.Drawing.Point(3, 3);
            this.dataGridPurchase.Name = "dataGridPurchase";
            this.dataGridPurchase.ReadOnly = true;
            this.dataGridPurchase.RowHeadersWidth = 51;
            this.dataGridPurchase.RowTemplate.Height = 29;
            this.dataGridPurchase.Size = new System.Drawing.Size(1068, 518);
            this.dataGridPurchase.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 686);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AJK Sage Reports";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tableLayoutMenu.ResumeLayout(false);
            this.tableLayoutMenu.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.reportSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSale)).EndInit();
            this.reportPurchase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchase)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage reportSale;
        private System.Windows.Forms.TabPage reportPurchase;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatedFirmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceSystemToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridSale;
        private System.Windows.Forms.DataGridView dataGridPurchase;
        private System.Windows.Forms.Button buttonReadData;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox comboSource;
        private System.Windows.Forms.TextBox textBoxYear;
    }
}

