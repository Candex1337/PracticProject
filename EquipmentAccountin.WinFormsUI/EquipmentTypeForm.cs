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
    public partial class EquipmentTypeForm : Form
    {
        private readonly EquipmentTypeService service;
        public EquipmentTypeForm()
        {
            InitializeComponent();
            service = new EquipmentTypeService();
        }

        private void employeesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EquipmentTypeForm_Load(object sender, EventArgs e)
        {
            LoadTypes();
        }

        private void LoadTypes()
        {
            typesGridView.DataSource = null;
            typesGridView.DataSource = service.GetAll();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var editForm = new EquipmentTypeEditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                service.Add(editForm.EquipmentType);
                LoadTypes();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (typesGridView.CurrentRow == null)
                return;

            var type = (EquipmentType)typesGridView.CurrentRow.DataBoundItem;

            if (MessageBox.Show(
                "Удалить тип оборудования?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                service.Delete(type.Id);
                LoadTypes();
            }
        }
    }
}
