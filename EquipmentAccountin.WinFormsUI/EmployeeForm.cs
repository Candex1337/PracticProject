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
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавление сотрудника");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Редактирование сотрудника");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление сотрудника");
        }

        private void employeesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
