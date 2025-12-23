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
    public partial class EquipmentSoftwareForm : Form
    {
        private readonly int _equipmentId;

        private readonly SoftwareLicenseService licenseService;
        private readonly EquipmentSoftwareService equipmentSoftwareService;
        public EquipmentSoftwareForm(int equipmentId)
        {
            InitializeComponent();
            _equipmentId = equipmentId;
            licenseService = new SoftwareLicenseService();
            equipmentSoftwareService = new EquipmentSoftwareService();
        }

        private void EquipmentSoftwareForm_Load(object sender, EventArgs e)
        {
            LoadLicenses();
            LoadInstalledSoftware();
        }

        private void LoadInstalledSoftware()
        {
            softwareListBox.DataSource = null;
            softwareListBox.DataSource = equipmentSoftwareService.GetByEquipment(_equipmentId);
            softwareListBox.DisplayMember = "SoftwareLicenseName";
        }
        private void LoadLicenses()
        {
            licenseComboBox.DataSource = null;
            licenseComboBox.DataSource = licenseService.GetAll();
            licenseComboBox.DisplayMember = "Name";
            licenseComboBox.ValueMember = "Id";
            licenseComboBox.SelectedIndex = -1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (equipmentListBox.SelectedItem == null ||
                licenseComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите оборудование и лицензию");
                return;
            }

            int equipmentId = ((Equipment)equipmentListBox.SelectedItem).Id;
            int licenseId = ((SoftwareLicense)licenseComboBox.SelectedItem).Id;

            equipmentSoftwareService.Install(equipmentId, licenseId);

            LoadInstalledSoftware();
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            if (softwareListBox.SelectedItem == null)
                return;

            var item = (EquipmentSoftware)softwareListBox.SelectedItem;

            equipmentSoftwareService.Delete(item.Id);

            LoadInstalledSoftware();
        }
    }
}
