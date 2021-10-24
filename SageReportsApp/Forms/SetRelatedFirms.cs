using Microsoft.EntityFrameworkCore;
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
    public partial class SetRelatedFirms : Form
    {
        private readonly AppDbContext _db;
        public SetRelatedFirms(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void SetRelatedFirms_Load(object sender, EventArgs e)
        {
            dataGridRelatedFirms.DataSource = _db.RelatedFirms.ToList();
        }
    }
}

