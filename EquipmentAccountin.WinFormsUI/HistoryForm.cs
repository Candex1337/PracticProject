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
    public partial class HistoryForm : Form
    {
        private EquipmentHistoryService historyService = new EquipmentHistoryService();
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            historyGridView.DataSource = historyService.GetAll();
        }

        private void historyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
