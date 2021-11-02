
namespace SageReportsApp.Forms
{
    partial class SetRelatedFirms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitRelatedFirms = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelErpId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelVatId = new System.Windows.Forms.Label();
            this.textBoxErpId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxVatId = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dataGridRelatedFirms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitRelatedFirms)).BeginInit();
            this.splitRelatedFirms.Panel1.SuspendLayout();
            this.splitRelatedFirms.Panel2.SuspendLayout();
            this.splitRelatedFirms.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatedFirms)).BeginInit();
            this.SuspendLayout();
            // 
            // splitRelatedFirms
            // 
            this.splitRelatedFirms.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitRelatedFirms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRelatedFirms.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitRelatedFirms.IsSplitterFixed = true;
            this.splitRelatedFirms.Location = new System.Drawing.Point(0, 0);
            this.splitRelatedFirms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitRelatedFirms.Name = "splitRelatedFirms";
            this.splitRelatedFirms.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRelatedFirms.Panel1
            // 
            this.splitRelatedFirms.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitRelatedFirms.Panel2
            // 
            this.splitRelatedFirms.Panel2.Controls.Add(this.dataGridRelatedFirms);
            this.splitRelatedFirms.Size = new System.Drawing.Size(923, 408);
            this.splitRelatedFirms.SplitterDistance = 120;
            this.splitRelatedFirms.SplitterWidth = 1;
            this.splitRelatedFirms.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelErpId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelVatId, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxErpId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVatId, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemove, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelErpId
            // 
            this.labelErpId.AutoSize = true;
            this.labelErpId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelErpId.Location = new System.Drawing.Point(4, 12);
            this.labelErpId.Margin = new System.Windows.Forms.Padding(4);
            this.labelErpId.Name = "labelErpId";
            this.labelErpId.Size = new System.Drawing.Size(176, 29);
            this.labelErpId.TabIndex = 0;
            this.labelErpId.Text = "FK ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(4, 49);
            this.labelName.Margin = new System.Windows.Forms.Padding(4);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(176, 29);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nazwa";
            // 
            // labelVatId
            // 
            this.labelVatId.AutoSize = true;
            this.labelVatId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVatId.Location = new System.Drawing.Point(4, 86);
            this.labelVatId.Margin = new System.Windows.Forms.Padding(4);
            this.labelVatId.Name = "labelVatId";
            this.labelVatId.Size = new System.Drawing.Size(176, 30);
            this.labelVatId.TabIndex = 2;
            this.labelVatId.Text = "NIP";
            // 
            // textBoxErpId
            // 
            this.textBoxErpId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxErpId.Location = new System.Drawing.Point(187, 10);
            this.textBoxErpId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxErpId.Name = "textBoxErpId";
            this.textBoxErpId.Size = new System.Drawing.Size(363, 23);
            this.textBoxErpId.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(187, 47);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(363, 23);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxVatId
            // 
            this.textBoxVatId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxVatId.Location = new System.Drawing.Point(187, 84);
            this.textBoxVatId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVatId.Name = "textBoxVatId";
            this.textBoxVatId.Size = new System.Drawing.Size(363, 23);
            this.textBoxVatId.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(740, 10);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(180, 33);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(740, 47);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 33);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Location = new System.Drawing.Point(740, 84);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 34);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Wyjdź";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemove.Location = new System.Drawing.Point(556, 10);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(178, 33);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Usuń";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // dataGridRelatedFirms
            // 
            this.dataGridRelatedFirms.AllowUserToAddRows = false;
            this.dataGridRelatedFirms.AllowUserToDeleteRows = false;
            this.dataGridRelatedFirms.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRelatedFirms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRelatedFirms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRelatedFirms.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRelatedFirms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRelatedFirms.Location = new System.Drawing.Point(0, 0);
            this.dataGridRelatedFirms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridRelatedFirms.Name = "dataGridRelatedFirms";
            this.dataGridRelatedFirms.ReadOnly = true;
            this.dataGridRelatedFirms.RowHeadersWidth = 51;
            this.dataGridRelatedFirms.RowTemplate.Height = 29;
            this.dataGridRelatedFirms.Size = new System.Drawing.Size(923, 287);
            this.dataGridRelatedFirms.TabIndex = 0;
            this.dataGridRelatedFirms.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRelatedFirms_RowEnter);
            // 
            // SetRelatedFirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 408);
            this.Controls.Add(this.splitRelatedFirms);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SetRelatedFirms";
            this.Text = "SetRelatedFirms";
            this.Load += new System.EventHandler(this.SetRelatedFirms_Load);
            this.splitRelatedFirms.Panel1.ResumeLayout(false);
            this.splitRelatedFirms.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRelatedFirms)).EndInit();
            this.splitRelatedFirms.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatedFirms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitRelatedFirms;
        private System.Windows.Forms.DataGridView dataGridRelatedFirms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelErpId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelVatId;
        private System.Windows.Forms.TextBox textBoxErpId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxVatId;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRemove;
    }
}