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
        private ReportService reportService;
        public ReportsForm()
        {
            InitializeComponent();
            reportService = new ReportService();
        }
        private void departmentReportButton_Click_1(object sender, EventArgs e)
        {
            reportGridView.DataSource = null;
            reportGridView.AutoGenerateColumns = true;
            reportGridView.DataSource = reportService.GetEquipmentByDepartments();
        }
        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void reportGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
