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
    public partial class EmployeeEditForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Employee Employee { get; set; }

        private DepartmentService departmentService = new DepartmentService();
        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            departmentComboBox.DataSource = departmentService.GetAll();
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";

            if (Employee != null)
            {
                fullNameTextBox.Text = Employee.FullName;
                positionTextBox.Text = Employee.Position;
                departmentComboBox.SelectedValue = Employee.DepartmentId;
            }
            else
            {
                departmentComboBox.SelectedIndex = -1;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(positionTextBox.Text) ||
                departmentComboBox.SelectedItem == null)
            {
                MessageBox.Show(
                    "Заполните все поля",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (Employee == null)
                Employee = new Employee();

            Employee.FullName = fullNameTextBox.Text;
            Employee.Position = positionTextBox.Text;
            Employee.DepartmentId =
                (int)departmentComboBox.SelectedValue;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
