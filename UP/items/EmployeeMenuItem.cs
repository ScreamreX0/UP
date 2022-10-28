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

        public EmployeeMenuItem(Form parent, string menuItemLabel)
        {
            InitializeComponent();

            this.parent = parent;
            employeeMenuItemLabel.Text = menuItemLabel;
        }

        public string getMenuItemLabel()
        {
            return employeeMenuItemLabel.Text;
        }

        public void setEmployeeMenuItemLabel(string text)
        {
            employeeMenuItemLabel.Text = text;
        }

        private void employeeMenuItemLabel_Click(object sender, EventArgs e)
        {
            (this.parent as EmployeeMenu).changeMainPanel(employeeMenuItemLabel.Text);
        }
    }
}
