using SageReportsApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SageReportsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _db;
        public MainForm()
        {
            _db = new AppDbContext();
            InitializeComponent();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void relatedFirmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRelatedFirms setRelatedFirms = new(_db);
            setRelatedFirms.Show();
        }

        private void sourceSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSourceSystems setSourceSystems = new();
            setSourceSystems.Show();
        }
    }
}
