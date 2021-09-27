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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Forgetpass_button_Click(object sender, EventArgs e)
        {
            if (ForgetpassId_textBox.Text == "")
            {
                MessageBox.Show("Id Can not be empty");
            }

            else if (Forgetpassusername_textBox.Text == "")
            {
                MessageBox.Show("Username Can not be empty");
            }

            else if (Forgetpassnewpass_textBox.Text == "")
            {
                MessageBox.Show("New Password Can not be empty");
            }


            else if (Forgetpassnewpass_textBox.Text.Length < 8 || Forgetpassnewpass_textBox.Text.Length >= 14)
            {
                MessageBox.Show("Password Can not be less than 8 and grater than 14 characters");
            }
            else if (Forgetpassnewpass_textBox.Text!= ConfirmePass_textBox.Text)
            {
                MessageBox.Show("PassWord & Confirm Password not matched");
            }
            else
            {
                Employees Euser = new Employees();

                Euser.Eid = Convert.ToInt32(ForgetpassId_textBox.Text);
                Euser.Password = Forgetpassnewpass_textBox.Text;
                
                Euser.UserName = Forgetpassusername_textBox.Text;
               


                EmployeeDataAccess EmpDataAccess = new EmployeeDataAccess();
                if (EmpDataAccess.UpdatePassword(Euser.Eid.ToString(), Euser.UserName, Euser.Password))
                {
                    MessageBox.Show("Password Updated");

                    LoginPage Lp = new LoginPage();
                    this.Hide();
                    Lp.Show();
                }
                else
                {
                    MessageBox.Show("Error in Update Password");
                }
            }

        }

        private void CreateIssuebackbutton_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();

        }

        private void ForgetPasswordusername_label_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmePass_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmpass_label_Click(object sender, EventArgs e)
        {

        }

        private void Forgetpasswordnewpass_label_Click(object sender, EventArgs e)
        {

        }

        private void Forgetpassnewpass_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgetpassId_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgetPasswordid_label_Click(object sender, EventArgs e)
        {

        }

        private void Forgetpassusername_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }
    }
    }

