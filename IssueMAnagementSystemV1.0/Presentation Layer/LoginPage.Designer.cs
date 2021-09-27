
namespace IssueMAnagementSystemV1._0.Entity
{
    partial class LoginPage
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
            this.CreateAccount_linkLabel = new System.Windows.Forms.LinkLabel();
            this.Notic = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SelectRole_comboBox = new System.Windows.Forms.ComboBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.Passwrod_textBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserID_textBox = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.Label();
            this.SelectRole = new System.Windows.Forms.Label();
            this.Forgetpass_linkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateAccount_linkLabel
            // 
            this.CreateAccount_linkLabel.AutoSize = true;
            this.CreateAccount_linkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccount_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount_linkLabel.Location = new System.Drawing.Point(226, 385);
            this.CreateAccount_linkLabel.Name = "CreateAccount_linkLabel";
            this.CreateAccount_linkLabel.Size = new System.Drawing.Size(147, 16);
            this.CreateAccount_linkLabel.TabIndex = 31;
            this.CreateAccount_linkLabel.TabStop = true;
            this.CreateAccount_linkLabel.Text = "Create New Account";
            this.CreateAccount_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccount_linkLabel_LinkClicked);
            // 
            // Notic
            // 
            this.Notic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Notic.AutoSize = true;
            this.Notic.Cursor = System.Windows.Forms.Cursors.Default;
            this.Notic.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notic.Location = new System.Drawing.Point(226, 368);
            this.Notic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Notic.Name = "Notic";
            this.Notic.Size = new System.Drawing.Size(135, 17);
            this.Notic.TabIndex = 30;
            this.Notic.Text = "New in the System ! ";
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit_button.Location = new System.Drawing.Point(409, 306);
            this.Exit_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(132, 38);
            this.Exit_button.TabIndex = 28;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
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
            "Employee",
            "Manager"});
            this.SelectRole_comboBox.Location = new System.Drawing.Point(267, 200);
            this.SelectRole_comboBox.Name = "SelectRole_comboBox";
            this.SelectRole_comboBox.Size = new System.Drawing.Size(274, 21);
            this.SelectRole_comboBox.TabIndex = 27;
            this.SelectRole_comboBox.SelectedIndexChanged += new System.EventHandler(this.SelectRole_comboBox_SelectedIndexChanged);
            // 
            // Login_button
            // 
            this.Login_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_button.Location = new System.Drawing.Point(267, 306);
            this.Login_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(132, 38);
            this.Login_button.TabIndex = 26;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Passwrod_textBox
            // 
            this.Passwrod_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Passwrod_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwrod_textBox.Location = new System.Drawing.Point(267, 269);
            this.Passwrod_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Passwrod_textBox.Name = "Passwrod_textBox";
            this.Passwrod_textBox.PasswordChar = '*';
            this.Passwrod_textBox.Size = new System.Drawing.Size(274, 20);
            this.Passwrod_textBox.TabIndex = 25;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.AutoSize = true;
            this.Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.Password.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(177, 269);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 17);
            this.Password.TabIndex = 24;
            this.Password.Text = "Password:";
            // 
            // UserID_textBox
            // 
            this.UserID_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserID_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserID_textBox.Location = new System.Drawing.Point(267, 233);
            this.UserID_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserID_textBox.Name = "UserID_textBox";
            this.UserID_textBox.Size = new System.Drawing.Size(274, 20);
            this.UserID_textBox.TabIndex = 23;
            this.UserID_textBox.TextChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            // 
            // UserID
            // 
            this.UserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserID.AutoSize = true;
            this.UserID.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.Location = new System.Drawing.Point(177, 235);
            this.UserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(53, 15);
            this.UserID.TabIndex = 22;
            this.UserID.Text = "User ID:";
            // 
            // SelectRole
            // 
            this.SelectRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectRole.AutoSize = true;
            this.SelectRole.BackColor = System.Drawing.SystemColors.Control;
            this.SelectRole.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectRole.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRole.Location = new System.Drawing.Point(177, 200);
            this.SelectRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectRole.Name = "SelectRole";
            this.SelectRole.Size = new System.Drawing.Size(83, 17);
            this.SelectRole.TabIndex = 21;
            this.SelectRole.Text = "Select Role: ";
            // 
            // Forgetpass_linkLabel
            // 
            this.Forgetpass_linkLabel.AutoSize = true;
            this.Forgetpass_linkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Forgetpass_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forgetpass_linkLabel.Location = new System.Drawing.Point(465, 385);
            this.Forgetpass_linkLabel.Name = "Forgetpass_linkLabel";
            this.Forgetpass_linkLabel.Size = new System.Drawing.Size(125, 16);
            this.Forgetpass_linkLabel.TabIndex = 54;
            this.Forgetpass_linkLabel.TabStop = true;
            this.Forgetpass_linkLabel.Text = "Forget Password";
            this.Forgetpass_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IssueMAnagementSystemV1._0.Properties.Resources.MicrosoftTeams_image__14_;
            this.pictureBox1.Location = new System.Drawing.Point(230, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 368);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Lost Your Password ! ";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Forgetpass_linkLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CreateAccount_linkLabel);
            this.Controls.Add(this.Notic);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.SelectRole_comboBox);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Passwrod_textBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserID_textBox);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.SelectRole);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel CreateAccount_linkLabel;
        private System.Windows.Forms.Label Notic;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.ComboBox SelectRole_comboBox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox Passwrod_textBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox UserID_textBox;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label SelectRole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Forgetpass_linkLabel;
        private System.Windows.Forms.Label label1;
    }
}