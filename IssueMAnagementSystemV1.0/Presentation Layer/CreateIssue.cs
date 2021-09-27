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
    public partial class CreateIssue : Form
    {
        static string id;
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        public CreateIssue(string iid)
        {
            InitializeComponent();
            id = iid;
            CreateissueId_label.Text+= id;
        }

        private void EmployeeName_label_Click(object sender, EventArgs e)
        {

        }

        private void IssueAssignbutton_Click(object sender, EventArgs e)
        {
            if (IssueSubjecttextBox.Text == "")
            {
                MessageBox.Show("Subject Can not be empty");
            }

            else if (IssueDescriptiontextBox.Text == "")
            {
                MessageBox.Show("Description Can not be empty");
            }

            else if (AssignIdtextBox.Text == "")
            {
                MessageBox.Show("Assign to Can not be empty");
            }
            else if (AssignIdtextBox.Text == id)
            {
                MessageBox.Show("Self assign is not allowed ");
            }

            else if (DeadlinedateTimePicker.Text == "")
            {
                MessageBox.Show("Deadline Can not empty");
            }
            else if (AssigneIddateTimePicker.Text == "")
            {
                MessageBox.Show("AssigneId Time Can not empty");
            }


            else
            {
                Issues issue1 = new Issues();
                issue1.IssueSubject = IssueSubjecttextBox.Text;
                issue1.IssueDescription = IssueDescriptiontextBox.Text;
                issue1.AssigneeId = AssignIdtextBox.Text;
                issue1.IssueDate = AssigneIddateTimePicker.Text;
                issue1.Deadline = DeadlinedateTimePicker.Text;
                issue1.IssueStatus = "Processing";
                issue1.AssignedById = id;
                issue1.SubmitTime = "Pending";
                issue1.ChangeAssigneeReason = "N/A";
                issue1.ChangedAssignee = "N/A";
                    


                IssuesDataAccess ida = new IssuesDataAccess();
                if (ida.CreateIssue(issue1))
                {
                    MessageBox.Show("Issue added and in processing");

                    if (employeeDataAccess.CheckRole(id))
                    {
                        Dashboard dashboard = new Dashboard(id);
                        dashboard.Management_button.Visible = false;
                        this.Hide();
                        dashboard.Show();


                    }
                    else
                    {

                        Dashboard dashboard = new Dashboard(id);
                        this.Hide();
                        dashboard.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Error in adding");
                }
            }
        }

        private void AssigneIddateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateIssuebackbutton_Click(object sender, EventArgs e)
        {


            if (employeeDataAccess.CheckRole(id))
            {
                Dashboard dashboard = new Dashboard(id);
                dashboard.Management_button.Visible = false;
                this.Hide();
                dashboard.Show();


            }
            else
            {

                Dashboard dashboard = new Dashboard(id);
                this.Hide();
                dashboard.Show();

            }
                
        }

        private void CreateIssue_Load(object sender, EventArgs e)
        {

        }

        private void DIdlabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateIssue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AssignIdtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    
