
namespace IssueMAnagementSystemV1._0.Presentation_Layer
{
    partial class IssuesDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IssuesgroupBox = new System.Windows.Forms.GroupBox();
            this.IssuesdataGridView = new System.Windows.Forms.DataGridView();
            this.IssuesBackbutton = new System.Windows.Forms.Button();
            this.Issuesolve_groupBox = new System.Windows.Forms.GroupBox();
            this.solvetime_label = new System.Windows.Forms.Label();
            this.IssuesolvedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Issuesolvebutton = new System.Windows.Forms.Button();
            this.Submitissueid_label = new System.Windows.Forms.Label();
            this.Issuesolve_textBox = new System.Windows.Forms.TextBox();
            this.Extenddeadlin_groupBox = new System.Windows.Forms.GroupBox();
            this.RequestIssuedById_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RequestExtendReason_label = new System.Windows.Forms.Label();
            this.RequestExtendReason_comboBox = new System.Windows.Forms.ComboBox();
            this.Extend_label = new System.Windows.Forms.Label();
            this.IssueextenddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Issuerextenddeadlinerequestbutton = new System.Windows.Forms.Button();
            this.Requestextendissueid_textBox = new System.Windows.Forms.TextBox();
            this.Changeassignee_groupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.reason_label = new System.Windows.Forms.Label();
            this.RequestChangeAssigneetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Requestchangeassignee_comboBox = new System.Windows.Forms.ComboBox();
            this.ExtendDeadLine_button = new System.Windows.Forms.Button();
            this.SolveIssues_button = new System.Windows.Forms.Button();
            this.ReqCngAssignee_button = new System.Windows.Forms.Button();
            this.Logo_Box = new System.Windows.Forms.PictureBox();
            this.IssuesgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssuesdataGridView)).BeginInit();
            this.Issuesolve_groupBox.SuspendLayout();
            this.Extenddeadlin_groupBox.SuspendLayout();
            this.Changeassignee_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // IssuesgroupBox
            // 
            this.IssuesgroupBox.Controls.Add(this.IssuesdataGridView);
            this.IssuesgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuesgroupBox.Location = new System.Drawing.Point(294, 30);
            this.IssuesgroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.IssuesgroupBox.Name = "IssuesgroupBox";
            this.IssuesgroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.IssuesgroupBox.Size = new System.Drawing.Size(457, 217);
            this.IssuesgroupBox.TabIndex = 0;
            this.IssuesgroupBox.TabStop = false;
            this.IssuesgroupBox.Text = "Issues To Solve";
            this.IssuesgroupBox.Enter += new System.EventHandler(this.IssuesgroupBox_Enter);
            // 
            // IssuesdataGridView
            // 
            this.IssuesdataGridView.AllowUserToAddRows = false;
            this.IssuesdataGridView.AllowUserToDeleteRows = false;
            this.IssuesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuesdataGridView.Location = new System.Drawing.Point(4, 28);
            this.IssuesdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.IssuesdataGridView.Name = "IssuesdataGridView";
            this.IssuesdataGridView.ReadOnly = true;
            this.IssuesdataGridView.RowHeadersWidth = 51;
            this.IssuesdataGridView.RowTemplate.Height = 24;
            this.IssuesdataGridView.Size = new System.Drawing.Size(449, 185);
            this.IssuesdataGridView.TabIndex = 0;
            this.IssuesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssuesdataGridView_CellContentClick);
            // 
            // IssuesBackbutton
            // 
            this.IssuesBackbutton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.IssuesBackbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IssuesBackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuesBackbutton.Location = new System.Drawing.Point(676, 530);
            this.IssuesBackbutton.Margin = new System.Windows.Forms.Padding(2);
            this.IssuesBackbutton.Name = "IssuesBackbutton";
            this.IssuesBackbutton.Size = new System.Drawing.Size(97, 31);
            this.IssuesBackbutton.TabIndex = 1;
            this.IssuesBackbutton.Text = "Go Back";
            this.IssuesBackbutton.UseVisualStyleBackColor = false;
            this.IssuesBackbutton.Click += new System.EventHandler(this.IssuesBackbutton_Click);
            // 
            // Issuesolve_groupBox
            // 
            this.Issuesolve_groupBox.Controls.Add(this.solvetime_label);
            this.Issuesolve_groupBox.Controls.Add(this.IssuesolvedateTimePicker);
            this.Issuesolve_groupBox.Controls.Add(this.Issuesolvebutton);
            this.Issuesolve_groupBox.Controls.Add(this.Submitissueid_label);
            this.Issuesolve_groupBox.Controls.Add(this.Issuesolve_textBox);
            this.Issuesolve_groupBox.Location = new System.Drawing.Point(294, 326);
            this.Issuesolve_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.Issuesolve_groupBox.Name = "Issuesolve_groupBox";
            this.Issuesolve_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.Issuesolve_groupBox.Size = new System.Drawing.Size(234, 173);
            this.Issuesolve_groupBox.TabIndex = 7;
            this.Issuesolve_groupBox.TabStop = false;
            this.Issuesolve_groupBox.Text = "Issue ";
            this.Issuesolve_groupBox.Visible = false;
            // 
            // solvetime_label
            // 
            this.solvetime_label.AutoSize = true;
            this.solvetime_label.Location = new System.Drawing.Point(-3, 74);
            this.solvetime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.solvetime_label.Name = "solvetime_label";
            this.solvetime_label.Size = new System.Drawing.Size(63, 13);
            this.solvetime_label.TabIndex = 11;
            this.solvetime_label.Text = "Solve Time:";
            // 
            // IssuesolvedateTimePicker
            // 
            this.IssuesolvedateTimePicker.Location = new System.Drawing.Point(58, 70);
            this.IssuesolvedateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.IssuesolvedateTimePicker.MinDate = new System.DateTime(2021, 8, 19, 0, 0, 0, 0);
            this.IssuesolvedateTimePicker.Name = "IssuesolvedateTimePicker";
            this.IssuesolvedateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.IssuesolvedateTimePicker.TabIndex = 10;
            this.IssuesolvedateTimePicker.Value = new System.DateTime(2021, 8, 19, 0, 0, 0, 0);
            // 
            // Issuesolvebutton
            // 
            this.Issuesolvebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Issuesolvebutton.Location = new System.Drawing.Point(71, 136);
            this.Issuesolvebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Issuesolvebutton.Name = "Issuesolvebutton";
            this.Issuesolvebutton.Size = new System.Drawing.Size(100, 30);
            this.Issuesolvebutton.TabIndex = 8;
            this.Issuesolvebutton.Text = "Solved";
            this.Issuesolvebutton.UseVisualStyleBackColor = true;
            this.Issuesolvebutton.Click += new System.EventHandler(this.Issuesolvebutton_Click);
            // 
            // Submitissueid_label
            // 
            this.Submitissueid_label.AutoSize = true;
            this.Submitissueid_label.Location = new System.Drawing.Point(7, 31);
            this.Submitissueid_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Submitissueid_label.Name = "Submitissueid_label";
            this.Submitissueid_label.Size = new System.Drawing.Size(47, 13);
            this.Submitissueid_label.TabIndex = 9;
            this.Submitissueid_label.Text = "Issue Id:";
            // 
            // Issuesolve_textBox
            // 
            this.Issuesolve_textBox.Location = new System.Drawing.Point(58, 28);
            this.Issuesolve_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Issuesolve_textBox.Name = "Issuesolve_textBox";
            this.Issuesolve_textBox.Size = new System.Drawing.Size(148, 20);
            this.Issuesolve_textBox.TabIndex = 7;
            this.Issuesolve_textBox.TextChanged += new System.EventHandler(this.Issuesolve_textBox_TextChanged);
            // 
            // Extenddeadlin_groupBox
            // 
            this.Extenddeadlin_groupBox.Controls.Add(this.RequestIssuedById_textBox);
            this.Extenddeadlin_groupBox.Controls.Add(this.label1);
            this.Extenddeadlin_groupBox.Controls.Add(this.RequestExtendReason_label);
            this.Extenddeadlin_groupBox.Controls.Add(this.RequestExtendReason_comboBox);
            this.Extenddeadlin_groupBox.Controls.Add(this.Extend_label);
            this.Extenddeadlin_groupBox.Controls.Add(this.IssueextenddateTimePicker);
            this.Extenddeadlin_groupBox.Controls.Add(this.label2);
            this.Extenddeadlin_groupBox.Controls.Add(this.Issuerextenddeadlinerequestbutton);
            this.Extenddeadlin_groupBox.Controls.Add(this.Requestextendissueid_textBox);
            this.Extenddeadlin_groupBox.Location = new System.Drawing.Point(532, 326);
            this.Extenddeadlin_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.Extenddeadlin_groupBox.Name = "Extenddeadlin_groupBox";
            this.Extenddeadlin_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.Extenddeadlin_groupBox.Size = new System.Drawing.Size(219, 173);
            this.Extenddeadlin_groupBox.TabIndex = 8;
            this.Extenddeadlin_groupBox.TabStop = false;
            this.Extenddeadlin_groupBox.Text = "Request Extend Deadline";
            this.Extenddeadlin_groupBox.Visible = false;
            // 
            // RequestIssuedById_textBox
            // 
            this.RequestIssuedById_textBox.Location = new System.Drawing.Point(71, 41);
            this.RequestIssuedById_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.RequestIssuedById_textBox.Name = "RequestIssuedById_textBox";
            this.RequestIssuedById_textBox.Size = new System.Drawing.Size(144, 20);
            this.RequestIssuedById_textBox.TabIndex = 16;
            this.RequestIssuedById_textBox.TextChanged += new System.EventHandler(this.RequestIssuedById_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Assigned Id:";
            // 
            // RequestExtendReason_label
            // 
            this.RequestExtendReason_label.AutoSize = true;
            this.RequestExtendReason_label.Location = new System.Drawing.Point(18, 74);
            this.RequestExtendReason_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RequestExtendReason_label.Name = "RequestExtendReason_label";
            this.RequestExtendReason_label.Size = new System.Drawing.Size(50, 13);
            this.RequestExtendReason_label.TabIndex = 14;
            this.RequestExtendReason_label.Text = "Reason :";
            // 
            // RequestExtendReason_comboBox
            // 
            this.RequestExtendReason_comboBox.FormattingEnabled = true;
            this.RequestExtendReason_comboBox.Items.AddRange(new object[] {
            "Funding ",
            "Less-Metarial",
            "Sickness"});
            this.RequestExtendReason_comboBox.Location = new System.Drawing.Point(71, 68);
            this.RequestExtendReason_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.RequestExtendReason_comboBox.Name = "RequestExtendReason_comboBox";
            this.RequestExtendReason_comboBox.Size = new System.Drawing.Size(144, 21);
            this.RequestExtendReason_comboBox.TabIndex = 13;
            // 
            // Extend_label
            // 
            this.Extend_label.AutoSize = true;
            this.Extend_label.Location = new System.Drawing.Point(10, 106);
            this.Extend_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Extend_label.Name = "Extend_label";
            this.Extend_label.Size = new System.Drawing.Size(59, 13);
            this.Extend_label.TabIndex = 11;
            this.Extend_label.Text = "Extend To:";
            // 
            // IssueextenddateTimePicker
            // 
            this.IssueextenddateTimePicker.Location = new System.Drawing.Point(71, 102);
            this.IssueextenddateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.IssueextenddateTimePicker.Name = "IssueextenddateTimePicker";
            this.IssueextenddateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.IssueextenddateTimePicker.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Issue Id:";
            // 
            // Issuerextenddeadlinerequestbutton
            // 
            this.Issuerextenddeadlinerequestbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Issuerextenddeadlinerequestbutton.Location = new System.Drawing.Point(82, 136);
            this.Issuerextenddeadlinerequestbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Issuerextenddeadlinerequestbutton.Name = "Issuerextenddeadlinerequestbutton";
            this.Issuerextenddeadlinerequestbutton.Size = new System.Drawing.Size(100, 30);
            this.Issuerextenddeadlinerequestbutton.TabIndex = 8;
            this.Issuerextenddeadlinerequestbutton.Text = "Request";
            this.Issuerextenddeadlinerequestbutton.UseVisualStyleBackColor = true;
            this.Issuerextenddeadlinerequestbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Requestextendissueid_textBox
            // 
            this.Requestextendissueid_textBox.Location = new System.Drawing.Point(71, 15);
            this.Requestextendissueid_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Requestextendissueid_textBox.Name = "Requestextendissueid_textBox";
            this.Requestextendissueid_textBox.Size = new System.Drawing.Size(144, 20);
            this.Requestextendissueid_textBox.TabIndex = 7;
            this.Requestextendissueid_textBox.TextChanged += new System.EventHandler(this.Requestextendissueid_textBox_TextChanged);
            // 
            // Changeassignee_groupBox
            // 
            this.Changeassignee_groupBox.Controls.Add(this.button2);
            this.Changeassignee_groupBox.Controls.Add(this.reason_label);
            this.Changeassignee_groupBox.Controls.Add(this.RequestChangeAssigneetextBox);
            this.Changeassignee_groupBox.Controls.Add(this.label3);
            this.Changeassignee_groupBox.Controls.Add(this.Requestchangeassignee_comboBox);
            this.Changeassignee_groupBox.Location = new System.Drawing.Point(28, 326);
            this.Changeassignee_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.Changeassignee_groupBox.Name = "Changeassignee_groupBox";
            this.Changeassignee_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.Changeassignee_groupBox.Size = new System.Drawing.Size(229, 173);
            this.Changeassignee_groupBox.TabIndex = 9;
            this.Changeassignee_groupBox.TabStop = false;
            this.Changeassignee_groupBox.Text = "Request Change Assignee";
            this.Changeassignee_groupBox.Visible = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(71, 136);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reason_label
            // 
            this.reason_label.AutoSize = true;
            this.reason_label.Location = new System.Drawing.Point(4, 72);
            this.reason_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reason_label.Name = "reason_label";
            this.reason_label.Size = new System.Drawing.Size(50, 13);
            this.reason_label.TabIndex = 12;
            this.reason_label.Text = "Reason :";
            // 
            // RequestChangeAssigneetextBox
            // 
            this.RequestChangeAssigneetextBox.Location = new System.Drawing.Point(58, 31);
            this.RequestChangeAssigneetextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RequestChangeAssigneetextBox.Name = "RequestChangeAssigneetextBox";
            this.RequestChangeAssigneetextBox.Size = new System.Drawing.Size(156, 20);
            this.RequestChangeAssigneetextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Issue Id:";
            // 
            // Requestchangeassignee_comboBox
            // 
            this.Requestchangeassignee_comboBox.FormattingEnabled = true;
            this.Requestchangeassignee_comboBox.Items.AddRange(new object[] {
            "Funding",
            "Materials",
            "Multiple Issues"});
            this.Requestchangeassignee_comboBox.Location = new System.Drawing.Point(58, 66);
            this.Requestchangeassignee_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.Requestchangeassignee_comboBox.Name = "Requestchangeassignee_comboBox";
            this.Requestchangeassignee_comboBox.Size = new System.Drawing.Size(156, 21);
            this.Requestchangeassignee_comboBox.TabIndex = 0;
            // 
            // ExtendDeadLine_button
            // 
            this.ExtendDeadLine_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtendDeadLine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtendDeadLine_button.Location = new System.Drawing.Point(582, 282);
            this.ExtendDeadLine_button.Margin = new System.Windows.Forms.Padding(4);
            this.ExtendDeadLine_button.Name = "ExtendDeadLine_button";
            this.ExtendDeadLine_button.Size = new System.Drawing.Size(165, 38);
            this.ExtendDeadLine_button.TabIndex = 12;
            this.ExtendDeadLine_button.Text = "Extend DeadLine";
            this.ExtendDeadLine_button.UseVisualStyleBackColor = true;
            this.ExtendDeadLine_button.Click += new System.EventHandler(this.MakeIssuebutton_Click);
            // 
            // SolveIssues_button
            // 
            this.SolveIssues_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SolveIssues_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolveIssues_button.Location = new System.Drawing.Point(352, 282);
            this.SolveIssues_button.Margin = new System.Windows.Forms.Padding(4);
            this.SolveIssues_button.Name = "SolveIssues_button";
            this.SolveIssues_button.Size = new System.Drawing.Size(132, 38);
            this.SolveIssues_button.TabIndex = 11;
            this.SolveIssues_button.Text = "Solve Issues";
            this.SolveIssues_button.UseVisualStyleBackColor = true;
            this.SolveIssues_button.Click += new System.EventHandler(this.Myissuebutton_Click);
            // 
            // ReqCngAssignee_button
            // 
            this.ReqCngAssignee_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReqCngAssignee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqCngAssignee_button.Location = new System.Drawing.Point(28, 282);
            this.ReqCngAssignee_button.Margin = new System.Windows.Forms.Padding(4);
            this.ReqCngAssignee_button.Name = "ReqCngAssignee_button";
            this.ReqCngAssignee_button.Size = new System.Drawing.Size(229, 38);
            this.ReqCngAssignee_button.TabIndex = 10;
            this.ReqCngAssignee_button.Text = "Request Change Assignee ";
            this.ReqCngAssignee_button.UseVisualStyleBackColor = true;
            this.ReqCngAssignee_button.Click += new System.EventHandler(this.Issuebutton_Click);
            // 
            // Logo_Box
            // 
            this.Logo_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo_Box.Image = global::IssueMAnagementSystemV1._0.Properties.Resources.MicrosoftTeams_image__14_;
            this.Logo_Box.Location = new System.Drawing.Point(12, 30);
            this.Logo_Box.Name = "Logo_Box";
            this.Logo_Box.Size = new System.Drawing.Size(266, 217);
            this.Logo_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_Box.TabIndex = 69;
            this.Logo_Box.TabStop = false;
            // 
            // IssuesDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 572);
            this.Controls.Add(this.Logo_Box);
            this.Controls.Add(this.ExtendDeadLine_button);
            this.Controls.Add(this.SolveIssues_button);
            this.Controls.Add(this.ReqCngAssignee_button);
            this.Controls.Add(this.Extenddeadlin_groupBox);
            this.Controls.Add(this.Issuesolve_groupBox);
            this.Controls.Add(this.Changeassignee_groupBox);
            this.Controls.Add(this.IssuesBackbutton);
            this.Controls.Add(this.IssuesgroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IssuesDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssuesDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IssuesDashboard_FormClosing);
            this.Load += new System.EventHandler(this.IssuesDashboard_Load);
            this.IssuesgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IssuesdataGridView)).EndInit();
            this.Issuesolve_groupBox.ResumeLayout(false);
            this.Issuesolve_groupBox.PerformLayout();
            this.Extenddeadlin_groupBox.ResumeLayout(false);
            this.Extenddeadlin_groupBox.PerformLayout();
            this.Changeassignee_groupBox.ResumeLayout(false);
            this.Changeassignee_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox IssuesgroupBox;
        private System.Windows.Forms.DataGridView IssuesdataGridView;
        private System.Windows.Forms.Button IssuesBackbutton;
        private System.Windows.Forms.GroupBox Issuesolve_groupBox;
        private System.Windows.Forms.Label solvetime_label;
        private System.Windows.Forms.DateTimePicker IssuesolvedateTimePicker;
        private System.Windows.Forms.Label Submitissueid_label;
        private System.Windows.Forms.Button Issuesolvebutton;
        private System.Windows.Forms.TextBox Issuesolve_textBox;
        private System.Windows.Forms.GroupBox Extenddeadlin_groupBox;
        private System.Windows.Forms.Label Extend_label;
        private System.Windows.Forms.DateTimePicker IssueextenddateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Issuerextenddeadlinerequestbutton;
        private System.Windows.Forms.TextBox Requestextendissueid_textBox;
        private System.Windows.Forms.GroupBox Changeassignee_groupBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label reason_label;
        private System.Windows.Forms.TextBox RequestChangeAssigneetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Requestchangeassignee_comboBox;
        private System.Windows.Forms.Label RequestExtendReason_label;
        private System.Windows.Forms.ComboBox RequestExtendReason_comboBox;
        private System.Windows.Forms.TextBox RequestIssuedById_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExtendDeadLine_button;
        private System.Windows.Forms.Button SolveIssues_button;
        private System.Windows.Forms.Button ReqCngAssignee_button;
        private System.Windows.Forms.PictureBox Logo_Box;
    }
}