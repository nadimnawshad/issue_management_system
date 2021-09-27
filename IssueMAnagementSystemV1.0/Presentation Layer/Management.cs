using IssueMAnagementSystemV1._0.DataAccessLayer;
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
    public partial class Management : Form
    {
        static string Iid ;
        public Management(string Id)
        {
            InitializeComponent();
            Iid = Id;

        }

        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Searhemp_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Issuemanagement_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Employeemanagement_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        private void Management_Load(object sender, EventArgs e)
        {
            // UpdateGridView();
            IssuesDataAccess Eda = new IssuesDataAccess();
            AllIssue_dataGridView.DataSource = Eda.GetAllIssuesList();
            EmployeeDataAccess Ea = new EmployeeDataAccess();
            Allemployeedata_GridView.DataSource = Ea.GetAllEmpList();
            EmployeeDataAccess Eas = new EmployeeDataAccess();
            AppointEmp_dataGridView.DataSource = Eas.GetEmpListForAppoint();

            
        }

        private void SearchIssueId_textBox_TextChanged(object sender, EventArgs e)
        {
            IssuesDataAccess IssueData = new IssuesDataAccess();


            AllIssue_dataGridView.DataSource = IssueData.GetIssuesListByName(SearchIssueId_textBox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EmployeeDataAccess eda = new EmployeeDataAccess();

            Allemployeedata_GridView.DataSource = eda.GetEmpListById(SearchEid_textBox.Text);

        }

        private void Empdlt_button_Click(object sender, EventArgs e)
        {
            if(Removeempid_textBox.Text=="")
            {
                MessageBox.Show("Employee Id Can Not be empty");
            }
            else if (Removeempid_textBox.Text == Iid)
            {
                MessageBox.Show("You can not remove yourself ");
            }
            else
            {
                DialogResult dgresult = MessageBox.Show("Are you Sure?", "Confirm?", MessageBoxButtons.YesNo);
                if (dgresult == DialogResult.Yes)
                {
                    EmployeeDataAccess Emp = new EmployeeDataAccess();
                    if (Emp.DeleteEmp(Convert.ToInt32(Removeempid_textBox.Text)))
                    {
                        MessageBox.Show("Employee Removed");
                        Management Mng = new Management(Iid);
                        this.Hide();
                        Mng.Show();

                    }
                    else
                    {
                        MessageBox.Show("Error In Employee Removal");
                    }
                }
                    

            }
        }


        private void removeissue_button_Click(object sender, EventArgs e)
        {
            
            if(removeissueid_textBox.Text=="")
            {
                MessageBox.Show("Issue Id Cannot be empty");
            }
            else
            {
                DialogResult dgresult = MessageBox.Show("Are you Sure?", "Confirm?", MessageBoxButtons.YesNo);
                if (dgresult == DialogResult.Yes)
                {
                    IssuesDataAccess ida = new IssuesDataAccess();

                    if (ida.DeleteIssue(Convert.ToInt32(removeissueid_textBox.Text)))
                    {
                        MessageBox.Show("Issue Deleted");
                        Management Mnt = new Management(Iid);
                        this.Hide();
                        Mnt.Show();

                    }
                    else
                    {
                        MessageBox.Show("Issue Cann't be deleted");
                    }
                }
                    
            }
        }

        private void Approve_button_Click(object sender, EventArgs e)
        {
            if(Approveid_textBox.Text=="")
            {
                MessageBox.Show("Employee is can not be empty");
            }
            else if (Removeempid_textBox.Text == Iid)
            {
                MessageBox.Show("You can not remove yourself ");
            }
            else
            {
                EmployeeDataAccess Eda = new EmployeeDataAccess();
                if(Eda.UpdateStatus(Approveid_textBox.Text))
                {
                    MessageBox.Show("User approved");
                    Management Mng = new Management(Iid);
                    this.Hide();
                    Mng.Show();
                }
                else
                {
                    MessageBox.Show("Error in approving");
                }
            }
        }

        private void Removeempid_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chatbackbutton_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess Edu = new EmployeeDataAccess();
            if (Edu.CheckRole(Iid))
            {
                Dashboard dashboard = new Dashboard(Iid);
                dashboard.Management_button.Visible = false;
                this.Hide();
                dashboard.Show();


            }
            else
            {

                Dashboard dashboard = new Dashboard(Iid);
                this.Hide();
                dashboard.Show();

            }
        }

        private void Issuemanagement_groupBox_LocationChanged(object sender, EventArgs e)
        {

        }

        private void Approveid_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Appoint_button_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess Eas = new EmployeeDataAccess();
            if (Eas.ValidCheckPromoter(Iid))
            {
                if (AppointEmp_textBox.Text == "")
                {
                    MessageBox.Show("Employee id can not be empty");
                }
                else if (AppointEmp_textBox.Text == Iid)
                {
                    MessageBox.Show("Self Promote not allowed");
                }
                else
                {
                    EmployeeDataAccess Ea = new EmployeeDataAccess();
                    EmployeeDataAccess Ee = new EmployeeDataAccess();
                    if (Ee.ValidCheckForPromote(AppointEmp_textBox.Text))
                    {
                        if (Ea.UpdateRole(AppointEmp_textBox.Text))
                        {
                            MessageBox.Show("Promoted successfully");
                            MessageBox.Show("User approved");
                            Management Mng = new Management(Iid);
                            this.Hide();
                            Mng.Show();

                        }
                        else
                        {
                            MessageBox.Show("Error in Promoting ");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Employee is not valid for promotion");
                    }
                }
            }
            else
            {
                MessageBox.Show("You are valid to promote anyone");
            }
        }

        private void AllIssue_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecrow = AllIssue_dataGridView.Rows[index];
            removeissueid_textBox.Text = selecrow.Cells[0].Value.ToString();
        }

        private void IssueSearch_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Allemployeedata_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Appoint_button_Click_1(object sender, EventArgs e)
        {
            EmployeeDataAccess Eas = new EmployeeDataAccess();
            if (Eas.ValidCheckPromoter(Iid))
            {
                if (AppointEmp_textBox.Text == "")
                {
                    MessageBox.Show("Employee id can not be empty");
                }
                else if (AppointEmp_textBox.Text == Iid)
                {
                    MessageBox.Show("Self Promote not allowed");
                }
                else
                {
                    EmployeeDataAccess Ea = new EmployeeDataAccess();
                    EmployeeDataAccess Ee = new EmployeeDataAccess();
                    if (Ee.ValidCheckForPromote(AppointEmp_textBox.Text))
                    {
                        if (Ea.UpdateRole(AppointEmp_textBox.Text))
                        {
                            MessageBox.Show("Promoted successfully");
                            MessageBox.Show("User approved");
                            Management Mng = new Management(Iid);
                            Mng.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error in Promoting ");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Employee is not valid for promotion");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sorry, only admin can promote anyone");
            }
        }
    }
}
    