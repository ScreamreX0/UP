namespace UP.items
{
    partial class EmployeeMenuItem
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeMenuItemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeMenuItemLabel
            // 
            this.employeeMenuItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeMenuItemLabel.Location = new System.Drawing.Point(4, 9);
            this.employeeMenuItemLabel.Name = "employeeMenuItemLabel";
            this.employeeMenuItemLabel.Size = new System.Drawing.Size(109, 51);
            this.employeeMenuItemLabel.TabIndex = 0;
            this.employeeMenuItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.employeeMenuItemLabel.Click += new System.EventHandler(this.employeeMenuItemLabel_Click);
            // 
            // EmployeeMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.employeeMenuItemLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "EmployeeMenuItem";
            this.Size = new System.Drawing.Size(119, 69);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label employeeMenuItemLabel;
    }
}
