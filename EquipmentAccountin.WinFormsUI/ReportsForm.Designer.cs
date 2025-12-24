namespace EquipmentAccountin.WinFormsUI
{
    partial class ReportsForm
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
            departmentReportButton = new Button();
            reportGridView = new DataGridView();
            softwareByEmployeeButton = new Button();
            employeeComboBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)reportGridView).BeginInit();
            SuspendLayout();
            // 
            // departmentReportButton
            // 
            departmentReportButton.Location = new Point(12, 129);
            departmentReportButton.Name = "departmentReportButton";
            departmentReportButton.Size = new Size(213, 23);
            departmentReportButton.TabIndex = 0;
            departmentReportButton.Text = "Оборудование по подразделениям";
            departmentReportButton.UseVisualStyleBackColor = true;
            departmentReportButton.Click += departmentReportButton_Click;
            // 
            // reportGridView
            // 
            reportGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportGridView.Location = new Point(231, 31);
            reportGridView.Name = "reportGridView";
            reportGridView.Size = new Size(453, 222);
            reportGridView.TabIndex = 1;
            // 
            // softwareByEmployeeButton
            // 
            softwareByEmployeeButton.Location = new Point(150, 49);
            softwareByEmployeeButton.Name = "softwareByEmployeeButton";
            softwareByEmployeeButton.Size = new Size(75, 23);
            softwareByEmployeeButton.TabIndex = 2;
            softwareByEmployeeButton.Text = "Найти";
            softwareByEmployeeButton.UseVisualStyleBackColor = true;
            softwareByEmployeeButton.Click += softwareByEmployeeButton_Click;
            // 
            // employeeComboBox
            // 
            employeeComboBox.FormattingEnabled = true;
            employeeComboBox.Location = new Point(12, 49);
            employeeComboBox.Name = "employeeComboBox";
            employeeComboBox.Size = new Size(132, 23);
            employeeComboBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 4;
            label1.Text = "Оборудования у сотрудника";
            label1.Click += label1_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 268);
            Controls.Add(label1);
            Controls.Add(employeeComboBox);
            Controls.Add(softwareByEmployeeButton);
            Controls.Add(reportGridView);
            Controls.Add(departmentReportButton);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)reportGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button departmentReportButton;
        private DataGridView reportGridView;
        private Button softwareByEmployeeButton;
        private ComboBox employeeComboBox;
        private Label label1;
    }
}