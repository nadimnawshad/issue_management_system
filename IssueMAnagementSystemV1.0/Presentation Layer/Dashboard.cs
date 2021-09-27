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
    public partial class Dashboard : Form
    {
        static string uID;
        static string role;
        static int Point1;
        static string nId;
        public Dashboard( string userID)
        {

            InitializeComponent();
            EmployeeDataAccess Eda = new EmployeeDataAccess();
            uID = userID;
            nId= userID;
            Employees emp = Eda.GetAllInfo(uID);
            

            Name_label.Text += emp.Name;
            DIdlabel.Text += userID;
            UserName_label.Text += emp.UserName;
            Points_label.Text += emp.Points;
            Point1 = emp.Points;
            role = emp.ERole;
            if (role == "Employee")
            {
                Management_button.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            IssuesDataAccess IssueData = new IssuesDataAccess();


            Myissue_dataGridView.DataSource = IssueData.GetIssuesByEmpId(uID);
        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();

        }

        private void Issuebutton_Click(object sender, EventArgs e)
        {
            IssuesDashboard idb = new IssuesDashboard(uID, Point1);
            this.Hide();
            idb.Show();


        }

        private void DNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void UserInfo_Enter(object sender, EventArgs e)
        {

        }

        private void MakeIssuebutton_Click(object sender, EventArgs e)
        {
            CreateIssue ci = new CreateIssue(uID);
            this.Hide();
            ci.Show();

        }

        private void Myissuebutton_Click(object sender, EventArgs e)
        {
            MyIssues mi = new MyIssues(uID);
            this.Hide();
            mi.Show();

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ChatgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess Eda = new EmployeeDataAccess();
            Employees emp = Eda.GetAllInfo(uID);
            AccountOutput accounOutput = new AccountOutput(emp.Name, emp.UserName, uID, emp.Email, emp.Edept, emp.ERole, emp.Estatus, emp.Phone, emp.Address, emp.Password);
            accounOutput.OK_button.Visible = false;
            accounOutput.Update_button.Visible = true;
            accounOutput.CngPass_button.Visible = true;
            accounOutput.Back_button.Visible = true;
            accounOutput.Show();
        }

        private void Management_button_Click(object sender, EventArgs e)
        {
            Management manage = new Management(uID);
            this.Hide();
            manage.Show();

        }

        private void Chat_button_Click(object sender, EventArgs e)
        {
            ChatPage chatPage = new ChatPage(uID);
            this.Hide();
            chatPage.Show();

        }

        private void MyIssues_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Name_label_Click(object sender, EventArgs e)
        {

        }
    }
}
