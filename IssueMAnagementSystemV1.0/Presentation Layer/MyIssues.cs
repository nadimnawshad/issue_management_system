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
    public partial class MyIssues : Form
    {
        static string eid;
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        public MyIssues(string iid)
        {
            InitializeComponent();
            eid = iid;


        }

        private void MyIssues_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            UpdateGridnewView();
            IssuesDataAccess Ida = new IssuesDataAccess();
            ChangeAssigneBy_dataGridView.DataSource = Ida.GetIssuesForChangeAssignee(eid);
        }
        void UpdateGridView()
        {
            IssuesDataAccess IssueData = new IssuesDataAccess();


            Myissue_dataGridView.DataSource = IssueData.GetIssuesByAssignedById(eid);
        }


        void UpdateGridnewView()
        {
            IssuesDataAccess IssueData = new IssuesDataAccess();


            //IssueRequest_dataGridView.DataSource = IssueData.GetIssuesByAssignedByIdFromExtention(eid);
            IssueRequest_dataGridView.DataSource = IssueData.GetIssuesForApproval(eid);
        }
        private void CreateIssuebackbutton_Click(object sender, EventArgs e)
        {
            if (employeeDataAccess.CheckRole(eid))
            {
                Dashboard dashboard = new Dashboard(eid);
                dashboard.Management_button.Visible = false;
                dashboard.Show();
                this.Hide();



            }
            else
            {

                Dashboard dashboard = new Dashboard(eid);
                dashboard.Show();
                this.Hide();


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Requestissue_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void MyIssues_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        static string Dl;

        private void Approve_button_Click(object sender, EventArgs e)
        {
            IssuesDataAccess isu = new IssuesDataAccess();
            IssuesDataAccess nIsue = new IssuesDataAccess();
            if (nIsue.CheckRequested(ReqApproveIssueId_textBox.Text))
            {
                if (ReqApproveIssueId_textBox.Text == "")
                {
                    MessageBox.Show("Issue Id Can not be empty");
                }
                else
                {
                    //IssuesDataAccess isu = new IssuesDataAccess();
                    Issues Iu = new Issues();

                    IssuesDataAccess isu2 = new IssuesDataAccess();
                    Dl = isu2.GetNewDeadline(ReqApproveIssueId_textBox.Text);

                    if (isu.ChangeApproval(ReqApproveIssueId_textBox.Text, "Approved"))
                    {
                        IssuesDataAccess Isu1 = new IssuesDataAccess();



                        if (Isu1.ChangeDeadline(ReqApproveIssueId_textBox.Text, Dl))
                        {

                            MessageBox.Show("Approved & Deadline Updated");
                            MyIssues dashboard = new MyIssues(eid);
                            this.Hide();
                            dashboard.Show();

                        }
                        else
                        {
                            MessageBox.Show("Error Approving");
                        }
                        // MessageBox.Show("Approved, Please kindly click on Update to Update the timeline ");

                        /* MyIssues mi = new MyIssues(eid);
                         mi.Show();

                         this.Hide();*/
                    }



                    else
                    {
                        MessageBox.Show("Error in approving");
                    }


                }
            }
            else
            {
                MessageBox.Show("Not requested for change deadline");
            }
        }


        private void ReqApproveIssueId_textBox_TextChanged(object sender, EventArgs e)
        {
           /* IssuesDataAccess isu = new IssuesDataAccess();
            Dl = isu.GetNewDeadline(ReqApproveIssueId_textBox.Text);*/
        }

        private void Denybutton_Click(object sender, EventArgs e)
        {
            if (ReqApproveIssueId_textBox.Text == "")
            {
                MessageBox.Show("Issue Id Can not be empty");
            }
            
            else
            {
                
                    IssuesDataAccess isu = new IssuesDataAccess();

                    if (isu.ChangeApproval(ReqApproveIssueId_textBox.Text, "Denied"))
                    {
                        MessageBox.Show("Denied");

                        MyIssues mi = new MyIssues(eid);
                        mi.Show();
                        this.Hide();



                    }

                    else
                    {
                        MessageBox.Show("Error in Denying");
                    }

                
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ModifyIssueid_textBox.Text == "")
            {
                MessageBox.Show("Issue Id Can not be empty");
            }

            else if (ModifyissuenewsubjecttextBox.Text == "")
            {
                MessageBox.Show("Subject Can not be empty");
            }

            else if (ModifyNewdescription_textBox.Text == "")
            {
                MessageBox.Show("Description to Can not be empty");
            }




            else
            {
                Issues issue1 = new Issues();
                issue1.IssueSubject = ModifyissuenewsubjecttextBox.Text;
                issue1.IssueDescription = ModifyNewdescription_textBox.Text;
                issue1.IssueId = ModifyIssueid_textBox.Text;


                issue1.Deadline = Newdeadline_dateTimePicker.Text;
                IssuesDataAccess Iu1 = new IssuesDataAccess();
                if (Iu1.CheckSolve(issue1.IssueId))
                {
                    IssuesDataAccess ida = new IssuesDataAccess();
                    if (ida.UpdateIssue(issue1.IssueSubject, issue1.IssueDescription, issue1.Deadline, issue1.IssueId))
                    {
                        MessageBox.Show("Issue Updated");


                        MyIssues dashboard = new MyIssues(eid);
                        this.Hide();
                        dashboard.Show();

                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                    }
                }
                else
                {
                    MessageBox.Show("Allready solved");
                }
            }
        }


        private void RequestUpdate_button_Click(object sender, EventArgs e)
        {
            IssuesDataAccess isu = new IssuesDataAccess();


            if (isu.ChangeDeadline(ReqApproveIssueId_textBox.Text, Dl))
            {

                MessageBox.Show("Deadline Updated");
                MyIssues dashboard = new MyIssues(eid);
                this.Hide();
                dashboard.Show();

            }
            else
            {
                MessageBox.Show("Error in Deadline Updating");
            }
        }

        private void Myissue_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecrow = Myissue_dataGridView.Rows[index];
            ModifyIssueid_textBox.Text = selecrow.Cells[0].Value.ToString();
        }

        private void MyIssues_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ChangeAssigneeDeny_button_Click(object sender, EventArgs e)
        {
            if (ChangeAssigneeIssueId_textBox.Text == "")
            {
                MessageBox.Show("Issue Id Can not be empty");
            }
            else {
                IssuesDataAccess isu = new IssuesDataAccess();


                if (isu.ChangeApprovalForChangeAssignee(ChangeAssigneeIssueId_textBox.Text, "Denied"))
                {
                    MessageBox.Show("Denied");

                    MyIssues mi = new MyIssues(eid);
                    this.Hide();
                    mi.Show();


                }

                else
                {
                    MessageBox.Show("Error in Denying");
                }
            }


        }

        private void ChangeAssigneeApprovebutton_Click(object sender, EventArgs e)
        {
            IssuesDataAccess nIsue = new IssuesDataAccess();
            if (nIsue.CheckRequestedChangeAssignee(ChangeAssigneeIssueId_textBox.Text))
            {
                IssuesDataAccess isu = new IssuesDataAccess();

                if (ChangeAssigneeIssueId_textBox.Text == "")
                {
                    MessageBox.Show("Issue Id Can not be empty");
                }
                else if (ChangeAssigneeId_textBox.Text == eid)
                {
                    MessageBox.Show("Self assign is not allowed");
                }
                else if (ChangeAssigneeId_textBox.Text == "")
                {
                    MessageBox.Show("New assignee id can not be empty");
                }
                else
                {
                    //IssuesDataAccess isu = new IssuesDataAccess();
                    Issues Iu = new Issues();



                    if (isu.ChangeApprovalForApprovedChangeAssignee(ChangeAssigneeIssueId_textBox.Text, ChangeAssigneeId_textBox.Text))
                    {
                        MessageBox.Show("Approved & new assignee assigned");

                        MyIssues mi = new MyIssues(eid);
                        mi.Show();

                        this.Hide();
                    }



                    else
                    {
                        MessageBox.Show("Error in approving");
                    }

                }
            }
            else
            {
                MessageBox.Show("Issue is not requested for change Assignee");
            }
        }

        private void ChangeAssigneeUpdate_button_Click(object sender, EventArgs e)
        {

        }

        private void ChangeAssigneeId_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IssueRequest_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecrow = IssueRequest_dataGridView.Rows[index];
            ReqApproveIssueId_textBox.Text = selecrow.Cells[0].Value.ToString();
        }

        private void ChangeAssigneBy_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecrow = IssueRequest_dataGridView.Rows[index];
            ChangeAssigneeIssueId_textBox.Text = selecrow.Cells[0].Value.ToString();
        }
    }
}

