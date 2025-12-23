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
    public partial class EmployeeForm : Form
    {
        private EmployeeService service = new EmployeeService();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void LoadEmployees()
        {
            employeesGridView.DataSource = null;
            employeesGridView.DataSource = service.GetAll();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            employeesGridView.DataSource = null;
            employeesGridView.DataSource = service.GetAll();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var editForm = new EmployeeEditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                service.Add(editForm.Employee);
                LoadEmployees();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (employeesGridView.CurrentRow == null)
                return;

            var employee =
                (Employee)employeesGridView.CurrentRow.DataBoundItem;

            var editForm = new EmployeeEditForm();
            editForm.Employee = employee;

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                service.Update(editForm.Employee);
                LoadEmployees();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (employeesGridView.CurrentRow == null)
                return;

            var employee =
                (Employee)employeesGridView.CurrentRow.DataBoundItem;

            if (MessageBox.Show(
                "Удалить сотрудника?",
                "Подтверждение",
                MessageBoxButtons.YesNo
            ) == DialogResult.Yes)
            {
                service.Delete(employee.Id);
                LoadEmployees();
            }
        }

        private void employeesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
