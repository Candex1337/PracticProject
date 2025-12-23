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
            ((System.ComponentModel.ISupportInitialize)reportGridView).BeginInit();
            SuspendLayout();
            // 
            // departmentReportButton
            // 
            departmentReportButton.Location = new Point(211, 64);
            departmentReportButton.Name = "departmentReportButton";
            departmentReportButton.Size = new Size(220, 23);
            departmentReportButton.TabIndex = 0;
            departmentReportButton.Text = "Оборудование по подразделениям";
            departmentReportButton.UseVisualStyleBackColor = true;
            departmentReportButton.Click += departmentReportButton_Click_1;
            // 
            // reportGridView
            // 
            reportGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportGridView.Location = new Point(211, 93);
            reportGridView.Name = "reportGridView";
            reportGridView.Size = new Size(453, 222);
            reportGridView.TabIndex = 1;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportGridView);
            Controls.Add(departmentReportButton);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)reportGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button departmentReportButton;
        private DataGridView reportGridView;
    }
}