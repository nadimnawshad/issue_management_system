using IssueMAnagementSystemV1._0.DataAccessLayer;
using IssueMAnagementSystemV1._0.Entities;
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
    public partial class ChatPage : Form
    {
        string rId, sId, sName, rName, Msg, chatId;

        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        public ChatPage(string uID)
        {
            InitializeComponent();
            rId = uID;
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            Employees emp = employeeDataAccess.GetAllInfo(rId);
            rName = emp.Name;

            AllChat_dataGridView.Visible = false;
            UnreadChat_dataGridView.Visible = true;
            ChatDataAccess chatDataAccess = new ChatDataAccess();
            UnreadChat_dataGridView.DataSource = chatDataAccess.GetUnreadChats(rId);

        }

        private void ChatPage_Load(object sender, EventArgs e)
        {


        }

        private void Chatbackbutton_Click(object sender, EventArgs e)
        {

        }

        private void ChatPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ChatgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SearchdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecrow = SearchdataGridView.Rows[index];
            ReciverId_textBox.Text = selecrow.Cells[0].Value.ToString();
            ReceiverName_textBox.Text = selecrow.Cells[1].Value.ToString();

        }

        private void Search_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

            }
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            EmployeeDataAccess Eda = new EmployeeDataAccess();
            SearchdataGridView.DataSource = Eda.GetEmpListByName(Search_textBox.Text);
        }


        private void Unread_button_Click(object sender, EventArgs e)
        {
            AllChat_dataGridView.Visible = false;
            UnreadChat_dataGridView.Visible = true;
            ChatDataAccess chatDataAccess = new ChatDataAccess();
            UnreadChat_dataGridView.DataSource = chatDataAccess.GetUnreadChats(rId);
        }


        private void AllChat_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecrow = AllChat_dataGridView.Rows[index];
            ReciverId_textBox.Text = selecrow.Cells[1].Value.ToString();
            ReceiverName_textBox.Text = selecrow.Cells[2].Value.ToString();
        }

        private void AllChat_button_Click(object sender, EventArgs e)
        {
            AllChat_dataGridView.Visible = true;
            UnreadChat_dataGridView.Visible = false;
            ChatDataAccess chatDataAccess = new ChatDataAccess();
            AllChat_dataGridView.DataSource = chatDataAccess.GetAllChatInfo(rId);
        }

        private void SearchdataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            if (ReciverId_textBox.Text == "")
            {
                MessageBox.Show("Reciver Id Can not be empty");
            }
            else if (Message_textBox.Text == "")
            {
                MessageBox.Show("Nothing in message !");
            }
            else
            {
                Chats chats = new Chats();

                chats.SenderId = rId;
                chats.SenderName = rName;
                chats.ReceiverId = ReciverId_textBox.Text;
                chats.ReceiverName = ReceiverName_textBox.Text;
                chats.Message = Message_textBox.Text;
                chats.ChatStatus = "Unread";
                ChatDataAccess Cda = new ChatDataAccess();

                if (Cda.CreateChat(chats))
                {
                    MessageBox.Show("Message sent ");
                    ChatPage Cp = new ChatPage(rId);
                    Cp.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Error in message sending ");
                }
            }
        }

        private void Chat_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UnreadChat_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Reply_button_Click(object sender, EventArgs e)
        {
            Chats chats = new Chats();

            chats.SenderId = rId;
            chats.SenderName = rName;
            chats.ReceiverId = sId;
            chats.ReceiverName = sName;
            chats.Message = ReplyMessage_textBox.Text;
            chats.ChatStatus = "Unread";
            ChatDataAccess Cda = new ChatDataAccess();
            if (Cda.CreateChat(chats))
            {
                MessageBox.Show("Message sent ");
                ChatPage Cp = new ChatPage(rId);
                Cp.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Error in message sending ");
            }
        }

        private void Chatbackbutton_Click_1(object sender, EventArgs e)
        {
            if (employeeDataAccess.CheckRole(rId))
            {
                Dashboard dashboard = new Dashboard(rId);
                dashboard.Management_button.Visible = false;
                dashboard.Show();
                this.Hide();

            }
            else
            {
                Dashboard dashboard = new Dashboard(rId);
                dashboard.Show();
                this.Hide();

            }
        }

        private void UnreadChat_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Reply_groupBox.Visible = true;
            int index = e.RowIndex;
            DataGridViewRow selecrow = UnreadChat_dataGridView.Rows[index];
            chatId = selecrow.Cells[0].Value.ToString();
            sId = selecrow.Cells[1].Value.ToString();

            Msg = selecrow.Cells[5].Value.ToString();
            Message_label.Text ="Message   :  "+ Msg;
            sName = selecrow.Cells[2].Value.ToString();
            Form_label.Text    ="From   :  "+ sName;
            ChatDataAccess chatDataAccess = new ChatDataAccess();
            chatDataAccess.UpdateChatStatus(chatId);
        }


    }
}
