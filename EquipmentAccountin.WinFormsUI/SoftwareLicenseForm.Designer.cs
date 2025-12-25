namespace EquipmentAccountin.WinFormsUI
{
    partial class SoftwareLicenseForm
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
            licensesGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)licensesGridView).BeginInit();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(181, 234);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(194, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 234);
            addButton.Name = "addButton";
            addButton.Size = new Size(163, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // licensesGridView
            // 
            licensesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            licensesGridView.Location = new Point(12, 12);
            licensesGridView.Name = "licensesGridView";
            licensesGridView.Size = new Size(363, 216);
            licensesGridView.TabIndex = 8;
            licensesGridView.CellContentClick += licensesGridView_CellContentClick;
            // 
            // SoftwareLicenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 276);
            Controls.Add(licensesGridView);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Name = "SoftwareLicenseForm";
            Text = "SoftwareLicenseForm";
            Load += SoftwareLicenseForm_Load;
            Click += SoftwareLicenseForm_Load;
            ((System.ComponentModel.ISupportInitialize)licensesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button deleteButton;
        private Button addButton;
        private DataGridView licensesGridView;
    }
}