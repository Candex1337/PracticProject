using System;
using System.Windows.Forms;
using EquipmentAccounting.DAL.Entities;
using System.ComponentModel;

namespace EquipmentAccounting.WinFormsUI
{
    public partial class DepartmentEditForm : Form
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Department Department { get; set; }

        public DepartmentEditForm()
        {
            InitializeComponent();
        }

        private void DepartmentEditForm_Load(object sender, EventArgs e)
        {
            if (Department != null)
            {
                nameTextBox.Text = Department.Name;
                headTextBox.Text = Department.HeadName;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show(
                    "Поле 'Название' не может быть пустым",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (Department == null)
                Department = new Department();

            Department.Name = nameTextBox.Text;
            Department.HeadName = headTextBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
