namespace UP.forms
{
    partial class EmployeeMenu
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
            this.menuLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.eventsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.mainTitle = new System.Windows.Forms.Label();
            this.chooseUserComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuLayoutPanel
            // 
            this.menuLayoutPanel.AutoScroll = true;
            this.menuLayoutPanel.Location = new System.Drawing.Point(13, 150);
            this.menuLayoutPanel.Name = "menuLayoutPanel";
            this.menuLayoutPanel.Size = new System.Drawing.Size(163, 428);
            this.menuLayoutPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Проф";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(103, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Location = new System.Drawing.Point(182, 150);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(587, 428);
            this.mainMenuPanel.TabIndex = 3;
            // 
            // eventsLayoutPanel
            // 
            this.eventsLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.eventsLayoutPanel.Location = new System.Drawing.Point(776, 150);
            this.eventsLayoutPanel.Name = "eventsLayoutPanel";
            this.eventsLayoutPanel.Size = new System.Drawing.Size(151, 428);
            this.eventsLayoutPanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(776, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 42);
            this.panel2.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(29, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 20);
            this.label.TabIndex = 0;
            this.label.Text = "События";
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTitle.Location = new System.Drawing.Point(206, 32);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(257, 39);
            this.mainTitle.TabIndex = 6;
            this.mainTitle.Text = "Абоненты ТНС";
            // 
            // chooseUserComboBox
            // 
            this.chooseUserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseUserComboBox.FormattingEnabled = true;
            this.chooseUserComboBox.Location = new System.Drawing.Point(776, 12);
            this.chooseUserComboBox.Name = "chooseUserComboBox";
            this.chooseUserComboBox.Size = new System.Drawing.Size(149, 21);
            this.chooseUserComboBox.TabIndex = 7;
            this.chooseUserComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseUserComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chooseUserComboBox);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.eventsLayoutPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EmployeeMenu";
            this.Text = "EmployeeMenu";
            this.Load += new System.EventHandler(this.EmployeeMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menuLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.FlowLayoutPanel eventsLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.ComboBox chooseUserComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}