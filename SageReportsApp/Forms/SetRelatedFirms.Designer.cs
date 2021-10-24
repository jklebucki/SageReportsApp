
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
            this.splitRelatedFirms = new System.Windows.Forms.SplitContainer();
            this.dataGridRelatedFirms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitRelatedFirms)).BeginInit();
            this.splitRelatedFirms.Panel2.SuspendLayout();
            this.splitRelatedFirms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatedFirms)).BeginInit();
            this.SuspendLayout();
            // 
            // splitRelatedFirms
            // 
            this.splitRelatedFirms.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitRelatedFirms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRelatedFirms.Location = new System.Drawing.Point(0, 0);
            this.splitRelatedFirms.Name = "splitRelatedFirms";
            this.splitRelatedFirms.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRelatedFirms.Panel2
            // 
            this.splitRelatedFirms.Panel2.Controls.Add(this.dataGridRelatedFirms);
            this.splitRelatedFirms.Size = new System.Drawing.Size(800, 450);
            this.splitRelatedFirms.SplitterDistance = 78;
            this.splitRelatedFirms.TabIndex = 0;
            // 
            // dataGridRelatedFirms
            // 
            this.dataGridRelatedFirms.AllowUserToAddRows = false;
            this.dataGridRelatedFirms.AllowUserToDeleteRows = false;
            this.dataGridRelatedFirms.AllowUserToOrderColumns = true;
            this.dataGridRelatedFirms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRelatedFirms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRelatedFirms.Location = new System.Drawing.Point(0, 0);
            this.dataGridRelatedFirms.Name = "dataGridRelatedFirms";
            this.dataGridRelatedFirms.ReadOnly = true;
            this.dataGridRelatedFirms.RowHeadersWidth = 51;
            this.dataGridRelatedFirms.RowTemplate.Height = 29;
            this.dataGridRelatedFirms.Size = new System.Drawing.Size(800, 368);
            this.dataGridRelatedFirms.TabIndex = 0;
            // 
            // SetRelatedFirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitRelatedFirms);
            this.Name = "SetRelatedFirms";
            this.Text = "SetRelatedFirms";
            this.Load += new System.EventHandler(this.SetRelatedFirms_Load);
            this.splitRelatedFirms.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRelatedFirms)).EndInit();
            this.splitRelatedFirms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatedFirms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitRelatedFirms;
        private System.Windows.Forms.DataGridView dataGridRelatedFirms;
    }
}