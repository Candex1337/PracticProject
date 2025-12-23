using System;
using System.Windows.Forms;
using EquipmentAccounting.BLL.Services;
using EquipmentAccounting.DAL.Entities;

namespace EquipmentAccounting.WinFormsUI
{
    public partial class DepartmentForm : Form
    {
        private DepartmentService service = new DepartmentService();

        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            departmentsGridView.DataSource = null;
            departmentsGridView.DataSource = service.GetAll();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var editForm = new DepartmentEditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                service.Add(editForm.Department);
                LoadDepartments();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (departmentsGridView.CurrentRow == null)
                return;

            var department =
                (Department)departmentsGridView.CurrentRow.DataBoundItem;

            var editForm = new DepartmentEditForm();
            editForm.Department = department;

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                service.Update(editForm.Department);
                LoadDepartments();
            }
        }

        private void departmentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (departmentsGridView.CurrentRow == null)
                return;

            var department =
                (Department)departmentsGridView.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                $"Удалить подразделение \"{department.Name}\"?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                service.Delete(department.Id);
                LoadDepartments();
            }
        }
    }
}
