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

            employeeComboBox.DataSource = null;
            employeeComboBox.DataSource = employeeService.GetAllForGrid();
            employeeComboBox.DisplayMember = "FullName";
            employeeComboBox.ValueMember = "Id";
            employeeComboBox.SelectedIndex = -1;

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
            if (equipmentListBox.SelectedItem == null ||
                employeeComboBox.SelectedItem == null ||
                typeComboBox.SelectedValue == null ||
                statusComboBox.SelectedValue == null)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            var equipment = (Equipment)equipmentListBox.SelectedItem;

            int? oldEmployeeId = equipment.EmployeeId;
            int newEmployeeId = (int)employeeComboBox.SelectedValue;

            if (oldEmployeeId != newEmployeeId)
            {
                var historyService = new EquipmentHistoryService();
                historyService.Add(
                    equipment.Id,
                    oldEmployeeId,
                    newEmployeeId
                );
            }


            equipment.EmployeeId = newEmployeeId;
            equipment.EquipmentTypeId = (int)typeComboBox.SelectedValue;
            equipment.EquipmentStatusId = (int)statusComboBox.SelectedValue;

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

        private void equipmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите тип оборудования");
                return;
            }

            if (statusComboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите статус оборудования");
                return;
            }

            var equipment = new Equipment
            {
                Name = "Новое оборудование",
                EquipmentTypeId = (int)typeComboBox.SelectedValue,
                EquipmentStatusId = (int)statusComboBox.SelectedValue,
                EmployeeId = employeeComboBox.SelectedValue as int?
            };

            equipmentService.Add(equipment);
            LoadEquipment();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (equipmentListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите оборудование");
                return;
            }

            var equipment = (Equipment)equipmentListBox.SelectedItem;

            if (MessageBox.Show(
                $"Удалить оборудование {equipment.InventoryNumber}?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try {
                    equipmentService.Delete(equipment.Id);
                    LoadEquipment();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Ошибка удаления",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }
    }
}
