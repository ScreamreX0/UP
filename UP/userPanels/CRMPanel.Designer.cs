namespace UP.userPanels
{
    partial class CRMPanel
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
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.firstNameRadioButton = new System.Windows.Forms.RadioButton();
            this.phoneNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.serviceKindComboBox = new System.Windows.Forms.ComboBox();
            this.serviceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.appNumbertextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.subscriberNumbertextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subscriberAccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.descritpionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(141, 26);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(141, 56);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Найти абонента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.firstNameRadioButton);
            this.groupBox.Controls.Add(this.phoneNumberRadioButton);
            this.groupBox.Location = new System.Drawing.Point(27, 23);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(108, 66);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            // 
            // firstNameRadioButton
            // 
            this.firstNameRadioButton.AutoSize = true;
            this.firstNameRadioButton.Location = new System.Drawing.Point(0, 34);
            this.firstNameRadioButton.Name = "firstNameRadioButton";
            this.firstNameRadioButton.Size = new System.Drawing.Size(74, 17);
            this.firstNameRadioButton.TabIndex = 1;
            this.firstNameRadioButton.Text = "Фамилия";
            this.firstNameRadioButton.UseVisualStyleBackColor = true;
            this.firstNameRadioButton.CheckedChanged += new System.EventHandler(this.firstNameRadioButton_CheckedChanged);
            // 
            // phoneNumberRadioButton
            // 
            this.phoneNumberRadioButton.AutoSize = true;
            this.phoneNumberRadioButton.Checked = true;
            this.phoneNumberRadioButton.Location = new System.Drawing.Point(0, 4);
            this.phoneNumberRadioButton.Name = "phoneNumberRadioButton";
            this.phoneNumberRadioButton.Size = new System.Drawing.Size(111, 17);
            this.phoneNumberRadioButton.TabIndex = 0;
            this.phoneNumberRadioButton.TabStop = true;
            this.phoneNumberRadioButton.Text = "Номер телефона";
            this.phoneNumberRadioButton.UseVisualStyleBackColor = true;
            this.phoneNumberRadioButton.CheckedChanged += new System.EventHandler(this.phoneNumberRadioButton_CheckedChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(141, 117);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(103, 13);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "Абонент не найден";
            this.errorLabel.Visible = false;
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(92, 307);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(296, 21);
            this.serviceComboBox.TabIndex = 9;
            // 
            // serviceKindComboBox
            // 
            this.serviceKindComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceKindComboBox.FormattingEnabled = true;
            this.serviceKindComboBox.Location = new System.Drawing.Point(92, 345);
            this.serviceKindComboBox.Name = "serviceKindComboBox";
            this.serviceKindComboBox.Size = new System.Drawing.Size(296, 21);
            this.serviceKindComboBox.TabIndex = 10;
            this.serviceKindComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceKindComboBox_SelectedIndexChanged);
            // 
            // serviceTypeComboBox
            // 
            this.serviceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceTypeComboBox.FormattingEnabled = true;
            this.serviceTypeComboBox.Location = new System.Drawing.Point(92, 384);
            this.serviceTypeComboBox.Name = "serviceTypeComboBox";
            this.serviceTypeComboBox.Size = new System.Drawing.Size(296, 21);
            this.serviceTypeComboBox.TabIndex = 11;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(415, 361);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(151, 44);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "Создать заявку";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Услуга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Вид услуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Тип услуги";
            // 
            // appNumbertextBox
            // 
            this.appNumbertextBox.Location = new System.Drawing.Point(415, 24);
            this.appNumbertextBox.Name = "appNumbertextBox";
            this.appNumbertextBox.Size = new System.Drawing.Size(151, 20);
            this.appNumbertextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Номер заявки";
            // 
            // createDatePicker
            // 
            this.createDatePicker.CustomFormat = "dd-MM-yyyy";
            this.createDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createDatePicker.Location = new System.Drawing.Point(415, 54);
            this.createDatePicker.MinDate = new System.DateTime(2022, 10, 28, 10, 36, 11, 0);
            this.createDatePicker.Name = "createDatePicker";
            this.createDatePicker.Size = new System.Drawing.Size(151, 20);
            this.createDatePicker.TabIndex = 18;
            this.createDatePicker.Value = new System.DateTime(2022, 10, 28, 10, 36, 15, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Дата закрытия";
            // 
            // subscriberNumbertextBox
            // 
            this.subscriberNumbertextBox.Location = new System.Drawing.Point(415, 88);
            this.subscriberNumbertextBox.Name = "subscriberNumbertextBox";
            this.subscriberNumbertextBox.Size = new System.Drawing.Size(151, 20);
            this.subscriberNumbertextBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Номер абонента";
            // 
            // subscriberAccountNumberTextBox
            // 
            this.subscriberAccountNumberTextBox.Location = new System.Drawing.Point(415, 125);
            this.subscriberAccountNumberTextBox.Name = "subscriberAccountNumberTextBox";
            this.subscriberAccountNumberTextBox.Size = new System.Drawing.Size(151, 20);
            this.subscriberAccountNumberTextBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Лицевой счет";
            // 
            // descritpionTextBox
            // 
            this.descritpionTextBox.Location = new System.Drawing.Point(415, 163);
            this.descritpionTextBox.Multiline = true;
            this.descritpionTextBox.Name = "descritpionTextBox";
            this.descritpionTextBox.Size = new System.Drawing.Size(151, 73);
            this.descritpionTextBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Описание проблемы";
            // 
            // CRMPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descritpionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subscriberAccountNumberTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subscriberNumbertextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appNumbertextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.serviceTypeComboBox);
            this.Controls.Add(this.serviceKindComboBox);
            this.Controls.Add(this.serviceComboBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.phoneNumberBox);
            this.Name = "CRMPanel";
            this.Size = new System.Drawing.Size(587, 428);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton firstNameRadioButton;
        private System.Windows.Forms.RadioButton phoneNumberRadioButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.ComboBox serviceKindComboBox;
        private System.Windows.Forms.ComboBox serviceTypeComboBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox appNumbertextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker createDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subscriberNumbertextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subscriberAccountNumberTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox descritpionTextBox;
        private System.Windows.Forms.Label label8;
    }
}
