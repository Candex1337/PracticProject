namespace EquipmentAccounting.WinFormsUI
{
    partial class DepartmentEditForm
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
            headTextBox = new TextBox();
            nameTextBox = new TextBox();
            label1 = new Label();
            button2 = new Button();
            cancelButton = new Button();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7109833F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2890167F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(headTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(nameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 2);
            tableLayoutPanel1.Controls.Add(cancelButton, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(346, 120);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // headTextBox
            // 
            headTextBox.Dock = DockStyle.Fill;
            headTextBox.Location = new Point(177, 41);
            headTextBox.Margin = new Padding(5);
            headTextBox.Name = "headTextBox";
            headTextBox.Size = new Size(164, 23);
            headTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            nameTextBox.Dock = DockStyle.Fill;
            nameTextBox.Location = new Point(177, 5);
            nameTextBox.Margin = new Padding(5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(164, 23);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Название подразделения";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.AutoSize = true;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(39, 83);
            button2.Name = "button2";
            button2.Size = new Size(130, 25);
            button2.TabIndex = 2;
            button2.Text = "Сохранить";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Right;
            cancelButton.AutoSize = true;
            cancelButton.Location = new Point(205, 83);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(138, 25);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 3;
            label2.Text = "Руководитель";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DepartmentEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 146);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DepartmentEditForm";
            Text = "DepartmentEditForm";
            Load += DepartmentEditForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Button cancelButton;
        private Label label1;
        private TextBox nameTextBox;
        private TextBox headTextBox;
        private Label label2;
    }
}