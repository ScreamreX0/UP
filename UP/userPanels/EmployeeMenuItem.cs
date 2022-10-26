using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UP.forms;

namespace UP.items
{
    public partial class EmployeeMenuItem : UserControl
    {
        Form parent;
        public EmployeeMenuItem(Form parent, string label)
        {
            InitializeComponent();

            this.parent = parent;

            this.label = label;
            employeeMenuItemLabel.Text = this.label;
        }

        private string label;

        public string Label
        {
            get { 
                return label; 
            }
            set
            {
                this.label = value;
                employeeMenuItemLabel.Text = this.label;
            }
        }

        private void employeeMenuItemLabel_Click(object sender, EventArgs e)
        {
            (this.parent as EmployeeMenu).changePanel(label);
        }
    }
}
