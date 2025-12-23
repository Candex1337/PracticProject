namespace EquipmentAccountin.WinFormsUI
{
    partial class EquipmentSoftwareForm
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
            softwareListBox = new ListBox();
            licenseComboBox = new ComboBox();
            installButton = new Button();
            removeButton = new Button();
            equipmentListBox = new ListBox();
            SuspendLayout();
            // 
            // softwareListBox
            // 
            softwareListBox.FormattingEnabled = true;
            softwareListBox.Location = new Point(240, 82);
            softwareListBox.Name = "softwareListBox";
            softwareListBox.Size = new Size(114, 94);
            softwareListBox.TabIndex = 0;
            // 
            // licenseComboBox
            // 
            licenseComboBox.FormattingEnabled = true;
            licenseComboBox.Location = new Point(360, 82);
            licenseComboBox.Name = "licenseComboBox";
            licenseComboBox.Size = new Size(134, 23);
            licenseComboBox.TabIndex = 1;
            // 
            // installButton
            // 
            installButton.Location = new Point(240, 182);
            installButton.Name = "installButton";
            installButton.Size = new Size(104, 23);
            installButton.TabIndex = 2;
            installButton.Text = "Установить";
            installButton.UseVisualStyleBackColor = true;
            installButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(350, 182);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(94, 23);
            removeButton.TabIndex = 3;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // equipmentListBox
            // 
            equipmentListBox.FormattingEnabled = true;
            equipmentListBox.Location = new Point(120, 82);
            equipmentListBox.Name = "equipmentListBox";
            equipmentListBox.Size = new Size(114, 94);
            equipmentListBox.TabIndex = 4;
            // 
            // EquipmentSoftwareForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(equipmentListBox);
            Controls.Add(removeButton);
            Controls.Add(installButton);
            Controls.Add(licenseComboBox);
            Controls.Add(softwareListBox);
            Name = "EquipmentSoftwareForm";
            Text = "EquipmentSoftwareForm";
            Load += EquipmentSoftwareForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox softwareListBox;
        private ComboBox licenseComboBox;
        private Button installButton;
        private Button removeButton;
        private ListBox equipmentListBox;
    }
}