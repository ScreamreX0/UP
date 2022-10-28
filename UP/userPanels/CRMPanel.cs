using System;
using System.Linq;
using System.Windows.Forms;
using UP.forms;

namespace UP.userPanels
{
    public partial class CRMPanel : UserControl
    {
        EmployeeMenu parent;
        TNSServices tnsServices;
        subscribers subscriber;
        public CRMPanel(EmployeeMenu parent)
        {
            InitializeComponent();

            this.parent = parent;

            tnsServices = new TNSServices();

            // service combo box
            serviceComboBox.Items.AddRange(new string[] {
                tnsServices.INTERNET,
                tnsServices.MOBILE_CONNETION,
                tnsServices.TV,
                tnsServices.CCTV
            });

            // service kind combo box
            serviceKindComboBox.Items.AddRange(new string[] {
                tnsServices.CONNECT_KIND,
                tnsServices.TREATE_MANAGEMENT_KIND,
                tnsServices.TARIFF_MANAGEMENT_KIND,
                tnsServices.DIAGNOSTICS_KIND,
                tnsServices.PAYMENT_KIND
            });

        }

        private void phoneNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            enablePhoneNumberOrFirstName();
        }

        private void firstNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            enablePhoneNumberOrFirstName();
        }

        private void enablePhoneNumberOrFirstName()
        {
            phoneNumberBox.Enabled = phoneNumberRadioButton.Checked;
            firstNameTextBox.Enabled = firstNameRadioButton.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getSubscriber();

            if (subscriber == null)
            {
                errorLabel.Visible = true;
                return;
            }
            errorLabel.Visible = false;

            // getting treate
            treates treate = getTreate(subscriber);

            if (treate == null)
            {
                MessageBox.Show("Договор с указанным пользователем не найден");
                return;
            }

            DateTime currentDate = DateTime.Now;

            appNumbertextBox.Text = $"{treate.number}/{currentDate.Day}/{currentDate.Month}/{currentDate.Year}";
            subscriberNumbertextBox.Text = subscriber.phone_number;
            subscriberAccountNumberTextBox.Text = treate.number;
        }

        private void getSubscriber()
        {
            // Empty check
            if (phoneNumberBox.Text.Equals(String.Empty) && phoneNumberRadioButton.Checked
                || firstNameTextBox.Text.Equals(String.Empty) && firstNameRadioButton.Checked)
            {
                Console.WriteLine("empty string");
                this.subscriber = null;
            }

            subscribers subscriberPhone = null;
            subscribers subscriberFirstName = null;

            if (phoneNumberRadioButton.Checked)
            {
                subscriberPhone = parent.entity
                    .subscribers
                    .FirstOrDefault(s => s.phone_number.Equals(phoneNumberBox.Text));

                Console.WriteLine("finding by phone number");
                this.subscriber = subscriberPhone;
            } 
            else
            {
                subscriberFirstName = parent.entity
                    .subscribers
                    .FirstOrDefault(s => s.first_name.Equals(firstNameTextBox.Text));

                Console.WriteLine("finding by firstname");
                this.subscriber = subscriberFirstName;
            }
        }

        private treates getTreate(subscribers subscriber)
        {
            return parent.entity
                .treates
                .FirstOrDefault(t => t.subscriber == subscriber.id); ;
        }

        private void serviceKindComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceTypeComboBox.Items.Clear();
            serviceTypeComboBox.Items.AddRange(tnsServices.getServiceType(serviceKindComboBox.SelectedItem.ToString()));
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (subscriber is null)
            {
                MessageBox.Show("Абонент не найден");
                return;
            }

            if (checkFields() is null)
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            applicaitons applicaiton = new applicaitons();

            applicaiton.number = appNumbertextBox.Text;
            applicaiton.date = DateTime.Now;
            applicaiton.subscriber = subscriber.id;
            applicaiton.service = serviceComboBox.Text;
            applicaiton.service_kind = serviceKindComboBox.Text;
            applicaiton.serivce_type = serviceTypeComboBox.Text;
            applicaiton.status = "Новая";
            applicaiton.problem_description = descritpionTextBox.Text;
            applicaiton.problem_type = "ТО";

            try
            {
                parent.entity.applicaitons.Add(applicaiton);
                parent.entity.SaveChanges();
                clearFields();
                MessageBox.Show("Заявка успешно оформлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private string checkFields()
        {
            if (string.IsNullOrWhiteSpace(appNumbertextBox.Text) 
                || string.IsNullOrWhiteSpace(subscriberNumbertextBox.Text)
                || string.IsNullOrWhiteSpace(createDatePicker.Text)
                || string.IsNullOrWhiteSpace(subscriberAccountNumberTextBox.Text)
                || string.IsNullOrWhiteSpace(descritpionTextBox.Text)
                || string.IsNullOrEmpty(serviceComboBox.Text)
                || string.IsNullOrEmpty(serviceKindComboBox.Text)
                || string.IsNullOrEmpty(serviceTypeComboBox.Text))
            {
                return null;
            }

            return "Ок";
        }

        private void clearFields()
        {
            appNumbertextBox.Text = string.Empty;
            subscriberNumbertextBox.Text = string.Empty;
            createDatePicker.Text = string.Empty;
            subscriberAccountNumberTextBox.Text = string.Empty;
            descritpionTextBox.Text = string.Empty;
            serviceComboBox.Text = string.Empty;
            serviceKindComboBox.Text = string.Empty;
            serviceTypeComboBox.Text = string.Empty;
        }
    }

    public class TNSServices
    {
        // services
        public string INTERNET { get => "Интернет"; }
        public string MOBILE_CONNETION { get => "Мобильная связь"; }
        public string TV { get => "Телевидение"; }
        public string CCTV { get => "Видеонаблюдение"; }

        // kinds
        public string CONNECT_KIND { get => "Подключение"; }
        public string TREATE_MANAGEMENT_KIND { get => "Управление договором/контактными данными"; }
        public string TARIFF_MANAGEMENT_KIND { get => "Управление тарифом/услугой"; }
        public string DIAGNOSTICS_KIND { get => "Диагностика и настройка оборудования/подключения"; }
        public string PAYMENT_KIND { get => "Оплата услуг"; }

        public string[] getServiceType(string kind)
        {
            TNSServices serviceKinds = new TNSServices();

            string[] serviceTypes = new string[] { "" };
            if (kind.Equals(serviceKinds.CONNECT_KIND))
            {
                serviceTypes = new string[] {
                    "Подключение услуг с новой инфраструктурой",
                    "Подключение услуг на существующей инфраструктуре"
                };
            } 
            else if (kind.Equals(serviceKinds.TREATE_MANAGEMENT_KIND))
            {
                serviceTypes = new string[] {
                    "Изменение условий договора",
                    "Включение в договор дополнительной услуги",
                    "Изменение контактных данных"
                };
            }
            else if (kind.Equals(serviceKinds.TARIFF_MANAGEMENT_KIND))
            {
                serviceTypes = new string[] {
                    "Изменение тарифа",
                    "Изменение адреса предоставления услуг",
                    "Отключение услуги",
                    "Приостановка предоставления услуги"
                };
            }
            else if (kind.Equals(serviceKinds.DIAGNOSTICS_KIND))
            {
                serviceTypes = new string[] {
                    "Нет доступа к услуге",
                    "Разрыв соединения",
                    "Низкая скорость соединения"
                };
            }
            else if (kind.Equals(serviceKinds.PAYMENT_KIND))
            {
                serviceTypes = new string[] {
                    "Выписка по платежам",
                    "Информация о платежах",
                    "Получение квитанции на оплату услуги"
                };
            }

            return serviceTypes;
        }
    }
}
