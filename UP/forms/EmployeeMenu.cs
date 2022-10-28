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
        // DB
        public Entities entity = new Entities();

        // PANELS
        private SubscribersPanel subscribersPanel;
        private EquipmentPanel equipmentPanel;
        private ActivesPanel activesPanel;
        private BillingPanel billingPanel;
        private SupportUserPanel supportUserPanel;
        private CRMPanel crmPanel;

        // MISC
        private TNS_employeers employee;

        // INIT
        public EmployeeMenu(TNS_employeers employee)
        {
            InitializeComponent();  

            // PANELS
            // modules
            subscribersPanel = new SubscribersPanel(this);
            equipmentPanel = new EquipmentPanel();
            activesPanel = new ActivesPanel();
            billingPanel = new BillingPanel();
            supportUserPanel = new SupportUserPanel();
            crmPanel = new CRMPanel(this);

            // main panel
            mainMenuPanel.Controls.Add(subscribersPanel);

            // MISC
            this.employee = employee;

            // events
            eventsLayoutPanel.AutoScroll = true;
            eventsLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
        }

        public void changeMainPanel(string item)
        {
            mainMenuPanel.Controls.Clear();

            if (item.Equals(MenuItems.SUBSCRIBERS_MENU_ITEM))
            {
                mainMenuPanel.Controls.Add(subscribersPanel);
                fillSubscribersPanel(subscribersPanel.isActiveRadioButtonChecked());
                mainTitle.Text = Titles.SUBSCRIBERS_TITLE;
            }
            else if (item.Equals(MenuItems.EQUIPMENT_MANAGEMENT_MENU_ITEM))
            {
                mainMenuPanel.Controls.Add(equipmentPanel);
                fillEqupmentPanel();
                mainTitle.Text = Titles.EQUIPMENT_MANAGEMENT_TITLE;
            }
            else if (item.Equals(MenuItems.ACTIVES_MENU_ITEM))
            {
                mainMenuPanel.Controls.Add(activesPanel);
                fillActivesPanel();
                mainTitle.Text = Titles.ACTIVES_TITLE;
            }
            else if (item.Equals(MenuItems.BILLING_MENU_ITEM))
            {
                mainMenuPanel.Controls.Add(billingPanel);
                fillBillingPanel();
                mainTitle.Text = Titles.BILLING_TITLE;
            }
            else if (item.Equals(MenuItems.SUPPORT_MENU_ITEM))
            {
                mainMenuPanel.Controls.Add(supportUserPanel);
                fillSupportPanel();
                mainTitle.Text = Titles.SUPPORT_TITLE;
            }
            else if (item.Equals(MenuItems.CRM_MENU_ITEM))
            {
                mainMenuPanel.Controls.Add(crmPanel);
                fillCRMPanel();
                mainTitle.Text = Titles.CRM_TITLE;
            }
        }

        // FILLING PANELS
        public void fillSubscribersPanel(bool isActive = true)
        {
            subscribersPanel.grid.Rows.Clear();

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

                if (treate.termination_date is null == isActive)
                {
                    subscribersPanel.grid.Rows.Add(
                        subscriber.phone_number,
                        subscriber.first_name + " " + subscriber.name + " " + subscriber.last_name,
                        treate.number + "-" + treate.date.Value.Month + "-" + treate.date.Value.Year,
                        treate.number,
                        tariff.service_name);
                }
            }
        }

        public void fillEqupmentPanel()
        {

        }

        public void fillActivesPanel()
        {

        }

        public void fillBillingPanel()
        {

        }

        public void fillSupportPanel()
        {

        }

        public void fillCRMPanel()
        {

        }

        // FILLING WINDOW PARTS
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
            eventsLayoutPanel.Controls.Clear();

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

        private void fillEmployeersComboBox()
        {
            foreach (TNS_employeers employee in entity.TNS_employeers)
            {
                chooseUserComboBox.Items.Add(employee.first_name + " " + employee.name[0] + ". " + employee.last_name[0] + ". ");
            }

            chooseUserComboBox.SelectedIndex = employee.id;
        }

        // LOAD
        private void EmployeeMenu_Load(object sender, EventArgs e)
        {
            // Combobox with employeers
            fillEmployeersComboBox();

            // Main panel
            changeMainPanel(MenuItems.SUBSCRIBERS_MENU_ITEM);
            
            // Menu
            fillMenu(getMenuList(this.employee));

            // Events
            fillEvents();
        }

        // MISC
        private List<string> getMenuList(TNS_employeers employee)
        {
            List<string> menuList = new List<string>();
            if (employee.role == (int)Roles.HEAD_OF_CUSTOMER_SERVICE)
            {
                menuList.AddRange(new[]
                {
                    MenuItems.SUBSCRIBERS_MENU_ITEM,
                    MenuItems.CRM_MENU_ITEM,
                    MenuItems.BILLING_MENU_ITEM
                });
            }
            else if (employee.role == (int)Roles.ACCOUNT_MANAGER)
            {
                menuList.AddRange(new[]
                {
                    MenuItems.SUBSCRIBERS_MENU_ITEM,
                    MenuItems.CRM_MENU_ITEM
                });
            }
            else if (employee.role == (int)Roles.HEAD_OF_TECHNICAL_SUPPORT_DEPARTMENT)
            {
                menuList.AddRange(new[]
                {
                    MenuItems.SUBSCRIBERS_MENU_ITEM,
                    MenuItems.SUPPORT_MENU_ITEM,
                    MenuItems.CRM_MENU_ITEM,
                    MenuItems.EQUIPMENT_MANAGEMENT_MENU_ITEM
                });
            }
            else if (employee.role == (int)Roles.TECHNICAL_SUPPORT_SPECIALIST)
            {

                menuList.AddRange(new[]
                {
                    MenuItems.SUBSCRIBERS_MENU_ITEM,
                    MenuItems.SUPPORT_MENU_ITEM,
                    MenuItems.CRM_MENU_ITEM,
                    MenuItems.EQUIPMENT_MANAGEMENT_MENU_ITEM
                });
            }
            else if (employee.role == (int)Roles.ACCOUNTANT)
            {
                menuList.AddRange(new[]
                {
                    MenuItems.SUBSCRIBERS_MENU_ITEM,
                    MenuItems.BILLING_MENU_ITEM,
                    MenuItems.ACTIVES_MENU_ITEM
                });
            }
            else if (employee.role == (int)Roles.DIRECTOR_OF_DEVELOPMENT)
            {
                menuList.AddRange(new[]
                {
                    MenuItems.SUBSCRIBERS_MENU_ITEM,
                    MenuItems.SUPPORT_MENU_ITEM,
                    MenuItems.CRM_MENU_ITEM,
                    MenuItems.EQUIPMENT_MANAGEMENT_MENU_ITEM,
                    MenuItems.BILLING_MENU_ITEM,
                    MenuItems.ACTIVES_MENU_ITEM
                });
            }
            else if (employee.role == (int)Roles.TECHNICAL_DEPARTMENT_EMPLOYEE)
            {
                menuList.AddRange(new[]
                {
                    MenuItems.SUBSCRIBERS_MENU_ITEM,
                    MenuItems.ACTIVES_MENU_ITEM,
                    MenuItems.EQUIPMENT_MANAGEMENT_MENU_ITEM,
                    MenuItems.CRM_MENU_ITEM
                });
            }

            return menuList;
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
            fillMenu(getMenuList(this.employee));
            fillEvents();
        }
    }

    public enum Roles 
    {
        HEAD_OF_CUSTOMER_SERVICE = 1,              // Руководитель отдела по работе с клиентами
        ACCOUNT_MANAGER = 2,                       // Менеджер по работе с клиентами
        HEAD_OF_TECHNICAL_SUPPORT_DEPARTMENT = 3,  // Руководитель отдела технической поддержки
        TECHNICAL_SUPPORT_SPECIALIST = 4,          // Специалист технической поддержки
        ACCOUNTANT = 5,                            // Бухгалтер
        DIRECTOR_OF_DEVELOPMENT = 6,               // Директор по развитию
        TECHNICAL_DEPARTMENT_EMPLOYEE = 7          // Сотрудник технического департамента
    }

    public class MenuItems
    {
        public static readonly string SUBSCRIBERS_MENU_ITEM = "Абоненты";
        public static readonly string EQUIPMENT_MANAGEMENT_MENU_ITEM = "Управление оборудованием";
        public static readonly string ACTIVES_MENU_ITEM = "Активы";
        public static readonly string BILLING_MENU_ITEM = "Биллинг";
        public static readonly string SUPPORT_MENU_ITEM = "Поддержка пользователей";
        public static readonly string CRM_MENU_ITEM = "CRM";
    }

    public class Titles
    {
        public static readonly string SUBSCRIBERS_TITLE = "Абоненты ТНС";
        public static readonly string EQUIPMENT_MANAGEMENT_TITLE = "Управление оборудованием";
        public static readonly string ACTIVES_TITLE = "Активы";
        public static readonly string BILLING_TITLE = "Биллинг";
        public static readonly string SUPPORT_TITLE = "Поддержка пользователей";
        public static readonly string CRM_TITLE = "CRM";
    }
}
