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
            licenseComboBox = new ComboBox();
            installButton = new Button();
            removeButton = new Button();
            softwareListBox = new ListBox();
            SuspendLayout();
            // 
            // licenseComboBox
            // 
            licenseComboBox.FormattingEnabled = true;
            licenseComboBox.Location = new Point(184, 12);
            licenseComboBox.Name = "licenseComboBox";
            licenseComboBox.Size = new Size(134, 23);
            licenseComboBox.TabIndex = 1;
            // 
            // installButton
            // 
            installButton.Location = new Point(184, 84);
            installButton.Name = "installButton";
            installButton.Size = new Size(134, 23);
            installButton.TabIndex = 2;
            installButton.Text = "Установить";
            installButton.UseVisualStyleBackColor = true;
            installButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(184, 113);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(134, 23);
            removeButton.TabIndex = 3;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // softwareListBox
            // 
            softwareListBox.Location = new Point(12, 12);
            softwareListBox.Name = "softwareListBox";
            softwareListBox.Size = new Size(166, 124);
            softwareListBox.TabIndex = 5;
            // 
            // EquipmentSoftwareForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 147);
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
        private ComboBox licenseComboBox;
        private Button installButton;
        private Button removeButton;
        private ListBox softwareListBox;
    }
}