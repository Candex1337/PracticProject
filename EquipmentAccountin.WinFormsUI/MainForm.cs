using EquipmentAccountin.WinFormsUI;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentAccounting.WinFormsUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void navigationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (navigationListBox.SelectedItem == null)
                return;

            string selected = navigationListBox.SelectedItem.ToString();

            switch (selected)
            {
                case "Подразделения":
                    new DepartmentForm().ShowDialog();
                    break;

                case "Сотрудники":
                    new EmployeeForm().ShowDialog();
                    break;

                case "Оборудование":
                    new EquipmentForm().ShowDialog();
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
