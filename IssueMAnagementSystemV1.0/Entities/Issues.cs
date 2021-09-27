using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueMAnagementSystemV1._0.Entity
{
    class Issues
    {
        public string IssueId { get; set; }
        public string IssueDate { get; set; }
        public string IssueSubject { get; set; }
        public string IssueStatus { get; set; }
        public string IssueDescription { get; set; }
        public string Deadline { get; set; }
        public string AssigneeId { get; set; }

        public string AskingDate { get; set; }

        public string Reason { get; set; }

        public string Approval { get; set; }

        public string SubmitTime { get; set; }
        public string AssignedById { get; set; }
        public string ChangeAssigneeReason { get; set; }

        public string ChangedAssignee { get; set; }

        

        //IssueDate,IssueSubject,IssueStatus,IssueDescription,Deadline,AssigneeId


    }
}
