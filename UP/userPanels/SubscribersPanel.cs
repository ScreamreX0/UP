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

namespace UP.userPanels
{
    public partial class SubscribersPanel : UserControl
    {
        private EmployeeMenu employeeMenu;
        
        public SubscribersPanel(EmployeeMenu employeeMenu, bool isActive = true)
        {
            InitializeComponent();
            this.employeeMenu = employeeMenu;
            
            if (isActive)
            {
                radioButtonActive.Checked = true;
            } 
            else
            {
                radioButtonNonActive.Checked = true;
            }
        }

        public DataGridView grid
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }

        public bool isActiveRadioButtonChecked()
        {
            return radioButtonActive.Checked;
        }

        private void radioButtonActive_CheckedChanged(object sender, EventArgs e)
        {
            employeeMenu.fillSubscribersPanel();
        }

        private void radioButtonNonActive_CheckedChanged(object sender, EventArgs e)
        {
            employeeMenu.fillSubscribersPanel(false);
        }
    }
}
