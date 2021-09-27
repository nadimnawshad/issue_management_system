
namespace IssueMAnagementSystemV1._0.Entity
{
    partial class CreateAccount
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
            this.Exit_button = new System.Windows.Forms.Button();
            this.SelectRole_comboBox = new System.Windows.Forms.ComboBox();
            this.CreaeAccount_button = new System.Windows.Forms.Button();
            this.EPasswrod_textBox = new System.Windows.Forms.TextBox();
            this.EPassword = new System.Windows.Forms.Label();
            this.Ename_textBox = new System.Windows.Forms.TextBox();
            this.EmployeeName_label = new System.Windows.Forms.Label();
            this.SelectRole = new System.Windows.Forms.Label();
            this.EUserName_textBox = new System.Windows.Forms.TextBox();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Deparment_label = new System.Windows.Forms.Label();
            this.PhoneNumber_label = new System.Windows.Forms.Label();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.Login_linkLabel = new System.Windows.Forms.LinkLabel();
            this.Notic = new System.Windows.Forms.Label();
            this.Department_comboBox = new System.Windows.Forms.ComboBox();
            this.PhoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConfirmePass_textBox = new System.Windows.Forms.TextBox();
            this.Confirmpass_label = new System.Windows.Forms.Label();
            this.AgreeCheck_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit_button.Location = new System.Drawing.Point(408, 518);
            this.Exit_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(132, 38);
            this.Exit_button.TabIndex = 37;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click_1);
            // 
            // SelectRole_comboBox
            // 
            this.SelectRole_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectRole_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectRole_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectRole_comboBox.FormattingEnabled = true;
            this.SelectRole_comboBox.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.SelectRole_comboBox.Location = new System.Drawing.Point(267, 196);
            this.SelectRole_comboBox.Name = "SelectRole_comboBox";
            this.SelectRole_comboBox.Size = new System.Drawing.Size(273, 21);
            this.SelectRole_comboBox.TabIndex = 36;
            // 
            // CreaeAccount_button
            // 
            this.CreaeAccount_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreaeAccount_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreaeAccount_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreaeAccount_button.Enabled = false;
            this.CreaeAccount_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreaeAccount_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreaeAccount_button.Location = new System.Drawing.Point(267, 518);
            this.CreaeAccount_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreaeAccount_button.Name = "CreaeAccount_button";
            this.CreaeAccount_button.Size = new System.Drawing.Size(132, 38);
            this.CreaeAccount_button.TabIndex = 35;
            this.CreaeAccount_button.Text = "Create Account";
            this.CreaeAccount_button.UseVisualStyleBackColor = false;
            this.CreaeAccount_button.Click += new System.EventHandler(this.CreaeAccount_button_Click);
            // 
            // EPasswrod_textBox
            // 
            this.EPasswrod_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EPasswrod_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EPasswrod_textBox.Location = new System.Drawing.Point(267, 290);
            this.EPasswrod_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EPasswrod_textBox.Name = "EPasswrod_textBox";
            this.EPasswrod_textBox.PasswordChar = '*';
            this.EPasswrod_textBox.Size = new System.Drawing.Size(273, 20);
            this.EPasswrod_textBox.TabIndex = 34;
            this.EPasswrod_textBox.TextChanged += new System.EventHandler(this.EPasswrod_textBox_TextChanged);
            // 
            // EPassword
            // 
            this.EPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EPassword.AutoSize = true;
            this.EPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.EPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPassword.Location = new System.Drawing.Point(180, 294);
            this.EPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EPassword.Name = "EPassword";
            this.EPassword.Size = new System.Drawing.Size(70, 17);
            this.EPassword.TabIndex = 33;
            this.EPassword.Text = "Password:";
            // 
            // Ename_textBox
            // 
            this.Ename_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ename_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ename_textBox.Location = new System.Drawing.Point(267, 229);
            this.Ename_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ename_textBox.Name = "Ename_textBox";
            this.Ename_textBox.Size = new System.Drawing.Size(273, 20);
            this.Ename_textBox.TabIndex = 32;
            // 
            // EmployeeName_label
            // 
            this.EmployeeName_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeName_label.AutoSize = true;
            this.EmployeeName_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeeName_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName_label.Location = new System.Drawing.Point(205, 234);
            this.EmployeeName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeName_label.Name = "EmployeeName_label";
            this.EmployeeName_label.Size = new System.Drawing.Size(45, 15);
            this.EmployeeName_label.TabIndex = 31;
            this.EmployeeName_label.Text = "Name:";
            // 
            // SelectRole
            // 
            this.SelectRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectRole.AutoSize = true;
            this.SelectRole.BackColor = System.Drawing.SystemColors.Control;
            this.SelectRole.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectRole.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRole.Location = new System.Drawing.Point(168, 196);
            this.SelectRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectRole.Name = "SelectRole";
            this.SelectRole.Size = new System.Drawing.Size(83, 17);
            this.SelectRole.TabIndex = 30;
            this.SelectRole.Text = "Select Role: ";
            // 
            // EUserName_textBox
            // 
            this.EUserName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EUserName_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EUserName_textBox.Location = new System.Drawing.Point(267, 259);
            this.EUserName_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EUserName_textBox.Name = "EUserName_textBox";
            this.EUserName_textBox.Size = new System.Drawing.Size(273, 20);
            this.EUserName_textBox.TabIndex = 40;
            // 
            // UserName_label
            // 
            this.UserName_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName_label.AutoSize = true;
            this.UserName_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserName_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_label.Location = new System.Drawing.Point(175, 264);
            this.UserName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(75, 15);
            this.UserName_label.TabIndex = 39;
            this.UserName_label.Text = "User Name:";
            // 
            // Email_textBox
            // 
            this.Email_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_textBox.Location = new System.Drawing.Point(267, 350);
            this.Email_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(273, 20);
            this.Email_textBox.TabIndex = 42;
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.AutoSize = true;
            this.Email.Cursor = System.Windows.Forms.Cursors.Default;
            this.Email.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(209, 355);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 15);
            this.Email.TabIndex = 41;
            this.Email.Text = "Email:";
            // 
            // Deparment_label
            // 
            this.Deparment_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Deparment_label.AutoSize = true;
            this.Deparment_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Deparment_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deparment_label.Location = new System.Drawing.Point(168, 386);
            this.Deparment_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Deparment_label.Name = "Deparment_label";
            this.Deparment_label.Size = new System.Drawing.Size(82, 15);
            this.Deparment_label.TabIndex = 43;
            this.Deparment_label.Text = "Department:";
            // 
            // PhoneNumber_label
            // 
            this.PhoneNumber_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumber_label.AutoSize = true;
            this.PhoneNumber_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.PhoneNumber_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_label.Location = new System.Drawing.Point(149, 418);
            this.PhoneNumber_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumber_label.Name = "PhoneNumber_label";
            this.PhoneNumber_label.Size = new System.Drawing.Size(101, 15);
            this.PhoneNumber_label.TabIndex = 45;
            this.PhoneNumber_label.Text = "Phone Number:";
            this.PhoneNumber_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // Address_textBox
            // 
            this.Address_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address_textBox.Location = new System.Drawing.Point(267, 448);
            this.Address_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(273, 20);
            this.Address_textBox.TabIndex = 48;
            // 
            // Address_label
            // 
            this.Address_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_label.AutoSize = true;
            this.Address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Address_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_label.Location = new System.Drawing.Point(191, 454);
            this.Address_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(59, 15);
            this.Address_label.TabIndex = 47;
            this.Address_label.Text = "Address:";
            // 
            // Login_linkLabel
            // 
            this.Login_linkLabel.AutoSize = true;
            this.Login_linkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_linkLabel.Location = new System.Drawing.Point(264, 592);
            this.Login_linkLabel.Name = "Login_linkLabel";
            this.Login_linkLabel.Size = new System.Drawing.Size(46, 16);
            this.Login_linkLabel.TabIndex = 50;
            this.Login_linkLabel.TabStop = true;
            this.Login_linkLabel.Text = "Login";
            this.Login_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_linkLabel_LinkClicked);
            // 
            // Notic
            // 
            this.Notic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Notic.AutoSize = true;
            this.Notic.Cursor = System.Windows.Forms.Cursors.Default;
            this.Notic.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notic.Location = new System.Drawing.Point(264, 575);
            this.Notic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Notic.Name = "Notic";
            this.Notic.Size = new System.Drawing.Size(171, 17);
            this.Notic.TabIndex = 49;
            this.Notic.Text = "Already Have an Account !";
            // 
            // Department_comboBox
            // 
            this.Department_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Department_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Department_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Department_comboBox.FormattingEnabled = true;
            this.Department_comboBox.Items.AddRange(new object[] {
            "Accounts",
            "Technical"});
            this.Department_comboBox.Location = new System.Drawing.Point(268, 384);
            this.Department_comboBox.Name = "Department_comboBox";
            this.Department_comboBox.Size = new System.Drawing.Size(273, 21);
            this.Department_comboBox.TabIndex = 51;
            // 
            // PhoneNumber_textBox
            // 
            this.PhoneNumber_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumber_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumber_textBox.Location = new System.Drawing.Point(267, 416);
            this.PhoneNumber_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PhoneNumber_textBox.Name = "PhoneNumber_textBox";
            this.PhoneNumber_textBox.Size = new System.Drawing.Size(273, 20);
            this.PhoneNumber_textBox.TabIndex = 46;
            this.PhoneNumber_textBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IssueMAnagementSystemV1._0.Properties.Resources.MicrosoftTeams_image__14_;
            this.pictureBox1.Location = new System.Drawing.Point(230, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // ConfirmePass_textBox
            // 
            this.ConfirmePass_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmePass_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmePass_textBox.Location = new System.Drawing.Point(267, 321);
            this.ConfirmePass_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConfirmePass_textBox.Name = "ConfirmePass_textBox";
            this.ConfirmePass_textBox.PasswordChar = '*';
            this.ConfirmePass_textBox.Size = new System.Drawing.Size(273, 20);
            this.ConfirmePass_textBox.TabIndex = 54;
            // 
            // Confirmpass_label
            // 
            this.Confirmpass_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirmpass_label.AutoSize = true;
            this.Confirmpass_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Confirmpass_label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmpass_label.Location = new System.Drawing.Point(127, 321);
            this.Confirmpass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Confirmpass_label.Name = "Confirmpass_label";
            this.Confirmpass_label.Size = new System.Drawing.Size(124, 17);
            this.Confirmpass_label.TabIndex = 53;
            this.Confirmpass_label.Text = "Confirm Password:";
            // 
            // AgreeCheck_checkBox
            // 
            this.AgreeCheck_checkBox.AutoSize = true;
            this.AgreeCheck_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgreeCheck_checkBox.Location = new System.Drawing.Point(251, 486);
            this.AgreeCheck_checkBox.Name = "AgreeCheck_checkBox";
            this.AgreeCheck_checkBox.Size = new System.Drawing.Size(259, 20);
            this.AgreeCheck_checkBox.TabIndex = 55;
            this.AgreeCheck_checkBox.Text = "I agree with all the Terms and Condition";
            this.AgreeCheck_checkBox.UseVisualStyleBackColor = true;
            this.AgreeCheck_checkBox.CheckedChanged += new System.EventHandler(this.AgreeCheck_checkBox_CheckedChanged);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 632);
            this.Controls.Add(this.AgreeCheck_checkBox);
            this.Controls.Add(this.ConfirmePass_textBox);
            this.Controls.Add(this.Confirmpass_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Department_comboBox);
            this.Controls.Add(this.Login_linkLabel);
            this.Controls.Add(this.Notic);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.PhoneNumber_textBox);
            this.Controls.Add(this.PhoneNumber_label);
            this.Controls.Add(this.Deparment_label);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EUserName_textBox);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.SelectRole_comboBox);
            this.Controls.Add(this.CreaeAccount_button);
            this.Controls.Add(this.EPasswrod_textBox);
            this.Controls.Add(this.EPassword);
            this.Controls.Add(this.Ename_textBox);
            this.Controls.Add(this.EmployeeName_label);
            this.Controls.Add(this.SelectRole);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAccount_FormClosing);
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.ComboBox SelectRole_comboBox;
        private System.Windows.Forms.Button CreaeAccount_button;
        private System.Windows.Forms.TextBox EPasswrod_textBox;
        private System.Windows.Forms.Label EPassword;
        private System.Windows.Forms.TextBox Ename_textBox;
        private System.Windows.Forms.Label EmployeeName_label;
        private System.Windows.Forms.Label SelectRole;
        private System.Windows.Forms.TextBox EUserName_textBox;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Deparment_label;
        private System.Windows.Forms.Label PhoneNumber_label;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.LinkLabel Login_linkLabel;
        private System.Windows.Forms.Label Notic;
        private System.Windows.Forms.ComboBox Department_comboBox;
        private System.Windows.Forms.TextBox PhoneNumber_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ConfirmePass_textBox;
        private System.Windows.Forms.Label Confirmpass_label;
        private System.Windows.Forms.CheckBox AgreeCheck_checkBox;
    }
}