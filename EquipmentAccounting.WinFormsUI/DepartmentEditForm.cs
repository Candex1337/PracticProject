using System;

using System.Windows.Forms;
using EquipmentAccounting.DAL.Entities;


namespace EquipmentAccounting.WinFormsUI
{
    public partial class DepartmentEditForm : Form
    {
        public Department Department { get; set; }

        public DepartmentEditForm()
        {
            InitializeComponent();
        }

        private void DepartmentEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
