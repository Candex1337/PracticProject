namespace EquipmentAccountin.WinFormsUI
{
    partial class EquipmentTypeForm
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
            deleteButton = new Button();
            addButton = new Button();
            typesGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)typesGridView).BeginInit();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(146, 234);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(129, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 234);
            addButton.Name = "addButton";
            addButton.Size = new Size(128, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // typesGridView
            // 
            typesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            typesGridView.Location = new Point(12, 12);
            typesGridView.Name = "typesGridView";
            typesGridView.Size = new Size(263, 216);
            typesGridView.TabIndex = 4;
            typesGridView.CellContentClick += employeesGridView_CellContentClick;
            // 
            // EquipmentTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 278);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(typesGridView);
            Name = "EquipmentTypeForm";
            Text = "EquipmentTypeForm";
            Load += EquipmentTypeForm_Load;
            ((System.ComponentModel.ISupportInitialize)typesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button deleteButton;
        private Button addButton;
        private DataGridView typesGridView;
    }
}