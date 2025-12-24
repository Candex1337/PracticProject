using EquipmentAccounting.BLL.Services;
using EquipmentAccounting.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipmentAccountin.WinFormsUI
{
    public partial class SoftwareLicenseForm : Form
    {
        private SoftwareLicenseService service = new SoftwareLicenseService();
        public SoftwareLicenseForm()
        {
            InitializeComponent();
            service = new SoftwareLicenseService();
        }

        private void SoftwareLicenseForm_Load(object sender, EventArgs e)
        {
            LoadLicenses();
        }

        private void LoadLicenses()
        {
            licensesGridView.DataSource = null;
            licensesGridView.DataSource = service.GetAll();
            licensesGridView.Columns["EquipmentSoftwares"].Visible = false;
        }

        private void licensesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var editForm = new SoftwareLicenseEditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                service.Add(editForm.License);
                LoadLicenses();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (licensesGridView.CurrentRow == null)
                return;

            var license = (SoftwareLicense)licensesGridView.CurrentRow.DataBoundItem;

            if (MessageBox.Show(
                "Удалить лицензию?",
                "Подтверждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                service.Delete(license.Id);
                LoadLicenses();
            }
        }


    }
}
