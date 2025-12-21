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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавление подразделения");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изменение подразделения");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление подразделения");
        }

    }
}
