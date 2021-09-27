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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreaeAccount_button_Click(object sender, EventArgs e)
        {
            if (SelectRole_comboBox.Text == "")
            {
                MessageBox.Show("Select Role Can not be empty");
            }

            else if (Ename_textBox.Text == "")
            {
                MessageBox.Show("Name Can not be empty");
            }

            else if (EUserName_textBox.Text == "")
            {
                MessageBox.Show("User Name Can not be empty");
            }

            else if (EPasswrod_textBox.Text == "")
            {
                MessageBox.Show("Password Can not empty");
            }

            else if (EPasswrod_textBox.Text.Length < 8 || EPasswrod_textBox.Text.Length >= 14)
            {
                MessageBox.Show("Password Can not be less than 8 and grater than 14 characters");
            }

            else if (Email_textBox.Text == "")
            {
                MessageBox.Show("Email Can not be empty");
            }

            else if (Department_comboBox.Text == "")
            {
                MessageBox.Show("Department Can not be empty");
            }

            else if (PhoneNumber_textBox.Text == "")
            {
                MessageBox.Show("Phone Number Can not be empty");
            }

            else if (Address_textBox.Text == "")
            {
                MessageBox.Show("Address Can not be empty");
            }
            
                 else if (EPasswrod_textBox.Text != ConfirmePass_textBox.Text)
            {
                MessageBox.Show("PassWord & Confirm Password not matched");
            }
            else
            {
                Employees Euser = new Employees();
                Euser.Name = Ename_textBox.Text;
                Euser.UserName = EUserName_textBox.Text;
                Euser.Password = EPasswrod_textBox.Text;
                Euser.Email = Email_textBox.Text;
                Euser.Estatus = "Invalid";
                Euser.Edept = Department_comboBox.Text;
                Euser.Phone = PhoneNumber_textBox.Text;
                Euser.Address = Address_textBox.Text;
                Euser.ERole = SelectRole_comboBox.Text;
                Euser.Points = 0;

                

                EmployeeDataAccess EmpDataAccess = new EmployeeDataAccess();
                if (EmpDataAccess.EmployeeRegister(Euser))
                {
                    MessageBox.Show("User added");
                    /*EmployeeDataAccess ism = new EmployeeDataAccess();
                    Euser.Eid = ism.GetId(Euser.UserName, Euser.Password);*/
                    AccountOutput accounOutput = new AccountOutput(Euser.Name, Euser.UserName, Euser.Eid.ToString(), Euser.Email, Euser.Edept, Euser.ERole, Euser.Estatus, Euser.Phone, Euser.Address, Euser.Password);
                    this.Hide();
                    accounOutput.Show();
                }
                else
                {
                    MessageBox.Show("Error in adding");
                }
            }
            /*{
                SqlConnection sqlcon = new SqlConnection("Server=DESKTOP-6UFALKB;Database=IssueManagementSystem;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM EMPLOYEES WHERE  EROLE='" + SelectRole_comboBox.Text, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Can not be more than one admin");
                }
                else
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO EMPLOYEES values(@Ename,@EuserName,@Password,@Email,@ERole,@EDept,@Phone,@EAddress)", sqlcon);
                    cmd.Parameters.AddWithValue("@Ename", Ename_textBox.Text);
                    cmd.Parameters.AddWithValue("@EuserName", EUserName_textBox.Text);
                    cmd.Parameters.AddWithValue("@Password", EPasswrod_textBox.Text);
                    cmd.Parameters.AddWithValue("@Email", Email_textBox.Text);
                    cmd.Parameters.AddWithValue("@ERole", SelectRole_comboBox.Text);
                    cmd.Parameters.AddWithValue("@EDept", Department_comboBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", int.Parse(PhoneNumber_textBox.Text));
                    cmd.Parameters.AddWithValue("@Address", Address_textBox.Text);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Account Created.");
                        //binddatagrid();
                    }
                    sqlcon.Close();

                }
            }*/
        }

        private void SelectRole_Click(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Logo_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();
 
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EPasswrod_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgreeCheck_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AgreeCheck_checkBox.Checked == true)
            {
                CreaeAccount_button.Enabled = true;
            }
        }
    }
}
