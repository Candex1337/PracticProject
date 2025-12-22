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
    public partial class EquipmentForm : Form, IDataObserver
    {
        private EquipmentTypeService typeService;
        private EmployeeService employeeService;
        private EquipmentStatusService statusService;
        public EquipmentForm()
        {
            InitializeComponent();

            typeService = new EquipmentTypeService();
            employeeService = new EmployeeService();
            statusService = new EquipmentStatusService();

            typeService.AddObserver(this);
        }

        public void UpdateData()
        {
            LoadComboBoxes();
        }


        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            typeComboBox.DataSource = typeService.GetAll();
            typeComboBox.DisplayMember = "Name";
            typeComboBox.ValueMember = "Id";
            typeComboBox.SelectedIndex = -1;

            employeeComboBox.DataSource = employeeService.GetAll();
            employeeComboBox.DisplayMember = "FullName";
            employeeComboBox.ValueMember = "Id";
            employeeComboBox.SelectedIndex = -1;

            statusComboBox.DataSource = statusService.GetAll();
            statusComboBox.DisplayMember = "Name";
            statusComboBox.ValueMember = "Id";
            statusComboBox.SelectedIndex = -1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedItem == null ||
                employeeComboBox.SelectedItem == null ||
                statusComboBox.SelectedItem == null)
            {
                MessageBox.Show(
                    "Выберите тип оборудования, сотрудника и статус",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Equipment equipment = new Equipment
            {
                EquipmentTypeId = (int)typeComboBox.SelectedValue,
                DepartmentId = ((Employee)employeeComboBox.SelectedItem).DepartmentId,
                EquipmentStatusId = (int)statusComboBox.SelectedValue,
            };

            MessageBox.Show(
                "Оборудование создано (каркас)",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
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
    }
}
