using SageReportsApp.Data;
using SageReportsApp.Models;
using SageReportsApp.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SageReportsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _db;
        private SourceSystem selectedSource;
        public MainForm()
        {
            _db = new AppDbContext();
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeComboSource();
            textBoxYear.Text = (DateTime.Now.Year - 1).ToString();
        }

        private void InitializeComboSource()
        {
            comboSource.SelectedIndexChanged += ComboSource_SelectedIndexChanged;
            comboSource.SelectedItem = null;
            comboSource.Text = "";
            comboSource.DisplayMember = "Description";
            comboSource.ValueMember = "SourceSystemId";
            comboSource.DataSource = _db.SourceSystems.ToList();
            if (comboSource.Items.Count > 0)
            {
                comboSource.SelectedIndex = 0;
            }

        }

        private void ComboSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            var source = (SourceSystem)comboSource.SelectedItem;
            if (source != null)
                if (comboSource.Items.Count > 0)
                {
                    selectedSource = _db.SourceSystems.FirstOrDefault(s => s.SourceSystemId == source.SourceSystemId);
                }
                else
                {
                    selectedSource = null;
                }
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
            SetSourceSystems setSourceSystems = new(_db);
            setSourceSystems.FormClosed += SetSourceSystems_FormClosed;
            setSourceSystems.Show();
        }

        private void SetSourceSystems_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeComboSource();
        }

        private async void buttonReadData_Click(object sender, EventArgs e)
        {
            if (selectedSource != null)
            {
                try
                {
                    var source = (SourceSystem)comboSource.SelectedItem;
                    SageDataService sageDataService = new SageDataService(
                        $"Server={source.Address};" +
                        $"Database={source.DbName};" +
                        $"User id={source.Username};" +
                        $"Password={source.Password};");
                    var salesData = await sageDataService.GetVatRegisterDataAsync(2, int.Parse(textBoxYear.Text));
                    var purchaseData = await sageDataService.GetVatRegisterDataAsync(1, int.Parse(textBoxYear.Text));
                    dataGridPurchase.DataSource = purchaseData;
                    dataGridSale.DataSource = salesData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.InnerException != null ? ex.InnerException.Message : ex.Message,
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Wybierz źródło i poprawnie wpisz rok", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
