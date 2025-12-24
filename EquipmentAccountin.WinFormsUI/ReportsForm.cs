using EquipmentAccounting.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipmentAccountin.WinFormsUI
{
    public partial class ReportsForm : Form
    {
        private readonly ReportService reportService;
        private readonly EmployeeService employeeService;

        public ReportsForm()
        {
            InitializeComponent();
            reportService = new ReportService();
            employeeService = new EmployeeService();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            employeeComboBox.DataSource = employeeService.GetAll();
            employeeComboBox.DisplayMember = "FullName";
            employeeComboBox.ValueMember = "Id";
            employeeComboBox.SelectedIndex = -1;
        }

        private void softwareByEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            int employeeId = (int)employeeComboBox.SelectedValue;

            reportGridView.DataSource = null;
            reportGridView.DataSource =
                reportService.GetSoftwareByEmployee(employeeId);
        }

        private void departmentReportButton_Click(object sender, EventArgs e)
        {
            reportGridView.DataSource = null;
            reportGridView.DataSource = reportService.GetEquipmentByDepartments();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
