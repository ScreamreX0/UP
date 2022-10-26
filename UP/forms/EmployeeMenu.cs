using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UP.items;
using UP.userPanels;
using UP.Utils;

namespace UP.forms
{
    public partial class EmployeeMenu : Form
    {
        private TNS_employeers employee;
        private Entities entity = new Entities();

        // constants
        // menu items
        private const string SUBSCRIBERS_MENU_ITEM = "Абоненты";
        private const string EQUIPMENT_MANAGE_MENU_ITEM = "Управление оборудованием";
        private const string STOKS_MENU_ITEM = "Активы";
        private const string BILLING_MENU_ITEM = "Биллинг";
        private const string SUPPORT_MENU_ITEM = "Поддержка пользователей";
        private const string CRM_MENU_ITEM = "CRM";

        // roles
        private const int HEAD_OF_CUSTOMER_SERVICE = 1;              // Руководитель отдела по работе с клиентами
        private const int ACCOUNT_MANAGER = 2;                       // Менеджер по работе с клиентами
        private const int HEAD_OF_TECHNICAL_SUPPORT_DEPARTMENT = 3;  // Руководитель отдела технической поддержки
        private const int TECHNICAL_SUPPORT_SPECIALIST = 4;          // Специалист технической поддержки
        private const int ACCOUNTANT = 5;                            // Бухгалтер
        private const int DIRECTOR_OF_DEVELOPMENT = 6;               // Директор по развитию
        private const int TECHNICAL_DEPARTMENT_EMPLOYEE = 7;         // Сотрудник технического департамента

        // titles
        private const string SUBSCRIBERS_TITLE = "Абоненты ТНС";

        public EmployeeMenu(TNS_employeers employee)
        {
            InitializeComponent();

            this.employee = employee;     
        }

        public void changePanel(string label)
        {
            if (label.Equals(SUBSCRIBERS_MENU_ITEM))
            {
                fillSubscribersPanel();
                mainTitle.Text = SUBSCRIBERS_TITLE;
            }
            else if (label.Equals(EQUIPMENT_MANAGE_MENU_ITEM))
            {

            }
            else if (label.Equals(STOKS_MENU_ITEM))
            {

            }
            else if (label.Equals(BILLING_MENU_ITEM))
            {

            }
            else if (label.Equals(SUPPORT_MENU_ITEM))
            {

            }
            else if (label.Equals(CRM_MENU_ITEM))
            {

            }
        }

        private void EmployeeMenu_Load(object sender, EventArgs e)
        {
            fillComboBox();
            fillWindow(); 
        }

        private void fillWindow()
        {
            // menu
            List<string> menuList = getMenuList();
            fillMenu(menuList);

            // events
            fillEvents();
        }

        private List<string> getMenuList()
        {
            List<string> menuList = new List<string>();
            if (employee.role == HEAD_OF_CUSTOMER_SERVICE)
            {
                menuList.Add(SUBSCRIBERS_MENU_ITEM);
                menuList.Add(CRM_MENU_ITEM);
                menuList.Add(BILLING_MENU_ITEM);

                fillSubscribersPanel();
            }
            else if (employee.role == ACCOUNT_MANAGER)
            {
                menuList.Add(SUBSCRIBERS_MENU_ITEM);
                menuList.Add(CRM_MENU_ITEM);
            }
            else if (employee.role == HEAD_OF_TECHNICAL_SUPPORT_DEPARTMENT)
            {
                menuList.Add(SUBSCRIBERS_MENU_ITEM);
                menuList.Add(SUPPORT_MENU_ITEM);
                menuList.Add(CRM_MENU_ITEM);
                menuList.Add(EQUIPMENT_MANAGE_MENU_ITEM);
            }
            else if (employee.role == TECHNICAL_SUPPORT_SPECIALIST)
            {
                menuList.Add(SUBSCRIBERS_MENU_ITEM);
                menuList.Add(SUPPORT_MENU_ITEM);
                menuList.Add(CRM_MENU_ITEM);
                menuList.Add(EQUIPMENT_MANAGE_MENU_ITEM);
            }
            else if (employee.role == ACCOUNTANT)
            {
                menuList.Add(SUBSCRIBERS_MENU_ITEM);
                menuList.Add(BILLING_MENU_ITEM);
                menuList.Add(STOKS_MENU_ITEM);
            }
            else if (employee.role == DIRECTOR_OF_DEVELOPMENT)
            {
                menuList.Add(SUBSCRIBERS_MENU_ITEM);
                menuList.Add(SUPPORT_MENU_ITEM);
                menuList.Add(CRM_MENU_ITEM);
                menuList.Add(EQUIPMENT_MANAGE_MENU_ITEM);
                menuList.Add(BILLING_MENU_ITEM);
                menuList.Add(STOKS_MENU_ITEM);
            }
            else if (employee.role == TECHNICAL_DEPARTMENT_EMPLOYEE)
            {
                menuList.Add(SUBSCRIBERS_MENU_ITEM);
                menuList.Add(STOKS_MENU_ITEM);
                menuList.Add(EQUIPMENT_MANAGE_MENU_ITEM);
                menuList.Add(CRM_MENU_ITEM);
            }

            return menuList;
        }

        private void fillMenu(List<string> menuList)
        {
            menuLayoutPanel.Controls.Clear();
            foreach (string s in menuList)
            {
                menuLayoutPanel.Controls.Add(new EmployeeMenuItem(this, s));
            }
        }

        private void fillEvents()
        {
            eventsLayoutPanel.AutoScroll = true;
            eventsLayoutPanel.FlowDirection = FlowDirection.LeftToRight;

            List<info_for_employeers> messages = entity.info_for_employeers
                .Where(p => p.employee_role == employee.role)
                .ToList();

            foreach (info_for_employeers message in messages)
            {
                if (message.message != null)
                {
                    eventsLayoutPanel.Controls.Add(new EventItem(message.message.ToString()));
                }
            }
        }

        private void fillSubscribersPanel()
        {
            SubscribersPanel subscribersPanel = new SubscribersPanel();

            foreach (subscribers subscriber in entity.subscribers)
            {
                treates treate = entity.treates.FirstOrDefault(p => p.subscriber == subscriber.id);
                
                if (treate == null)
                {
                    continue;
                }

                tariffs tariff = entity.tariffs.FirstOrDefault(p => p.id == treate.tariff);

                if (tariff == null)
                {
                    continue;
                }

                subscribersPanel.grid.Rows.Add(
                    treate.number,
                    subscriber.first_name + " " + subscriber.name + " " + subscriber.last_name,
                    treate.number + "-" + treate.date.Value.Month + "-" + treate.date.Value.Year,
                    subscriber.number,
                    tariff.service_name);
            }

            mainMenuPanel.Controls.Clear();
            mainMenuPanel.Controls.Add(subscribersPanel);
        }

        private void fillComboBox()
        {
            foreach (TNS_employeers employee in entity.TNS_employeers)
            {
                chooseUserComboBox.Items.Add(employee.first_name + " " + employee.name[0] + ". " + employee.last_name[0] + ". ");
            }

            chooseUserComboBox.SelectedIndex = employee.id;
        }

        private void chooseUserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string firstName = chooseUserComboBox.Text.Split()[0];
            TNS_employeers user = entity.TNS_employeers.FirstOrDefault(p => p.first_name.Equals(firstName));

            if (user == null)
            {
                throw new Exception("Пользователь не найден");
            }

            this.employee = user;
            fillWindow();
        }
    }
}
