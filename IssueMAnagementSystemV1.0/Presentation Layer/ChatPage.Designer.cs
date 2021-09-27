
namespace IssueMAnagementSystemV1._0.Presentation_Layer
{
    partial class ChatPage
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
            this.Chatbackbutton = new System.Windows.Forms.Button();
            this.UnreadChat_groupBox = new System.Windows.Forms.GroupBox();
            this.UnreadChat_dataGridView = new System.Windows.Forms.DataGridView();
            this.AllChat_dataGridView = new System.Windows.Forms.DataGridView();
            this.Reply_groupBox = new System.Windows.Forms.GroupBox();
            this.Reply_button = new System.Windows.Forms.Button();
            this.ReplyMessage_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Message_label = new System.Windows.Forms.Label();
            this.Form_label = new System.Windows.Forms.Label();
            this.AllChat_button = new System.Windows.Forms.Button();
            this.Unread_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReceiverName_textBox = new System.Windows.Forms.TextBox();
            this.SearchEmp_label = new System.Windows.Forms.Label();
            this.ReciverId_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchdataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Send_button = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.UnreadChat_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnreadChat_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllChat_dataGridView)).BeginInit();
            this.Reply_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Chatbackbutton
            // 
            this.Chatbackbutton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Chatbackbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chatbackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chatbackbutton.Location = new System.Drawing.Point(802, 538);
            this.Chatbackbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Chatbackbutton.Name = "Chatbackbutton";
            this.Chatbackbutton.Size = new System.Drawing.Size(97, 31);
            this.Chatbackbutton.TabIndex = 88;
            this.Chatbackbutton.Text = "Go Back";
            this.Chatbackbutton.UseVisualStyleBackColor = false;
            this.Chatbackbutton.Click += new System.EventHandler(this.Chatbackbutton_Click_1);
            // 
            // UnreadChat_groupBox
            // 
            this.UnreadChat_groupBox.Controls.Add(this.UnreadChat_dataGridView);
            this.UnreadChat_groupBox.Location = new System.Drawing.Point(-1, 6);
            this.UnreadChat_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.UnreadChat_groupBox.Name = "UnreadChat_groupBox";
            this.UnreadChat_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.UnreadChat_groupBox.Size = new System.Drawing.Size(346, 403);
            this.UnreadChat_groupBox.TabIndex = 91;
            this.UnreadChat_groupBox.TabStop = false;
            this.UnreadChat_groupBox.Text = "Chat";
            // 
            // UnreadChat_dataGridView
            // 
            this.UnreadChat_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnreadChat_dataGridView.Location = new System.Drawing.Point(16, 17);
            this.UnreadChat_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.UnreadChat_dataGridView.Name = "UnreadChat_dataGridView";
            this.UnreadChat_dataGridView.RowHeadersWidth = 51;
            this.UnreadChat_dataGridView.RowTemplate.Height = 24;
            this.UnreadChat_dataGridView.Size = new System.Drawing.Size(330, 387);
            this.UnreadChat_dataGridView.TabIndex = 1;
            this.UnreadChat_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnreadChat_dataGridView_CellContentClick);
            // 
            // AllChat_dataGridView
            // 
            this.AllChat_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllChat_dataGridView.Location = new System.Drawing.Point(15, 23);
            this.AllChat_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.AllChat_dataGridView.Name = "AllChat_dataGridView";
            this.AllChat_dataGridView.RowHeadersWidth = 51;
            this.AllChat_dataGridView.RowTemplate.Height = 24;
            this.AllChat_dataGridView.Size = new System.Drawing.Size(330, 421);
            this.AllChat_dataGridView.TabIndex = 2;
            this.AllChat_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllChat_dataGridView_CellContentClick);
            // 
            // Reply_groupBox
            // 
            this.Reply_groupBox.Controls.Add(this.Reply_button);
            this.Reply_groupBox.Controls.Add(this.ReplyMessage_textBox);
            this.Reply_groupBox.Controls.Add(this.label1);
            this.Reply_groupBox.Controls.Add(this.Message_label);
            this.Reply_groupBox.Controls.Add(this.Form_label);
            this.Reply_groupBox.Location = new System.Drawing.Point(351, 23);
            this.Reply_groupBox.Name = "Reply_groupBox";
            this.Reply_groupBox.Size = new System.Drawing.Size(473, 193);
            this.Reply_groupBox.TabIndex = 90;
            this.Reply_groupBox.TabStop = false;
            this.Reply_groupBox.Text = "Reply";
            this.Reply_groupBox.Visible = false;
            // 
            // Reply_button
            // 
            this.Reply_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reply_button.Location = new System.Drawing.Point(368, 161);
            this.Reply_button.Name = "Reply_button";
            this.Reply_button.Size = new System.Drawing.Size(100, 30);
            this.Reply_button.TabIndex = 9;
            this.Reply_button.Text = "Reply";
            this.Reply_button.UseVisualStyleBackColor = true;
            this.Reply_button.Click += new System.EventHandler(this.Reply_button_Click);
            // 
            // ReplyMessage_textBox
            // 
            this.ReplyMessage_textBox.Location = new System.Drawing.Point(123, 95);
            this.ReplyMessage_textBox.Multiline = true;
            this.ReplyMessage_textBox.Name = "ReplyMessage_textBox";
            this.ReplyMessage_textBox.Size = new System.Drawing.Size(257, 51);
            this.ReplyMessage_textBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reply Message:";
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_label.Location = new System.Drawing.Point(34, 47);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(73, 18);
            this.Message_label.TabIndex = 6;
            this.Message_label.Text = "Message:";
            // 
            // Form_label
            // 
            this.Form_label.AutoSize = true;
            this.Form_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_label.Location = new System.Drawing.Point(59, 16);
            this.Form_label.Name = "Form_label";
            this.Form_label.Size = new System.Drawing.Size(48, 18);
            this.Form_label.TabIndex = 5;
            this.Form_label.Text = "From:";
            // 
            // AllChat_button
            // 
            this.AllChat_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllChat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllChat_button.Location = new System.Drawing.Point(15, 461);
            this.AllChat_button.Margin = new System.Windows.Forms.Padding(2);
            this.AllChat_button.Name = "AllChat_button";
            this.AllChat_button.Size = new System.Drawing.Size(164, 38);
            this.AllChat_button.TabIndex = 92;
            this.AllChat_button.Text = "All Chats";
            this.AllChat_button.UseVisualStyleBackColor = true;
            this.AllChat_button.Click += new System.EventHandler(this.AllChat_button_Click);
            // 
            // Unread_button
            // 
            this.Unread_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Unread_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unread_button.Location = new System.Drawing.Point(196, 461);
            this.Unread_button.Margin = new System.Windows.Forms.Padding(2);
            this.Unread_button.Name = "Unread_button";
            this.Unread_button.Size = new System.Drawing.Size(149, 38);
            this.Unread_button.TabIndex = 103;
            this.Unread_button.Text = "Unread Chats";
            this.Unread_button.UseVisualStyleBackColor = true;
            this.Unread_button.Click += new System.EventHandler(this.Unread_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReceiverName_textBox);
            this.groupBox1.Controls.Add(this.SearchEmp_label);
            this.groupBox1.Controls.Add(this.ReciverId_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SearchdataGridView);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Send_button);
            this.groupBox1.Controls.Add(this.Search_textBox);
            this.groupBox1.Controls.Add(this.Message_textBox);
            this.groupBox1.Location = new System.Drawing.Point(351, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 274);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Chatting";
            // 
            // ReceiverName_textBox
            // 
            this.ReceiverName_textBox.Location = new System.Drawing.Point(321, 159);
            this.ReceiverName_textBox.Name = "ReceiverName_textBox";
            this.ReceiverName_textBox.Size = new System.Drawing.Size(157, 20);
            this.ReceiverName_textBox.TabIndex = 114;
            // 
            // SearchEmp_label
            // 
            this.SearchEmp_label.AutoSize = true;
            this.SearchEmp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmp_label.Location = new System.Drawing.Point(6, 26);
            this.SearchEmp_label.Name = "SearchEmp_label";
            this.SearchEmp_label.Size = new System.Drawing.Size(125, 18);
            this.SearchEmp_label.TabIndex = 110;
            this.SearchEmp_label.Text = "Search Employee";
            // 
            // ReciverId_textBox
            // 
            this.ReciverId_textBox.Location = new System.Drawing.Point(133, 159);
            this.ReciverId_textBox.Name = "ReciverId_textBox";
            this.ReciverId_textBox.Size = new System.Drawing.Size(81, 20);
            this.ReciverId_textBox.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 106;
            this.label5.Text = "Receiver Id:  ";
            // 
            // SearchdataGridView
            // 
            this.SearchdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchdataGridView.Location = new System.Drawing.Point(132, 51);
            this.SearchdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SearchdataGridView.Name = "SearchdataGridView";
            this.SearchdataGridView.RowHeadersWidth = 51;
            this.SearchdataGridView.RowTemplate.Height = 24;
            this.SearchdataGridView.Size = new System.Drawing.Size(345, 62);
            this.SearchdataGridView.TabIndex = 105;
            this.SearchdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchdataGridView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 107;
            this.label4.Text = "Message:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 112;
            this.label6.Text = "Receiver Name: ";
            // 
            // Send_button
            // 
            this.Send_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send_button.Location = new System.Drawing.Point(378, 239);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(100, 30);
            this.Send_button.TabIndex = 108;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(132, 26);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(345, 20);
            this.Search_textBox.TabIndex = 111;
            this.Search_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // Message_textBox
            // 
            this.Message_textBox.Location = new System.Drawing.Point(132, 180);
            this.Message_textBox.Multiline = true;
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(346, 53);
            this.Message_textBox.TabIndex = 109;
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 580);
            this.Controls.Add(this.AllChat_dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Unread_button);
            this.Controls.Add(this.AllChat_button);
            this.Controls.Add(this.UnreadChat_groupBox);
            this.Controls.Add(this.Reply_groupBox);
            this.Controls.Add(this.Chatbackbutton);
            this.Name = "ChatPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatPage_FormClosing);
            this.Load += new System.EventHandler(this.ChatPage_Load);
            this.UnreadChat_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnreadChat_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllChat_dataGridView)).EndInit();
            this.Reply_groupBox.ResumeLayout(false);
            this.Reply_groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Chatbackbutton;
        private System.Windows.Forms.GroupBox UnreadChat_groupBox;
        private System.Windows.Forms.DataGridView UnreadChat_dataGridView;
        private System.Windows.Forms.GroupBox Reply_groupBox;
        private System.Windows.Forms.Button Reply_button;
        private System.Windows.Forms.TextBox ReplyMessage_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Message_label;
        private System.Windows.Forms.Label Form_label;
        private System.Windows.Forms.Button AllChat_button;
        private System.Windows.Forms.Button Unread_button;
        private System.Windows.Forms.DataGridView AllChat_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ReceiverName_textBox;
        private System.Windows.Forms.Label SearchEmp_label;
        private System.Windows.Forms.TextBox ReciverId_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView SearchdataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.TextBox Message_textBox;
    }
}