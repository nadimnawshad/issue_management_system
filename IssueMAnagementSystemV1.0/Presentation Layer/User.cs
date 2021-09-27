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
    public partial class User : Form
    {
        static string Iid;
        static string phone;
        string pass;
        static string role;
        EmployeeDataAccess empDataAccess = new EmployeeDataAccess();
        public User(string id)
        {
            InitializeComponent();
            Iid = id;
            
            UserID_label.Text += id;
            Employees Emp = new Employees();
            EmployeeDataAccess eda = new EmployeeDataAccess();
            Emp = eda.GetAllInfo(id);
            EmployeeName_label.Text += Emp.Name;
            UserName_label.Text += Emp.UserName;
            Email_label.Text += Emp.Email;
            Deparment_label.Text += Emp.Edept;
            Role_label.Text += Emp.ERole;
            Status_label.Text += Emp.Estatus;
            PhoneNumber_label.Text += Emp.Phone;
            Address_label.Text += Emp.Address;
            phone = Emp.Phone;
            role = Emp.ERole;

            pass = Emp.Password;
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CreateIssuebackbutton_Click(object sender, EventArgs e)
        {
            if (empDataAccess.CheckRole(Iid))
            {
                Dashboard dashboard = new Dashboard(Iid);
                dashboard.Management_button.Visible = false;
                dashboard.Show();
                this.Hide();



            }
            else
            {

                Dashboard dashboard = new Dashboard(Iid);
                dashboard.Show();
                this.Hide();


            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (UpdateName_textBox.Text == "")
            {
                MessageBox.Show("Name Can not be empty");
            }
            
            else if (Updateusername_textBox.Text == "")
            {
                MessageBox.Show("User Name Can not be empty");
            }

            else if (Updateemail_textBox.Text == "")
            {
                MessageBox.Show("Email Can not be empty");
            }

            else if (Updatephone_textBox.Text == "")
            {
                MessageBox.Show("Phone number Can not be empty");
            }

            else if (Updateaddress_textBox.Text=="")
            {
                MessageBox.Show("Address Can not be empty");
            }


            else if (ConfirmPass_textBox.Text == "")
            {
                MessageBox.Show("Please Confirm Password");
            }


            else
            {
                EmployeeDataAccess Eda = new EmployeeDataAccess();

                if (Eda.LoginValidation(role,Iid, ConfirmPass_textBox.Text))
                {
                    EmployeeDataAccess EmpDataAccess = new EmployeeDataAccess();
                    if (EmpDataAccess.UpdateEmpInfo(Iid, UpdateName_textBox.Text, Updateusername_textBox.Text, Updateemail_textBox.Text, Updatephone_textBox.Text, Updateaddress_textBox.Text))
                    //(string id,string name, string username, string Email,string Phone,string Address
                    {
                        MessageBox.Show("Updated Succesfully");

                        User users = new User(Iid);
                        users.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Error in Updating");
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match. Please ry again.");
                }
                
            }
        }

        private void UsergroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
