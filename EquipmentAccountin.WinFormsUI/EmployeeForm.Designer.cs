namespace EquipmentAccountin.WinFormsUI
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            employeesGridView = new DataGridView();
            editButton = new Button();
            addButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)employeesGridView).BeginInit();
            SuspendLayout();
            // 
            // employeesGridView
            // 
            employeesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesGridView.Location = new Point(12, 12);
            employeesGridView.Name = "employeesGridView";
            employeesGridView.Size = new Size(459, 216);
            employeesGridView.TabIndex = 0;
            employeesGridView.CellContentClick += employeesGridView_CellContentClick;
            // 
            // editButton
            // 
            editButton.Location = new Point(157, 234);
            editButton.Name = "editButton";
            editButton.Size = new Size(161, 23);
            editButton.TabIndex = 2;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 234);
            addButton.Name = "addButton";
            addButton.Size = new Size(139, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(324, 234);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(147, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 274);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(employeesGridView);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)employeesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView employeesGridView;
        private Button editButton;
        private Button addButton;
        private Button deleteButton;
    }
}