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
    public partial class ChangePassPage : Form
    {
        string id;
        EmployeeDataAccess empDataAccess = new EmployeeDataAccess();
        public ChangePassPage(string Eid )
        {
            InitializeComponent();
            this.ControlBox = false;
            id = Eid;
        }

        private void Forgetpass_button_Click(object sender, EventArgs e)
        {
            if (Id_textBox.Text == "")
            {
                MessageBox.Show("Id Can not be empty");
            }

            else if (OldPass_textBox.Text == "")
            {
                MessageBox.Show("Old Password Can not be empty");
            }

            else if (Newpass_textBox.Text == "")
            {
                MessageBox.Show("New Password Can not be empty");
            }

            else if (ConfirmePass_textBox.Text == "")
            {
                MessageBox.Show("{Please Confirm the Password");
            }


            else if (Newpass_textBox.Text.Length < 8 || Newpass_textBox.Text.Length >= 14)
            {
                MessageBox.Show("Password Can not be less than 8 and grater than 14 characters");
            }
            else if (Newpass_textBox.Text != ConfirmePass_textBox.Text)
            {
                MessageBox.Show("PassWord & Confirm Password not matched");
            }
            else
            {
                DialogResult dgresult = MessageBox.Show("Are you Sure?", "Confirm?", MessageBoxButtons.YesNo);
                if (dgresult == DialogResult.Yes)
                {
                    Employees Euser = new Employees();

                    Euser.Eid = Convert.ToInt32(Id_textBox.Text);
                    Euser.Password = Newpass_textBox.Text;

                    if (empDataAccess.UpdatePassword(Euser.Eid.ToString(), "", OldPass_textBox.Text, Euser.Password))
                    {
                        MessageBox.Show("Password Updated");

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Old Password does not Match ");
                    }
                }
                
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ChangePassPage_Load(object sender, EventArgs e)
        {

        }
    }
}
