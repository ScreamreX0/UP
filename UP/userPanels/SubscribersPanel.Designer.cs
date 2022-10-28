namespace UP.userPanels
{
    partial class SubscribersPanel
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agreement_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personal_account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscribersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uPDataSet = new UP.UPDataSet();
            this.subscribersTableAdapter = new UP.UPDataSetTableAdapters.subscribersTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonActive = new System.Windows.Forms.RadioButton();
            this.radioButtonNonActive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.full_name,
            this.agreement_number,
            this.personal_account,
            this.services});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(587, 403);
            this.dataGridView.TabIndex = 0;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Номер абонента";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "ФИО";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // agreement_number
            // 
            this.agreement_number.DataPropertyName = "agreement_number";
            this.agreement_number.HeaderText = "Номер договора с абонентом";
            this.agreement_number.Name = "agreement_number";
            this.agreement_number.ReadOnly = true;
            // 
            // personal_account
            // 
            this.personal_account.DataPropertyName = "personal_account";
            this.personal_account.HeaderText = "Лицевой счет";
            this.personal_account.Name = "personal_account";
            this.personal_account.ReadOnly = true;
            // 
            // services
            // 
            this.services.DataPropertyName = "services";
            this.services.HeaderText = "Перечень подключенных услуг ";
            this.services.Name = "services";
            this.services.ReadOnly = true;
            // 
            // subscribersBindingSource
            // 
            this.subscribersBindingSource.DataMember = "subscribers";
            this.subscribersBindingSource.DataSource = this.uPDataSet;
            // 
            // uPDataSet
            // 
            this.uPDataSet.DataSetName = "UPDataSet";
            this.uPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subscribersTableAdapter
            // 
            this.subscribersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNonActive);
            this.groupBox1.Controls.Add(this.radioButtonActive);
            this.groupBox1.Location = new System.Drawing.Point(0, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 26);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonActive
            // 
            this.radioButtonActive.AutoSize = true;
            this.radioButtonActive.Checked = true;
            this.radioButtonActive.Location = new System.Drawing.Point(6, 6);
            this.radioButtonActive.Name = "radioButtonActive";
            this.radioButtonActive.Size = new System.Drawing.Size(75, 17);
            this.radioButtonActive.TabIndex = 0;
            this.radioButtonActive.TabStop = true;
            this.radioButtonActive.Text = "Активные";
            this.radioButtonActive.UseVisualStyleBackColor = true;
            this.radioButtonActive.CheckedChanged += new System.EventHandler(this.radioButtonActive_CheckedChanged);
            // 
            // radioButtonNonActive
            // 
            this.radioButtonNonActive.AutoSize = true;
            this.radioButtonNonActive.Location = new System.Drawing.Point(107, 6);
            this.radioButtonNonActive.Name = "radioButtonNonActive";
            this.radioButtonNonActive.Size = new System.Drawing.Size(88, 17);
            this.radioButtonNonActive.TabIndex = 1;
            this.radioButtonNonActive.Text = "Неактивные";
            this.radioButtonNonActive.UseVisualStyleBackColor = true;
            this.radioButtonNonActive.CheckedChanged += new System.EventHandler(this.radioButtonNonActive_CheckedChanged);
            // 
            // SubscribersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "SubscribersPanel";
            this.Size = new System.Drawing.Size(587, 428);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource subscribersBindingSource;
        private UPDataSet uPDataSet;
        private UPDataSetTableAdapters.subscribersTableAdapter subscribersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn agreement_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn personal_account;
        private System.Windows.Forms.DataGridViewTextBoxColumn services;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNonActive;
        private System.Windows.Forms.RadioButton radioButtonActive;
    }
}
