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
            SuspendLayout();
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(400, 56);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(121, 23);
            typeComboBox.TabIndex = 0;
            // 
            // employeeComboBox
            // 
            employeeComboBox.FormattingEnabled = true;
            employeeComboBox.Location = new Point(400, 85);
            employeeComboBox.Name = "employeeComboBox";
            employeeComboBox.Size = new Size(121, 23);
            employeeComboBox.TabIndex = 1;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(400, 114);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(121, 23);
            statusComboBox.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(334, 198);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(121, 23);
            searchTextBox.TabIndex = 3;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 180);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 4;
            label1.Text = "Поиск по инвентарному номеру";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(334, 227);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 5;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // equipmentListBox
            // 
            equipmentListBox.FormattingEnabled = true;
            equipmentListBox.Location = new Point(215, 56);
            equipmentListBox.Name = "equipmentListBox";
            equipmentListBox.Size = new Size(120, 94);
            equipmentListBox.TabIndex = 6;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(547, 113);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 7;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // softwareButton
            // 
            softwareButton.Location = new Point(532, 272);
            softwareButton.Name = "softwareButton";
            softwareButton.Size = new Size(75, 23);
            softwareButton.TabIndex = 8;
            softwareButton.Text = "softwareButton";
            softwareButton.UseVisualStyleBackColor = true;
            softwareButton.Click += softwareButton_Click;
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}