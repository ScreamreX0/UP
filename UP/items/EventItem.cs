using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP.items
{
    public partial class EventItem : UserControl
    {
        public EventItem(string label)
        {
            InitializeComponent();

            eventLabel.Text = label;
        }

        private void eventLabel_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(eventLabel.Text, eventLabel.Font);
            eventLabel.Width = size.Width;
            eventLabel.Height = size.Height;
        }

        private string label;

        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                this.label = value;
                eventLabel.Text = this.label;
            }
        }
    }
}
