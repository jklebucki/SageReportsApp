using Microsoft.EntityFrameworkCore;
using SageReportsApp.Data;
using SageReportsApp.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SageReportsApp.Forms
{
    public partial class SetRelatedFirms : Form
    {
        private readonly AppDbContext _db;
        private DataGridViewRow selectedFirm;
        public SetRelatedFirms(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }
        private async void FillDataGrid()
        {
            dataGridRelatedFirms.DataSource = await _db.RelatedFirms.ToListAsync();
            dataGridRelatedFirms.Columns[0].Visible = false;
            dataGridRelatedFirms.Columns[1].HeaderCell.Value = "FK ID";
            dataGridRelatedFirms.Columns[2].HeaderCell.Value = "Nazwa firmy";
            dataGridRelatedFirms.Columns[3].HeaderCell.Value = "Nip";
        }
        private void SetRelatedFirms_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxErpId.Text))
            {
                await _db.AddAsync(GetFormData());
                await _db.SaveChangesAsync();
                FillDataGrid();
            }
            else
            {
                MessageBox.Show(this, "Pole FK ID musi być wypelnione!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private RelatedFirm GetFormData()
        {
            return new RelatedFirm
            {
                ErpSystemId = textBoxErpId.Text,
                Name = textBoxName.Text,
                VatId = textBoxVatId.Text
            };
        }

        private void dataGridRelatedFirms_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedFirm = dataGridRelatedFirms.Rows[e.RowIndex];
            FillForm(GetSelectedRow(selectedFirm));
        }

        private void FillForm(RelatedFirm relatedFirm)
        {
            textBoxErpId.Text = relatedFirm.ErpSystemId;
            textBoxName.Text = relatedFirm.Name;
            textBoxVatId.Text = relatedFirm.VatId;
        }
        private void ClearForm()
        {
            textBoxErpId.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxVatId.Text = string.Empty;
        }

        private RelatedFirm GetSelectedRow(DataGridViewRow dataRow)
        {
            return new RelatedFirm
            {
                RelatedFirmId = (int)dataRow.Cells[0].Value,
                ErpSystemId = dataRow.Cells[1].Value.ToString(),
                Name = dataRow.Cells[2].Value.ToString(),
                VatId = dataRow.Cells[3].Value.ToString()
            };
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (selectedFirm != null && !string.IsNullOrEmpty(textBoxErpId.Text))
            {
                var itemToUpdate = await _db.RelatedFirms.FirstOrDefaultAsync(f => f.RelatedFirmId == (int)selectedFirm.Cells[0].Value);
                itemToUpdate.ErpSystemId = textBoxErpId.Text;
                itemToUpdate.Name = textBoxName.Text;
                itemToUpdate.VatId = textBoxVatId.Text;
                _db.Entry(itemToUpdate).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                FillDataGrid();
                selectedFirm = null;
            }
        }

        private async void buttonRemove_Click(object sender, EventArgs e)
        {
            if (selectedFirm != null)
            {
                var itemToDelete = await _db.RelatedFirms.FirstOrDefaultAsync(f => f.RelatedFirmId == (int)selectedFirm.Cells[0].Value);
                _db.Remove(itemToDelete);
                await _db.SaveChangesAsync();
                FillDataGrid();
                ClearForm();
                selectedFirm = null;
            }
        }
    }
}

