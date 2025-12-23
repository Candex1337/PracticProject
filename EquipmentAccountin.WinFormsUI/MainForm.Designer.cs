namespace EquipmentAccounting.WinFormsUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            navigationListBox = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // navigationListBox
            // 
            navigationListBox.FormattingEnabled = true;
            navigationListBox.Items.AddRange(new object[] { "Подразделения", "Сотрудники", "Оборудование", "История", "Отчёты" });
            navigationListBox.Location = new Point(13, 51);
            navigationListBox.Margin = new Padding(4, 3, 4, 3);
            navigationListBox.Name = "navigationListBox";
            navigationListBox.Size = new Size(204, 109);
            navigationListBox.TabIndex = 1;
            navigationListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Выберите:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 174);
            Controls.Add(label1);
            Controls.Add(navigationListBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox navigationListBox;
        private Label label1;
    }
}

