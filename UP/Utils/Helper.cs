using System.Windows.Forms;

namespace UP.Utils
{
    internal class Helper
    {
        public static void openWindow(Form newForm, Form parent)
        {
            newForm.Location = parent.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            parent.Hide();
            newForm.Show();
        }
    }
}
