using IssueMAnagementSystemV1._0.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueMAnagementSystemV1._0.DataAccessLayer
{
    class ChatDataAccess : DatabaseConnection
    {
        public bool CreateChat(Chats chats)
        {
            string sql = "INSERT INTO Chats(SenderId,SenderName,ReceiverId,ReceiverName,Message,ChatStatus) VALUES('" + chats.SenderId + "','" + chats.SenderName + "','" + chats.ReceiverId + "','" + chats.ReceiverName + "','" + chats.Message + "','" + chats.ChatStatus+ "')"; 
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateChatStatus(string ChatId)
        {
            string Rd = "Read";
            string sql = "UPDATE Chats SET ChatStatus='"+Rd+"' WHERE ChatId=" + ChatId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Chats> GetAllChatInfo(string rId)
        {
            string sql = "SELECT * FROM Chats WHERE  ReceiverId='" + rId + "' OR SenderId='" + rId + "' ORDER BY ChatId DESC";
            SqlDataReader reader = this.GetData(sql);
            List<Chats> ChatList = new List<Chats>();
            while (reader.Read())
            {
                Chats chats = new Chats();
                chats.ChatId = reader["ChatId"].ToString();
                chats.SenderId = reader["SenderId"].ToString();

                chats.SenderName = reader["SenderName"].ToString();
                chats.ReceiverId = reader["ReceiverId"].ToString();
                chats.ReceiverName = reader["ReceiverName"].ToString();
                chats.Message = reader["Message"].ToString();
                chats.ChatStatus = reader["ChatStatus"].ToString();
                ChatList.Add(chats);
            }
            return ChatList;
        }

        public List<Chats> GetUnreadChats(string receiverId)
        {
            string Un = "Unread";
            string sql = "SELECT SenderId,SenderName,Message,ChatId FROM Chats WHERE ChatStatus='" + Un + "'AND ReceiverId=" + receiverId;


            SqlDataReader reader = this.GetData(sql);
            List<Chats> ChatList = new List<Chats>();
            while (reader.Read())
            {
                Chats chats = new Chats();
                chats.SenderId = reader["SenderId"].ToString();
                chats.SenderName = reader["SenderName"].ToString();
                chats.Message = reader["Message"].ToString();
                chats.ChatId = reader["ChatId"].ToString();

                ChatList.Add(chats);
            }
            return ChatList;
        }

        public List<Chats> GetSearchChats(string receiverName)
        {
            string sql = "SELECT SenderId,SenderName FROM Chats WHERE SenderName LIKE %" + receiverName   +"%";


            SqlDataReader reader = this.GetData(sql);
            List<Chats> ChatList = new List<Chats>();
            while (reader.Read())
            {
                Chats chats = new Chats();
                chats.SenderId = reader["SenderId"].ToString();
                chats.SenderName = reader["SenderName"].ToString();
                chats.Message = reader["Message"].ToString();
                chats.ChatId = reader["ChatId"].ToString();

                ChatList.Add(chats);
            }
            return ChatList;
        }
    }
}
