using System;
using System.Linq;
using System.Windows.Forms;
using UP.forms;
using UP.Utils;

namespace UP
{
    public partial class Auth : Form
    {
        private Entities entity = new Entities();

        private string generatedCapcha;

        const int TIMER_INTERVAL = 10;

        const string WRONG_LOGIN_OR_PASSWORD = "Неверный логин или пароль";
        const string WRONG_CAPCHA_CODE = "Неверная капча";
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

        private void enterButton_Click(object sender, EventArgs e)
        {
            TNS_employeers employee = entity.TNS_employeers
                .FirstOrDefault(p => p.login.Equals(loginTextBox.Text) && p.password.Equals(passwordTextBox.Text));

            if (employee == null)
            {
                MessageBox.Show(WRONG_LOGIN_OR_PASSWORD);
                return;
            }

            if (generatedCapcha == null || !generatedCapcha.Equals(codeTextBox.Text))
            {
                MessageBox.Show(WRONG_CAPCHA_CODE);
                return;
            }

            Helper.openWindow(new EmployeeMenu(employee), this);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            if (this.Visible != true)
            {
                return;
            }

            MessageBox.Show("Срок годности капчи истек", "", MessageBoxButtons.OK);
            capchaImage.Enabled = true;
            codeTextBox.Enabled = false;
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            int caretPosition = codeTextBox.SelectionStart;

            codeTextBox.Text = codeTextBox.Text.ToUpper();
            
            codeTextBox.SelectionStart = caretPosition;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TNS_employeers employee = entity.TNS_employeers
                .FirstOrDefault(p => p.id == 19);
            Helper.openWindow(new EmployeeMenu(employee), this);
        }
    }
}
