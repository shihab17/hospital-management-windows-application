using Hospital_Management_System.Client.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Database
{
    class DataAccess
    {
        
        public string ConnectionString { get; set; }
        public DataAccess()
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\AIUB\HMS\db\hms.mdf;Integrated Security=True;Connect Timeout=30";
        }
        public SqlCommand GetCommand(string sqlQuery)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            return sqlCmd;
        }
        public DataTable Execute(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            DataTable dt = Execute(cmd);
            return dt;
        }
        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection.Open();
            dt.Load(command.ExecuteReader());
            command.Connection.Close();
            return dt;
        }
        public (string userId, string password, int userType) LoginAccess(string userId, string password)
        {
            string sql = "select * " +
               " from [dbo].[tblLogin] where userId='" + userId
               + "' and password='" + password + "'";
            SqlCommand command = GetCommand(sql);

            DataTable dt = Execute(command);
            if(dt.Rows.Count > 0)
            {
                var user = dt.Rows[0].Field<string>("userId");
                var pass = dt.Rows[0].Field<string>("password");
                var userType = dt.Rows[0].Field<int>("userType");
                return (user, pass, userType);
            }
            else
            {
                return ("","",-1);
            }
            
        }
        public bool InsertEmployee(string userId, string password, int userType)
        {
            string sql = string.Format("insert into tblLogin(userId,password,userType)" +
                "Values('{0}', '{1}', '{2}')", userId, password, userType);
            SqlCommand command = GetCommand(sql);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        public bool InsertUser(string userId, string fname, string lname, string gender, string email, string phone, int role)
        {
            string sql = string.Format("insert into tblUser(userId,firstName,lastName,gender,email,phoneNumber,userType)" +
                "Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", userId, fname, lname, gender, email, phone, role);
            SqlCommand command = GetCommand(sql);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertDoctor(string userId, string specialty, string day, string time, int roomNo, int fees, string joinDate)
        {
            string sql = string.Format("insert into tblDoctor(userId,specialty,day,time,roomNo,fees,joinDate)" +
                "Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", userId, specialty, day, time, roomNo, fees, joinDate);
            SqlCommand command = GetCommand(sql);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetAllDoctor(DataGridView dataGridView)
        {
            string query = "Select  tblUser.userId, firstName, lastName, gender, email, phoneNumber, specialty, day, time, roomNo, fees, joinDate FROM tblUser, tblDoctor where tblUser.userId = tblDoctor.userId  ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public bool UpdateUser(string userId, string fname, string lname, string gender, string email, string phone)
        {
            string query = "UPDATE tblUser SET firstName= '" + fname + "', lastName= '" + lname + "', gender= '" + gender + "', email= '" + email + "',phoneNumber= '" + phone + "' WHERE userId ='" + userId + "' ";
            SqlCommand command = GetCommand(query);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateDoctor(string userId, string specialty, string day, string time, int roomNo, int fees)
        {
            string query = "UPDATE tblDoctor SET specialty= '" + specialty + "', day= '" + day + "', time= '" + time + "', roomNo= '" + roomNo + "',fees= '" + fees + "' WHERE userId ='" + userId + "' ";
            SqlCommand command = GetCommand(query);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteUser(string userId)
        {
            string query = "DELETE FROM tblUser  WHERE userId ='" + userId + "' ";
            SqlCommand command = GetCommand(query);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteDoctor(string userId)
        {
            string query = "DELETE FROM tblDoctor  WHERE userId ='" + userId + "' ";
            SqlCommand command = GetCommand(query);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
