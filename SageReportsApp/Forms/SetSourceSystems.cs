using Microsoft.EntityFrameworkCore;
using SageReportsApp.Data;
using SageReportsApp.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SageReportsApp.Forms
{
    public partial class SetSourceSystems : Form
    {
        private readonly AppDbContext _db;
        public SetSourceSystems(AppDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private void SetSourceSystems_Load(object sender, EventArgs e)
        {
            SetDataGrid();
        }

        private async void SetDataGrid()
        {
            dataGridSourceSystems.DataSource = await _db.SourceSystems.ToListAsync();
            dataGridSourceSystems.Columns[0].Visible = false;
            dataGridSourceSystems.Columns[6].Visible = false;
            dataGridSourceSystems.Columns[7].Visible = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridSourceSystems.SelectedRows.Count == 1)
            {
                UpdateSourceSystem(SetSourceSystem());
            }
            else
            {
                AddSourceSystem(SetSourceSystem());
            }
            SetDataGrid();
        }

        private async void AddSourceSystem(SourceSystem sourceSystem)
        {
            sourceSystem.SourceSystemId = 0;
            await _db.SourceSystems.AddAsync(sourceSystem);
            await _db.SaveChangesAsync();
        }

        private SourceSystem SetSourceSystem()
        {
            return new SourceSystem
            {
                Description = textBoxDesciption.Text,
                Code = textBoxCode.Text,
                Type = textBoxType.Text,
                Address = textBoxAddress.Text,
                DbName = textBoxDbName.Text,
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text
            };
        }

        private void FillSourceSystemData()
        {
            if (dataGridSourceSystems.SelectedRows.Count == 1)
            {
                var row = dataGridSourceSystems.SelectedRows[0];
                textBoxDesciption.Text = row.Cells[1].Value.ToString();
                textBoxCode.Text = row.Cells[2].Value.ToString();
                textBoxType.Text = row.Cells[3].Value.ToString();
                textBoxAddress.Text = row.Cells[4].Value.ToString();
                textBoxDbName.Text = row.Cells[5].Value.ToString();
                textBoxUsername.Text = row.Cells[6].Value.ToString();
                textBoxPassword.Text = row.Cells[7].Value.ToString();
            }
        }

        private SourceSystem GetSourceSystem()
        {
            if (dataGridSourceSystems.SelectedRows.Count == 1)
            {
                var row = dataGridSourceSystems.SelectedRows[0];
                return new SourceSystem
                {
                    SourceSystemId = int.Parse(row.Cells[0].Value.ToString()),
                    Description = row.Cells[1].Value.ToString(),
                    Code = row.Cells[2].Value.ToString(),
                    Type = row.Cells[3].Value.ToString(),
                    Address = row.Cells[4].Value.ToString(),
                    DbName = row.Cells[5].Value.ToString(),
                    Username = row.Cells[6].Value.ToString(),
                    Password = row.Cells[7].Value.ToString(),
                };
            }
            else
                return null;
        }

        private async void UpdateSourceSystem(SourceSystem sourceSystem)
        {
            if (sourceSystem != null)
            {
                var sourceSystemToUpdate = _db.SourceSystems.FirstOrDefault(s => s.SourceSystemId == sourceSystem.SourceSystemId);
                sourceSystemToUpdate.Description = sourceSystem.Description;
                sourceSystemToUpdate.Code = sourceSystem.Code;
                sourceSystemToUpdate.Type = sourceSystem.Type;
                sourceSystemToUpdate.Address = sourceSystem.Address;
                sourceSystemToUpdate.DbName = sourceSystem.DbName;
                sourceSystemToUpdate.Username = sourceSystem.Username;
                sourceSystemToUpdate.Password = sourceSystem.Password;
                _db.Entry(sourceSystemToUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _db.SaveChangesAsync();
                SetDataGrid();
            }
        }

        private async void buttonRemove_Click(object sender, EventArgs e)
        {
            var selectedSourceSystem = GetSourceSystem();
            if (selectedSourceSystem != null)
            {
                var sourceSystemToRemove = _db.SourceSystems.FirstOrDefault(s => s.SourceSystemId == selectedSourceSystem.SourceSystemId);
                _db.SourceSystems.Remove(sourceSystemToRemove);
                await _db.SaveChangesAsync();
            }
            SetDataGrid();
        }

        private void dataGridSourceSystems_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillSourceSystemData();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
