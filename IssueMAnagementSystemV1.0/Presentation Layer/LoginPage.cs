using IssueMAnagementSystemV1._0.DataAccessLayer;
using IssueMAnagementSystemV1._0.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueMAnagementSystemV1._0.Entity
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (SelectRole_comboBox.Text == "" && UserID_textBox.Text == "" && Passwrod_textBox.Text == "")
            {
                MessageBox.Show("ERROR. Please Provide Role, User Id and Password and TRY AGAIN");
            }

            else if (SelectRole_comboBox.Text == "" && UserID_textBox.Text == "")
            {
                MessageBox.Show("ERROR. Please Provide Role, User Id and TRY AGAIN");
            }

            else if (SelectRole_comboBox.Text == "" && Passwrod_textBox.Text == "")
            {
                MessageBox.Show("ERROR. Please Provide Role, Password and TRY AGAIN");
            }

            else if (UserID_textBox.Text == "" && Passwrod_textBox.Text == "")
            {
                MessageBox.Show("ERROR. Please Provid User Id and Password and TRY AGAIN");
            }

            else if (SelectRole_comboBox.Text == "")
            {
                MessageBox.Show("ERROR. Select Role Can not be empty. TRY AGAIN");
            }

            else if(UserID_textBox.Text == "")
            {
                MessageBox.Show("ERROR. User Id Can not be empty. TRY AGAIN");
            }

            else if(Passwrod_textBox.Text == "")
            {
                MessageBox.Show("ERROR. Password Can not be empty. TRY AGAIN");
            }


            else
            {
                if (UserID_textBox.Text == "" && Passwrod_textBox.Text == "")
                {
                    MessageBox.Show("User Id and password cannot be empty");
                }
                else if (UserID_textBox.Text == "")
                {
                    MessageBox.Show("User Id cannot be empty");
                }
                else if (Passwrod_textBox.Text == "")
                {
                    MessageBox.Show("Password cannot be empty");
                }
                else
                {
                    EmployeeDataAccess EuserDataAccess = new EmployeeDataAccess();
                    if (EuserDataAccess.GetEmpStatus(UserID_textBox.Text) == "Invalid   ")
                    {
                        MessageBox.Show("User Is Not Approved.");
                    }
                    else
                    {
                        EmployeeDataAccess EuseDataAccess = new EmployeeDataAccess();
                        if (EuseDataAccess.LoginValidation(SelectRole_comboBox.Text, UserID_textBox.Text, Passwrod_textBox.Text))
                        {
                            if (SelectRole_comboBox.Text == "Employee")
                            {
                                Dashboard dashboard = new Dashboard(UserID_textBox.Text);
                                dashboard.Management_button.Visible = false;

                                dashboard.Show(); 
                                this.Hide();
                            }
                            else
                            {

                                Dashboard dashboard = new Dashboard(UserID_textBox.Text);
                                dashboard.Show();
                                this.Hide();


                            }


                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password or role");
                        }
                    }
                }
            }

        }

        private void SelectRole_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccount_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            this.Hide();
            createAccount.Show();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword Fp = new ForgetPassword();
            this.Hide();
            Fp.Show();

        }
    }
    
}
