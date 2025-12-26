namespace EquipmentAccountin.WinFormsUI
{
    partial class EquipmentForm
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
            typeComboBox = new ComboBox();
            employeeComboBox = new ComboBox();
            statusComboBox = new ComboBox();
            searchTextBox = new TextBox();
            label1 = new Label();
            searchButton = new Button();
            equipmentListBox = new ListBox();
            saveButton = new Button();
            softwareButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            addButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(196, 30);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(195, 23);
            typeComboBox.TabIndex = 0;
            // 
            // employeeComboBox
            // 
            employeeComboBox.FormattingEnabled = true;
            employeeComboBox.Location = new Point(196, 74);
            employeeComboBox.Name = "employeeComboBox";
            employeeComboBox.Size = new Size(195, 23);
            employeeComboBox.TabIndex = 1;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(196, 118);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(195, 23);
            statusComboBox.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(196, 192);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(121, 23);
            searchTextBox.TabIndex = 3;
            searchTextBox.Click += searchTextBox_TextChanged;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 174);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 4;
            label1.Text = "Поиск по инвентарному номеру";
            label1.Click += label1_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(323, 192);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(68, 23);
            searchButton.TabIndex = 5;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // equipmentListBox
            // 
            equipmentListBox.FormattingEnabled = true;
            equipmentListBox.Location = new Point(12, 12);
            equipmentListBox.Name = "equipmentListBox";
            equipmentListBox.Size = new Size(178, 214);
            equipmentListBox.TabIndex = 6;
            equipmentListBox.SelectedIndexChanged += equipmentListBox_SelectedIndexChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(196, 233);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 7;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // softwareButton
            // 
            softwareButton.Location = new Point(277, 233);
            softwareButton.Name = "softwareButton";
            softwareButton.Size = new Size(114, 23);
            softwareButton.TabIndex = 8;
            softwareButton.Text = "Софт";
            softwareButton.UseVisualStyleBackColor = true;
            softwareButton.Click += softwareButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 12);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 9;
            label2.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 56);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 10;
            label3.Text = "Сотрудник";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 100);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 11;
            label4.Text = "Статус";
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 232);
            addButton.Name = "addButton";
            addButton.Size = new Size(85, 23);
            addButton.TabIndex = 12;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(103, 233);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(87, 23);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 267);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(softwareButton);
            Controls.Add(saveButton);
            Controls.Add(equipmentListBox);
            Controls.Add(searchButton);
            Controls.Add(label1);
            Controls.Add(searchTextBox);
            Controls.Add(statusComboBox);
            Controls.Add(employeeComboBox);
            Controls.Add(typeComboBox);
            Name = "EquipmentForm";
            Text = "EquipmentForm";
            Load += EquipmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox typeComboBox;
        private ComboBox employeeComboBox;
        private ComboBox statusComboBox;
        private TextBox searchTextBox;
        private Label label1;
        private Button searchButton;
        private ListBox equipmentListBox;
        private Button saveButton;
        private Button softwareButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button addButton;
        private Button deleteButton;
    }
}