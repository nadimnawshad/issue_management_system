
using IssueMAnagementSystemV1._0.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueMAnagementSystemV1._0.DataAccessLayer
{
    class IssuesDataAccess : DatabaseConnection
    {

        public bool CreateIssue(Issues Issue)
        {
            string sql = "INSERT INTO Issues(IssueDate,IssueSubject,IssueStatus,IssueDescription,Deadline,AssigneeId,AssignedBy,SubmitTime,ChangeAssigneeReason,ChangedAssignee) VALUES('" + Issue.IssueDate + "','" + Issue.IssueSubject + "','" + Issue.IssueStatus + "','" + Issue.IssueDescription + "','" + Issue.Deadline + "','" + Issue.AssigneeId + "','" + Issue.AssignedById + "','" + Issue.SubmitTime + "','" + Issue.ChangeAssigneeReason + "','" + Issue.ChangedAssignee + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateIssue(string IssueSubject, string IssueDescription,string  Deadline, string id)
        {
            string sql = "UPDATE Issues SET IssueSubject='" + IssueSubject + "',IssueDescription='" + IssueDescription + "',Deadline='" + Deadline + "' WHERE Id=" + id;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool UpdateIssueStatus(int IssueId, string IssueStatus)
        {
            string sql = "UPDATE Issues SET IssueStatus='" + IssueStatus + "' WHERE Id=" + IssueId  ;
            int result = this.ExecuteQuery(sql);
            
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool UpdateIssueSubmitTime(int IssueId, string submitTime)
        {
            string sql = "UPDATE Issues SET SubmitTime='" + submitTime + "' WHERE Id=" + IssueId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        


        public bool DeleteIssue(int IssueId)
        {
            string sql = "DELETE FROM Issues WHERE Id=" + IssueId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public List<Issues> GetIssuesByEmpId(string eId)
        {
            string sql = "SELECT * FROM Issues WHERE AssigneeId=" + eId;
            SqlDataReader reader = this.GetData(sql);
            List<Issues> IssueList = new List<Issues>();
            while (reader.Read())
            {
                Issues Issue = new Issues();
                Issue.IssueId = Convert.ToString(reader["Id"]);
                Issue.IssueDate = reader["IssueDate"].ToString();
                Issue.IssueSubject = (reader["IssueSubject"].ToString());
                Issue.IssueStatus = reader["IssueStatus"].ToString();
                Issue.IssueDescription = reader["IssueDescription"].ToString();
                Issue.Deadline = reader["Deadline"].ToString();
                Issue.AssigneeId = eId;
                Issue.SubmitTime= reader["SubmitTime"].ToString();
                Issue.ChangeAssigneeReason= reader["ChangeAssigneeReason"].ToString();
                Issue.ChangedAssignee= reader["ChangedAssignee"].ToString();
                Issue.AssignedById= reader["AssignedBy"].ToString();
                IssueList.Add(Issue);
            }
            return IssueList;
        }


        public List<Issues> GetIssuesForChangeAssignee(string eId)
        {
            string Req = "Requested ";
            string sql = "SELECT * FROM Issues  WHERE AssignedBy='" + eId + "' AND ChangedAssignee='" + Req + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Issues> IssueList = new List<Issues>();
            while (reader.Read())
            {
                Issues Issue = new Issues();
                Issue.IssueId = Convert.ToString(reader["Id"]);
                Issue.IssueDate = reader["IssueDate"].ToString();
                Issue.IssueSubject = reader["IssueSubject"].ToString();
                Issue.IssueStatus = (reader["IssueStatus"].ToString());
                Issue.IssueDescription = reader["IssueDescription"].ToString();
                Issue.Deadline = reader["Deadline"].ToString();
                Issue.AssigneeId = reader["AssigneeId"].ToString();
                Issue.SubmitTime = reader["SubmitTime"].ToString();
                Issue.AssignedById = reader["AssignedBy"].ToString();
                Issue.ChangeAssigneeReason = reader["ChangeAssigneeReason"].ToString();
                Issue.ChangedAssignee = reader["ChangedAssignee"].ToString();
                Issue.AskingDate = "N/A"; //reader["AskingDate"].ToString();
                Issue.Reason = "N/A"; //reader["Reason"].ToString();
                Issue.Approval = "N/A";// reader["Approval"].ToString();
                Issue.AssignedById = reader["AssignedBy"].ToString();
                IssueList.Add(Issue);
            }
            return IssueList;
        }

        public List<Issues> GetIssuesForApproval(string eId)
        {
            string Req = "Pending             ";
            string sql = "SELECT * FROM ExtensionTime  WHERE AssignedBy='" + eId + "' AND Approval='" + Req+ "'";
            SqlDataReader reader = this.GetData(sql);
            List<Issues> IssueList = new List<Issues>();
            while (reader.Read())
            {
                Issues Issue = new Issues();
                Issue.IssueId = Convert.ToString(reader["IssueId"]);
                Issue.IssueDate = "N/A";//reader["IssueDate"].ToString();
                Issue.IssueSubject = "N/A";//reader["IssueSubject"].ToString();
                Issue.IssueStatus = "N/A";//(reader["IssueStatus"].ToString());
                Issue.IssueDescription = "N/A";//reader["IssueDescription"].ToString();
                Issue.Deadline = "N/A";//reader["Deadline"].ToString();
                Issue.AssigneeId = "N/A";// reader["AssigneeId"].ToString();
                Issue.SubmitTime = "N/A";//reader["SubmitTime"].ToString();
                Issue.AssignedById = "N/A";// reader["AssignedBy"].ToString();
                Issue.ChangeAssigneeReason = "N/A";//reader["ChangeAssigneeReason"].ToString();
                Issue.ChangedAssignee = "N/A";//reader["ChangedAssignee"].ToString();
                Issue.AskingDate = reader["AskingDate"].ToString();
                Issue.Reason = reader["Reason"].ToString();
                Issue.Approval =  reader["Approval"].ToString();//"N/A"; //
                Issue.AssignedById = reader["AssignedBy"].ToString();
                IssueList.Add(Issue);
            }
            return IssueList;
        }


        public List<Issues> GetIssuesByAssignedById(string eId)
        {
            string sql = "SELECT * FROM Issues WHERE AssignedBy=" + eId;
            SqlDataReader reader = this.GetData(sql);
            List<Issues> IssueList = new List<Issues>();
            while (reader.Read())
            {
                Issues Issue = new Issues();

                Issue.IssueId = Convert.ToString(reader["Id"]);
                Issue.IssueDate = reader["IssueDate"].ToString();
                Issue.IssueSubject = reader["IssueSubject"].ToString();
                Issue.IssueStatus = (reader["IssueStatus"].ToString());
                Issue.IssueDescription = reader["IssueDescription"].ToString();
                Issue.Deadline = reader["Deadline"].ToString();
                Issue.AssigneeId = reader["AssigneeId"].ToString();
                Issue.SubmitTime = reader["SubmitTime"].ToString();
                Issue.AssignedById = reader["AssignedBy"].ToString();
                Issue.ChangeAssigneeReason = reader["ChangeAssigneeReason"].ToString();
                Issue.ChangedAssignee = reader["ChangedAssignee"].ToString();
                Issue.AskingDate = "N/A";//reader["AskingDate"].ToString();
                Issue.Reason = "N/A";//reader["Reason"].ToString();
                Issue.Approval = "N/A";// reader["Approval"].ToString();
                Issue.AssignedById = reader["AssignedBy"].ToString();

                IssueList.Add(Issue);
            }
            return IssueList;
        }
        public string GetNewDeadline(string id)
        {
            string str = "Pending             ";
            string sql = "SELECT * FROM ExtensionTime WHERE IssueId='" + id+ "'AND Approval='"+ str+"'";
            SqlDataReader reader = this.GetData(sql);
            List<Issues> IssueList = new List<Issues>();
            while (reader.Read())
            {
                Issues Issue = new Issues();

                Issue.AskingDate = reader["AskingDate"].ToString();
                return Issue.AskingDate;
            }
            return null;
        }
        public bool ChangeDeadline(string IssueId, string newDeadline)
        {
            string msql = "UPDATE Issues SET Deadline='" + newDeadline + "' WHERE Id=" + IssueId;
            int result = this.ExecuteQuery(msql);
            if (result > 0)
            {
                return true;
            }

            else
                return false;
           
            
        }
        public bool ChangeApproval(string IssueId,string Aproval)
        {
            string nsql = "UPDATE ExtensionTime SET Approval='" + Aproval + "' WHERE IssueId=" + IssueId;
            int result = this.ExecuteQuery(nsql);
            if (result > 0)
                return true;
            else
                return false;
        }

        
        public bool ChangeApprovalForChangeAssignee(string IssueId, string Aproval)
        {
            string nsql = "UPDATE Issues SET ChangedAssignee='" + Aproval + "' WHERE Id='" + IssueId+"'";
            int result = this.ExecuteQuery(nsql);
            if (result > 0)
                return true;
            else
                return false;
        }


        public bool ChangeApprovalForApprovedChangeAssignee(string IssueId,string NewAssignee)
        {
            string Aprv = "Approved";
            string nsql = "UPDATE Issues SET ChangedAssignee = '" + Aprv + "',AssigneeId = '" + NewAssignee + "' WHERE Id = " + IssueId  ;
            int result = this.ExecuteQuery(nsql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Issues> GetIssuesByAssignedByIdFromExtention(string eId)
        {
            string sql = "SELECT IssueId,AskingDate,Reason,Approval,AssignedBy FROM ExtensionTime WHERE AssignedBy=" + eId;
            SqlDataReader reader = this.GetData(sql);
            List<Issues> IssueList = new List<Issues>();
            while (reader.Read())
            {
                Issues Issue = new Issues();
                Issue.IssueId = reader["IssueId"].ToString();
                Issue.AskingDate = reader["AskingDate"].ToString();
                Issue.Reason = (reader["Reason"].ToString());
                Issue.Approval = reader["Approval"].ToString();
                Issue.AssignedById = reader["AssignedBy"].ToString();
                

                IssueList.Add(Issue);
            }
            return IssueList;
        }
        public bool CheckRequestedChangeAssignee(string id)
        {



            string sql = "SELECT ChangedAssignee FROM Issues WHERE Id='" + id + "'";
            SqlDataReader reader = this.GetData(sql);



            while (reader.Read())
            {
                Issues Issue = new Issues();



                Issue.ChangedAssignee = reader["ChangedAssignee"].ToString();
                if (Issue.ChangedAssignee == "Requested ")
                    return true;
            }
            return false;
        }



        public bool CheckRequested(string id)
        {



            string sql = "SELECT Approval FROM ExtensionTime WHERE IssueId='" + id + "'";
            SqlDataReader reader = this.GetData(sql);



            while (reader.Read())
            {
                Issues Issue = new Issues();



                Issue.ChangedAssignee = reader["Approval"].ToString();
                if (Issue.ChangedAssignee == "Pending             ")
                    return true;
            }
            return false;
        }
        public bool CreateIssueExtention(Issues Issue)
        {
            string sql = "INSERT INTO ExtensionTime(IssueId,AskingDate,Reason,Approval,AssignedBy) VALUES('" + Issue.IssueId + "','" + Issue.AskingDate + "','" + Issue.Reason + "','" + Issue.Approval + "','" + Issue.AssignedById + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool ChangeAssignee(string IssueId, string Request)
        {
            string sql = "UPDATE Issues SET ChangedAssignee='" + Request + "' WHERE Id=" + IssueId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool SetChangeAssigneeReason(string IssueId, string Reason)
        {
            string sql = "UPDATE Issues SET ChangeAssigneeReason='" + Reason + "' WHERE Id=" + IssueId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Issues> GetIssuesListByName(string id)
        {
            string sql = "SELECT * FROM Issues WHERE Id LIKE '" +id + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Issues> IssueList = new List<Issues>();
            while (reader.Read())
            {
                Issues Issue = new Issues();
                Issue.IssueId = Convert.ToString(reader["Id"]);
                Issue.IssueDate = reader["IssueDate"].ToString();
                Issue.IssueSubject = reader["IssueSubject"].ToString();
                Issue.IssueStatus = (reader["IssueStatus"].ToString());
                Issue.IssueDescription = reader["IssueDescription"].ToString();
                Issue.Deadline = reader["Deadline"].ToString();
                Issue.AssigneeId = reader["AssigneeId"].ToString();
                Issue.SubmitTime = reader["SubmitTime"].ToString();
                Issue.AssignedById = reader["AssignedBy"].ToString();
                Issue.ChangeAssigneeReason = reader["ChangeAssigneeReason"].ToString();
                Issue.ChangedAssignee = reader["ChangedAssignee"].ToString();
                Issue.AskingDate = "N/A"; //reader["AskingDate"].ToString();
                Issue.Reason = "N/A"; //reader["Reason"].ToString();
                Issue.Approval = "N/A"; //reader["Approval"].ToString();
                Issue.AssignedById = "N/A"; //reader["AssignedBy"].ToString();

                IssueList.Add(Issue);

            }
            return IssueList;
        }

        public bool CheckSolve(string id)
        {

            string sql = "SELECT IssueStatus FROM Issues WHERE Id='" + id + "'";
            SqlDataReader reader = this.GetData(sql);

            while (reader.Read())
            {
                Issues Issue = new Issues();

                Issue.IssueStatus = reader["IssueStatus"].ToString();
                if (Issue.IssueStatus == "Solved              ")
                    return false;
            }
            return true;
        }

        public List<Issues> GetAllIssuesList()
        {
            string sql = "SELECT * FROM Issues ";
            SqlDataReader reader = this.GetData(sql);
            List<Issues> IssueList = new List<Issues>();
            while (reader.Read())
            {
                Issues Issue = new Issues();
                Issue.IssueId = Convert.ToString(reader["Id"]);
                Issue.IssueDate = reader["IssueDate"].ToString();
                Issue.IssueSubject = reader["IssueSubject"].ToString();
                Issue.IssueStatus = (reader["IssueStatus"].ToString());
                Issue.IssueDescription = reader["IssueDescription"].ToString();
                Issue.Deadline = reader["Deadline"].ToString();
                Issue.AssigneeId = reader["AssigneeId"].ToString();
                Issue.SubmitTime = reader["SubmitTime"].ToString();
                Issue.AssignedById = reader["AssignedBy"].ToString();
                Issue.ChangeAssigneeReason = reader["ChangeAssigneeReason"].ToString();
                Issue.ChangedAssignee = reader["ChangedAssignee"].ToString();
                Issue.AskingDate = "N/A"; //reader["AskingDate"].ToString();
                Issue.Reason = "N/A"; //reader["Reason"].ToString();
                Issue.Approval = "N/A"; //reader["Approval"].ToString();
                Issue.AssignedById = "N/A"; //reader["AssignedBy"].ToString();

                IssueList.Add(Issue);

            }
            return IssueList;
        }
        /*public Issues GetIssuesByEmpId(int EmpId)
        {
            string sql = "SELECT * FROM Issues WHERE AssigneeId=" + EmpId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Issues Issue = new Issues();
                Issue.AssigneeId = (int)reader["AssigneeId"];
                Issue.IssueSubject = reader["IssueName"].ToString();
                return Issue;
            }
            return null;

        }*/
        /*public List<Issues> GetIssues()
        {
            string sql = "SELECT * FROM Issues";
            SqlDataReader reader = this.GetData(sql);
            List<Issues> AllIssues = new List<Issues>();
            while (reader.Read())
            {
                Issues Issue = new Issues();
                Issue.IssueId = (int)reader["IssueId"];
                Issue.Iss = reader["IssueName"].ToString();
                AllIssues.Add(Issue);
            }
            return AllIssues;
        }
        public Category GetIssuesById(int IssueId)
        {
            string sql = "SELECT * FROM Issues WHERE CategoryId=" + IssueId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Issues Issue = new Issues();
                Issues.IssuesId = (int)reader["IssueId"];
                Issue.CategoryName = reader["IssueName"].ToString();
                return Issue;
            }
            return null;

        }

        public bool CreateIssue(string IssueSubject)
        {
            string sql = "INSERT INTO Categories(IssueName) VALUES('" + IssueName + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool UpdateIssueStatus(int IssueId, string IssueSubject)
        {
            string sql = "UPDATE Categories SET IssueStatus='" + IssueStatus + "' WHERE CategoryId=" + IssueId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool DeleteIssue(int IssueId)
        {
            string sql = "DELETE FROM Issues WHERE IssueId=" + IssueId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<string> GetIssueSubject()
        {
            string sql = "SELECT * FROM Issues";
            SqlDataReader reader = this.GetData(sql);
            List<string> categories = new List<string>();
            while (reader.Read())
            {
                categories.Add(reader["IssueSubject"].ToString());
            }
            return categories;
        }
        public Issues GetIssuesByName(string IssueName)
        {
            string sql = "SELECT * FROM Issues WHERE IssueName='" + IssueName + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Issues issue = new Issues();
                issue.IssueId = (int)reader["IssueId"];
                Issues.IssueName = reader["IssueName"].ToString();
                return issue;
            }
            return null;

        }*/
    }
}

    
