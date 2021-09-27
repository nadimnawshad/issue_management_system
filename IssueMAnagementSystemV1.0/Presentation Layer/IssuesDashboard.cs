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
    public partial class IssuesDashboard : Form
    {
        public static string Euid;
        public static int point;
       EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        public IssuesDashboard(string userId,int Points)
        {
            InitializeComponent();
            Euid = userId;
            point = Points;
        }

        public object Password { get; private set; }
        public object EId { get; private set; }

        

        private void IssuesDashboard_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        void UpdateGridView()
        {
            IssuesDataAccess IssueData = new IssuesDataAccess();
           
           
            IssuesdataGridView.DataSource = IssueData.GetIssuesByEmpId(Euid);
        }

        private void IssuesgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void IssuesBackbutton_Click(object sender, EventArgs e)
        {
            if (employeeDataAccess.CheckRole(Euid))
            {
                Dashboard dashboard = new Dashboard(Euid);
                dashboard.Management_button.Visible = false;
                this.Hide();
                dashboard.Show();


            }
            else
            {

                Dashboard dashboard = new Dashboard(Euid);
                this.Hide();
                dashboard.Show();

            }
        }

        private void Issuesolvebutton_Click(object sender, EventArgs e)
        {
            if (Issuesolve_textBox.Text == "")
            {
                MessageBox.Show("Id Can not be empty");
            }
            else
            {

                int id = Convert.ToInt32(Issuesolve_textBox.Text);
                IssuesDataAccess Iu1 = new IssuesDataAccess();
                if (Iu1.CheckSolve(id.ToString()))
                {
                    IssuesDataAccess ism = new IssuesDataAccess();
                    ism.UpdateIssueStatus(id, "Solved");
                    ism.UpdateIssueSubmitTime(id, IssuesolvedateTimePicker.Text);

                    IssuesDashboard idb = new IssuesDashboard(Euid, point);
                    EmployeeDataAccess ims = new EmployeeDataAccess();
                    int poin = point + 10;
                    if (ims.UpdatePoints(Euid, poin))
                    {
                        MessageBox.Show("Issue Submitted Successfully & 10 points Achieved");
                        this.Hide();
                        idb.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Allready solved");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Requestextendissueid_textBox.Text == "")
            {
                MessageBox.Show("Id Can not be empty");
            }
            else if (RequestIssuedById_textBox.Text == Euid)
            {
                MessageBox.Show("Self request is not allowed ");
            }

            else if (RequestExtendReason_comboBox.Text == "")
            {
                MessageBox.Show("Reason must be chosen.");
            }

            else if (RequestIssuedById_textBox.Text == "")
            {
                MessageBox.Show("Issued By Id cannot be empty.");
            }

            else
            {
                Issues Euser = new Issues();
                Euser.IssueId = Requestextendissueid_textBox.Text;
                Euser.AskingDate = IssueextenddateTimePicker.Text;
                Euser.Reason = RequestExtendReason_comboBox.Text;
                Euser.Approval = "Pending";
                Euser.AssignedById = RequestIssuedById_textBox.Text;


                IssuesDataAccess ism = new IssuesDataAccess();
                IssuesDataAccess Iu1 = new IssuesDataAccess();
                if (Iu1.CheckSolve(Euser.IssueId))
                {
                    if (ism.CreateIssueExtention(Euser))
                    {
                        int poin = point - 5;
                        EmployeeDataAccess ims = new EmployeeDataAccess();
                        if (ims.UpdatePoints(Euid, poin))
                        {
                            MessageBox.Show("Request Submitted Successfully & 5 point deducted");
                            /*EmployeeDataAccess ism = new EmployeeDataAccess();
                            Euser.Eid = ism.GetId(Euser.UserName, Euser.Password);*/

                            IssuesDashboard idb = new IssuesDashboard(Euid, point);
                            this.Hide();
                            idb.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Error in requesting");
                    }
                }
                else
                {
                    MessageBox.Show("Allready solved");
                }



            }



        }
        

        private void Requestextendissueid_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RequestChangeAssigneetextBox.Text == "")
            {
                MessageBox.Show("Issue Id Can not be empty");
            }
            else
            {
                Issues Euser = new Issues();
                Euser.IssueId = RequestChangeAssigneetextBox.Text;
                
                Euser.Reason = Requestchangeassignee_comboBox.Text;
                Euser.ChangedAssignee = "Requested";

                IssuesDataAccess ism = new IssuesDataAccess();
                IssuesDataAccess Iu1 = new IssuesDataAccess();
                if (Iu1.CheckSolve(Euser.IssueId))
                {
                    if (ism.ChangeAssignee(Euser.IssueId, Euser.ChangedAssignee))
                    {
                        if (ism.SetChangeAssigneeReason(Euser.IssueId, Euser.Reason))
                        {
                            int poin = point - 5;
                            EmployeeDataAccess ims = new EmployeeDataAccess();
                            if (ims.UpdatePoints(Euid, poin))
                            {
                                MessageBox.Show("Request Submitted Successfully & 5 points deducted");


                                IssuesDashboard idb = new IssuesDashboard(Euid, point);
                                this.Hide();
                                idb.Show();

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error in requesting");
                    }
                }
                else
                {
                    MessageBox.Show("Allready solved");
                }
            }
        }

        private void IssuesDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Issuesolve_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestIssuedById_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Issuebutton_Click(object sender, EventArgs e)
        {
            Changeassignee_groupBox.Visible = true;
            Issuesolve_groupBox.Visible = false;
            Extenddeadlin_groupBox.Visible = false;
        }

        private void Myissuebutton_Click(object sender, EventArgs e)
        {
            Changeassignee_groupBox.Visible = false;
            Issuesolve_groupBox.Visible = true;
            Extenddeadlin_groupBox.Visible = false;
        }

        private void MakeIssuebutton_Click(object sender, EventArgs e)
        {
            Changeassignee_groupBox.Visible = false;
            Issuesolve_groupBox.Visible = false; 
            Extenddeadlin_groupBox.Visible = true; 
        }

        private void IssuesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecrow = IssuesdataGridView.Rows[index];
            RequestChangeAssigneetextBox.Text = selecrow.Cells[0].Value.ToString();
            Issuesolve_textBox.Text = selecrow.Cells[0].Value.ToString();
            Requestextendissueid_textBox.Text = selecrow.Cells[0].Value.ToString();
            RequestIssuedById_textBox.Text = selecrow.Cells[11].Value.ToString();


        }
    }
}
