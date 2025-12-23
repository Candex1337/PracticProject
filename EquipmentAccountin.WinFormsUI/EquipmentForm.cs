using EquipmentAccounting.BLL;
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
    public partial class EquipmentForm : Form
    {
        private EquipmentTypeService typeService;
        private EmployeeService employeeService;
        private EquipmentStatusService statusService;
        private EquipmentService equipmentService;
        public EquipmentForm()
        {
            InitializeComponent();

            typeService = new EquipmentTypeService();
            employeeService = new EmployeeService();
            statusService = new EquipmentStatusService();
            equipmentService = new EquipmentService();
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadEquipment();
        }

        private void LoadComboBoxes()
        {
            typeComboBox.DataSource = null;
            typeComboBox.DataSource = typeService.GetAll();
            typeComboBox.DisplayMember = "Name";
            typeComboBox.ValueMember = "Id";
            typeComboBox.SelectedIndex = -1;

            // Сотрудники
            employeeComboBox.DataSource = null;
            employeeComboBox.DataSource = employeeService.GetAll();
            employeeComboBox.DisplayMember = "FullName";
            employeeComboBox.ValueMember = "Id";
            employeeComboBox.SelectedIndex = -1;

            // Статусы
            statusComboBox.DataSource = null;
            statusComboBox.DataSource = statusService.GetAll();
            statusComboBox.DisplayMember = "Name";
            statusComboBox.ValueMember = "Id";
            statusComboBox.SelectedIndex = -1;
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeComboBox.SelectedItem == null)
                return;

            MessageBox.Show(
                $"Выбран сотрудник: {employeeComboBox.Text}",
                "Фильтр",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadEquipment()
        {
            equipmentListBox.DataSource = null;
            equipmentListBox.DataSource = equipmentService.GetAll();
            equipmentListBox.DisplayMember = "InventoryNumber";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string inventory = searchTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(inventory))
            {
                LoadEquipment();
                return;
            }

            var filtered = equipmentService.GetAll()
                .Where(e => e.InventoryNumber != null &&
                            e.InventoryNumber.ToLower().Contains(inventory))
                .ToList();

            equipmentListBox.DataSource = null;
            equipmentListBox.DataSource = filtered;
            equipmentListBox.DisplayMember = "InventoryNumber";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (equipmentListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите оборудование");
                return;
            }

            if (employeeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            var equipment = (Equipment)equipmentListBox.SelectedItem;

            int? oldEmployeeId = equipment.EmployeeId;
            int newEmployeeId = (int)employeeComboBox.SelectedValue;

            // ЕСЛИ СОТРУДНИК ПОМЕНЯЛСЯ → ПИШЕМ В ИСТОРИЮ
            if (oldEmployeeId != newEmployeeId)
            {
                var historyService = new EquipmentHistoryService();
                historyService.Add(
                    equipment.Id,
                    oldEmployeeId,
                    newEmployeeId
                );
            }

            // ОБНОВЛЯЕМ ОБОРУДОВАНИЕ
            equipment.EmployeeId = newEmployeeId;
            equipmentService.Update(equipment);

            MessageBox.Show("Изменения сохранены");
            LoadEquipment();
        }

        private void softwareButton_Click(object sender, EventArgs e)
        {
            if (equipmentListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите оборудование");
                return;
            }

            var equipment = (Equipment)equipmentListBox.SelectedItem;

            var form = new EquipmentSoftwareForm(equipment.Id);
            form.ShowDialog();
        }

    }
}
