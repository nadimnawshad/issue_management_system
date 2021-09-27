using IssueMAnagementSystemV1._0.DataAccessLayer;
using IssueMAnagementSystemV1._0.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueMAnagementSystemV1._0.Presentation_Layer
{
    public partial class AccountOutput : Form
    {
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        string Euid;
        public AccountOutput()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        
        public AccountOutput(string name, string userName,string userID,string email, string dept, string role, string status, string number, string address, string EPassword)
        {
            InitializeComponent();
            this.ControlBox = false;
            if (userID == "0")
            {
                EmployeeDataAccess ism = new EmployeeDataAccess();
                userID = (ism.GetId(name, EPassword)).ToString();
            }
            else
            {
                Euid = userID;
            }

            EmployeeName_label.Text += name;
            UserName_label.Text += userName;
            UserID_label.Text += userID;
            Email_label.Text += email;
            Deparment_label.Text += dept;
            SelectRole_label.Text += role;
            Status_label.Text += status;
            PhoneNumber_label.Text += number;
            Address_label.Text += address;
        }
        private void AccountOutput_Load(object sender, EventArgs e)
        {

        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();
        }

        private void EmployeeName_label_Click(object sender, EventArgs e)
        {

        }

        private void AccountOutput_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserID_label_Click(object sender, EventArgs e)
        {

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
             this.Hide();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            User user = new User(Euid);
            this.Hide();
            user.Show();
        }

        private void CngPass_button_Click(object sender, EventArgs e)
        {
            ChangePassPage changePassPage = new ChangePassPage(Euid);
            this.Hide();
            changePassPage.Show();
        }
    }
}
