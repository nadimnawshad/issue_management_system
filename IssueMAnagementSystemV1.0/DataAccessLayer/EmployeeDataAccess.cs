using IssueMAnagementSystemV1._0.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IssueMAnagementSystemV1._0.DataAccessLayer
{
    class EmployeeDataAccess : DatabaseConnection
    {
        public bool EmployeeRegister(Employees Euser)
        {
            string sql = "INSERT INTO Employees(Ename,Estatus,Edept,Eaddress,Email,Phone,UserName,Password,ERole,Points) VALUES('" + Euser.Name + "','" + Euser.Estatus + "','" + Euser.Edept + "','" + Euser.Address + "','" + Euser.Email + "','" + Euser.Phone + "','" + Euser.UserName + "','" + Euser.Password + "','" + Euser.ERole + "','" + Euser.Points + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdatePassword(string Id, string username, string pass)
        {
            string sql = "UPDATE Employees SET password = '" + pass + "' WHERE Eid='" + Id + "' AND UserName='" + username + "'";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool UpdatePassword(string Id, string username, string oldpass, string pass)
        {
            string sql = "UPDATE Employees SET password = '" + pass + "' WHERE Eid='" + Id + "' AND password='" + oldpass + "'";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }




        /* private int ExecuteQuery(string sql)
         {
             throw new NotImplementedException();
         }*/

        public string GetEmpStatus(string Id)
        {
            string sql = "SELECT Estatus FROM Employees WHERE Eid=" + Id;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Employees emp = new Employees();
                return emp.Estatus = reader["Estatus"].ToString();
            }
            return null;
        }

        public bool UpdateStatus(string Id)
        {
            string vl = "Valid";
            string sql = "UPDATE Employees SET Estatus = '" + vl + "' WHERE Eid='" + Id + "'";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool LoginValidation(string Position, string Eid, string password)
        {
            string sql = "SELECT * FROM Employees WHERE Eid='" + Eid + "' AND Password='" + password + "' AND ERole='" + Position + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }
        public bool ValidCheckPromoter(string id)
        {

            string sql = "SELECT ERole FROM Employees WHERE Eid='" + id + "'";
            SqlDataReader reader = this.GetData(sql);

            while (reader.Read())
            {
                Employees Ee = new Employees();

                Ee.ERole = (reader["ERole"]).ToString();
                if (Ee.ERole == "Admin     ")
                    return true;
            }
            return false;
        }
        public bool ValidCheckForPromote(string id)
        {

            string sql = "SELECT Points FROM Employees WHERE Eid='" + id + "'";
            SqlDataReader reader = this.GetData(sql);

            while (reader.Read())
            {
                Employees Ee = new Employees();

                Ee.Points = Convert.ToInt32(reader["Points"]);
                if (Ee.Points<100)
                    return false;
            }
            return true;
        }
        public int GetId(string EName, string password)
        {
            string sql = "SELECT Eid FROM Employees WHERE Ename='" + EName + "' AND Password='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Employees emp = new Employees();
                return emp.Eid = (int)reader["Eid"];
            }
            return -1;
        }

        public string GetPass(string Eid)
        {
            string sql = "SELECT Password FROM Employees WHERE Eid='" + Eid + "'" ;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Employees emp = new Employees();
                return emp.Password = reader["Password"].ToString();
            }
            return null;
        }

        public Employees GetAllInfo(string Id)
        {
            string sql = "SELECT * FROM Employees WHERE Eid=" + Id;
            SqlDataReader reader = this.GetData(sql);
            Employees Emp = new Employees();
            while (reader.Read())
            {
                Emp.Name = reader["Ename"].ToString();
                Emp.UserName = reader["UserName"].ToString();
                Emp.Eid = Convert.ToInt32(Id);
                Emp.Email = reader["Email"].ToString();
                Emp.Edept = reader["Edept"].ToString();
                Emp.ERole = reader["ERole"].ToString();
                Emp.Estatus = reader["Estatus"].ToString();
                Emp.Phone = reader["phone"].ToString();
                Emp.Address = reader["Eaddress"].ToString();
                Emp.Points = (int)reader["Points"];


            }
            return Emp;
        }

        /*public int GetPoints(string Eid)
        {
            string sql = "SELECT Points FROM Employees WHERE Eid='" + Eid + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Employees emp = new Employees();
                return emp.Points = (int)reader["Points"];
            }
            return -1;
        }*/

        public bool UpdatePoints(string Id,int points)
        {
           
            string sql = "UPDATE Employees SET Points = '" + points + "' WHERE Eid='" + Id + "'";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool CheckRole(string id)
        {
            if (GetAllInfo(id).ERole == "Employee  ") { return true; }
            else { return false; }
        }

        public bool UpdateEmpInfo(string id, string name, string username, string Email, string Phone, string Address)
        {
            string sql = "UPDATE Employees SET Ename='" + name + "',UserName='" + username + "',Email='" + Email + "',phone='" + Phone + "',Eaddress='" + Address + "' WHERE Eid=" + id;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Employees> GetEmpListById(string id)
        {
            string sql = "SELECT * FROM Employees WHERE Eid LIKE '" + id + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Employees> EmpList = new List<Employees>();
            while (reader.Read())
            {
                Employees Emp = new Employees();
                Emp.Eid = Convert.ToInt32(reader["Eid"]);
                Emp.Name = reader["Ename"].ToString();
                Emp.Estatus = reader["Estatus"].ToString();
                Emp.Edept = (reader["Edept"].ToString());
                Emp.Address = reader["Eaddress"].ToString();
                Emp.Email = reader["Email"].ToString();
                Emp.Phone = reader["phone"].ToString();
                Emp.UserName = reader["UserName"].ToString();
                Emp.Password = "**********"; // reader["Password"].ToString();
                Emp.ERole = reader["ERole"].ToString();
                Emp.Points = (int)reader["Points"];

                EmpList.Add(Emp);

            }
            return EmpList;
        }


        public List<Employees> GetEmpListForAppoint()
        {
            string emp = "Employee  ";
            string sql = "SELECT * FROM Employees WHERE Points > 99 AND ERole='"+ emp+"'";
            SqlDataReader reader = this.GetData(sql);
            List<Employees> EmpList = new List<Employees>();
            while (reader.Read())
            {
                Employees Emp = new Employees();
                Emp.Eid = Convert.ToInt32(reader["Eid"]);
                Emp.Name = reader["Ename"].ToString();
                Emp.Estatus = reader["Estatus"].ToString();
                Emp.Edept = (reader["Edept"].ToString());
                Emp.Address = reader["Eaddress"].ToString();
                Emp.Email = reader["Email"].ToString();
                Emp.Phone = reader["phone"].ToString();
                Emp.UserName = reader["UserName"].ToString();
                Emp.Password = "**********"; // reader["Password"].ToString();
                Emp.ERole = reader["ERole"].ToString();
                Emp.Points = (int)reader["Points"];

                EmpList.Add(Emp);

            }
            return EmpList;
        }

        public bool UpdateRole(string Id)
        {
            String mng = "Manager";
            string sql = "UPDATE Employees SET ERole = '" + mng + "' WHERE Eid='" + Id + "'";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public List<Employees> GetEmpListByName(string Name)
        {
            string sql = "SELECT * FROM Employees WHERE Ename LIKE '" + Name + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Employees> EmpList = new List<Employees>();
            while (reader.Read())
            {
                Employees Emp = new Employees();
                Emp.Eid = Convert.ToInt32(reader["Eid"]);
                Emp.Name = reader["Ename"].ToString();
                Emp.Estatus = reader["Estatus"].ToString();
                Emp.Edept = (reader["Edept"].ToString());
                Emp.Address = reader["Eaddress"].ToString();
                Emp.Email = reader["Email"].ToString();
                Emp.Phone = reader["phone"].ToString();
                Emp.UserName = reader["UserName"].ToString();
                Emp.Password = "**********"; // reader["Password"].ToString();
                Emp.ERole = reader["ERole"].ToString();
                Emp.Points = (int)reader["Points"];

                EmpList.Add(Emp);

            }
            return EmpList;
        }


        public List<Employees> GetAllEmpList()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.GetData(sql);
            List<Employees> EmpList = new List<Employees>();
            while (reader.Read())
            {
                Employees Emp = new Employees();
                Emp.Eid = Convert.ToInt32(reader["Eid"]);
                Emp.Name = reader["Ename"].ToString();
                Emp.Estatus = reader["Estatus"].ToString();
                Emp.Edept = (reader["Edept"].ToString());
                Emp.Address = reader["Eaddress"].ToString();
                Emp.Email = reader["Email"].ToString();
                Emp.Phone = reader["phone"].ToString();
                Emp.UserName = reader["UserName"].ToString();
                Emp.Password = "**********"; // reader["Password"].ToString();
                Emp.ERole = reader["ERole"].ToString();
                Emp.Points = (int)reader["Points"];

                EmpList.Add(Emp);

            }
            return EmpList;
        }
        public bool DeleteEmp(int Id)
        {
            string sql = "DELETE FROM Employees WHERE Eid=" + Id;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        /*public Employees GetUserRole(string Id)
        {

            string sql = "SELECT * FROM Employees WHERE Eid=" + Id;
            SqlDataReader reader = this.GetData(sql);
            Employees Emp = new Employees();
            while (reader.Read())
            {
               
                Emp.ERole = reader["ERole"].ToString();
                


            }
            return Emp;
        }*/


    }
}
