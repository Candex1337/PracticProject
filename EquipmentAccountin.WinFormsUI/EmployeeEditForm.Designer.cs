namespace EquipmentAccountin.WinFormsUI
{
    partial class EmployeeEditForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            positionTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            departmentComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.86705F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.13295F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(positionTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(fullNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(saveButton, 0, 3);
            tableLayoutPanel1.Controls.Add(cancelButton, 1, 3);
            tableLayoutPanel1.Controls.Add(departmentComboBox, 1, 2);
            tableLayoutPanel1.Location = new Point(30, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46154F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.53846F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(346, 206);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Отдел";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // positionTextBox
            // 
            positionTextBox.Dock = DockStyle.Fill;
            positionTextBox.Location = new Point(181, 40);
            positionTextBox.Margin = new Padding(5);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(160, 23);
            positionTextBox.TabIndex = 4;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Dock = DockStyle.Fill;
            fullNameTextBox.Location = new Point(181, 5);
            fullNameTextBox.Margin = new Padding(5);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(160, 23);
            fullNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Полное имя";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Позиция";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Right;
            saveButton.AutoSize = true;
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(80, 181);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(93, 22);
            saveButton.TabIndex = 2;
            saveButton.Text = "Сохранить";
            saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Right;
            cancelButton.AutoSize = true;
            cancelButton.Location = new Point(250, 181);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(93, 22);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(179, 94);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(121, 23);
            departmentComboBox.TabIndex = 6;
            // 
            // EmployeeEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 243);
            Controls.Add(tableLayoutPanel1);
            Name = "EmployeeEditForm";
            Text = "EmployeeEditForm";
            Load += EmployeeEditForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox positionTextBox;
        private TextBox fullNameTextBox;
        private Label label1;
        private Button cancelButton;
        private Label label2;
        private Button saveButton;
        private Label label3;
        private ComboBox departmentComboBox;
    }
}