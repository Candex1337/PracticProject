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
    public partial class SoftwareLicenseEditForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SoftwareLicense License { get; set; }

        public SoftwareLicenseEditForm()
        {
            InitializeComponent();
        }

        private void SoftwareLicenseEditForm_Load(object sender, EventArgs e)
        {
            if (License != null)
            {
                nameTextBox.Text = License.Name;
                keyTextBox.Text = License.LicenseKey;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Введите название ПО");
                return;
            }

            if (string.IsNullOrWhiteSpace(keyTextBox.Text))
            {
                MessageBox.Show("Введите ключ лицензии");
                return;
            }

            if (License == null)
                License = new SoftwareLicense();

            License.Name = nameTextBox.Text;
            License.LicenseKey = keyTextBox.Text;

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
