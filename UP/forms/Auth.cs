using System;
using System.Linq;
using System.Windows.Forms;
using UP.Utils;

namespace UP
{
    public partial class Auth : Form
    {
        UPEntities entity = new UPEntities();

        string generatedCapcha;

        public Auth()
        {
            InitializeComponent();
            codeTextBox.Enabled = false;
        }

        private void capchaImage_Click(object sender, EventArgs e)
        {
            generateNewCapcha();
            showMessageBox();
        }
        
        private void generateNewCapcha()
        {
            const string SYMBOLS = "abcdefhijklmnopqrstuvwxyz123456789!*?";
            const int CAPCHA_LENGHT = 4;

            generatedCapcha = String.Empty;
            Random random = new Random();
            for (int i = 0; i < CAPCHA_LENGHT; i++)
            {
                generatedCapcha += SYMBOLS[random.Next(CAPCHA_LENGHT)].ToString()
                    .ToUpper();
            }
        }
        
        const int TIMER_INTERVAL = 10;

        private void showMessageBox()
        {
            const string TITLE = "CAPCHA";

            if (MessageBox.Show(generatedCapcha, TITLE, MessageBoxButtons.OK) == DialogResult.OK)
            {
                timer.Interval = TIMER_INTERVAL * 1000;
                timer.Start();
                capchaImage.Enabled = false;
                codeTextBox.Enabled = true;
            }
        }

        const string WRONG_LOGIN_OR_PASSWORD = "Неверный логин или пароль";
        const string WRONG_CAPCHA_CODE = "Неверная капча";
        const string OK = "Ок";

        private void enterButton_Click(object sender, EventArgs e)
        {
            subscriber user = entity.subscriber
                .FirstOrDefault(p => p.login.Equals(loginTextBox.Text) && p.password.Equals(passwordTextBox.Text));

            if (user == null)
            {
                MessageBox.Show(WRONG_LOGIN_OR_PASSWORD);
                return;
            }

            if (generatedCapcha == null || !generatedCapcha.Equals(codeTextBox.Text))
            {
                MessageBox.Show(WRONG_CAPCHA_CODE);
                return;
            }

            Helper.openWindow(new Form(), this);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Срок годности капчи истек", "", MessageBoxButtons.OK);
            capchaImage.Enabled = true;
            codeTextBox.Enabled = false;
            timer.Stop();
        }
    }
}
