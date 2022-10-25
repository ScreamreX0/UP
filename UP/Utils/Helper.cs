using System.Windows.Forms;

namespace UP.Utils
{
    class Helper
    {
        public static void openWindow(Form newForm, Form parent)
        {
            Form menu = new Form();
            parent.Hide();
            menu.Show();
        }
    }
}
