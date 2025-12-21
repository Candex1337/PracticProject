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
            if (Department != null)
            {
                nameTextBox.Text = Department.Name;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // 🔴 ВАЛИДАЦИЯ
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

            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
