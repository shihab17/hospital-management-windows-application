using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Tables
{
    public class Users
    {
        public string ConnectionString { get; set; }

        public Users(string connectionString)
        {
            ConnectionString = connectionString;
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
        private int ExecuteComand(string sql)
        {
            SqlCommand command = GetCommand(sql);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected;
        }
        public (string userId, string password, int userType) LoginAccess(string userId, string password)
        {
            string sql = "select * " +
               " from [dbo].[tblLogin] where userId='" + userId
               + "' and password='" + password + "'";
            SqlCommand command = GetCommand(sql);

            DataTable dt = Execute(command);
            if (dt.Rows.Count > 0)
            {
                var user = dt.Rows[0].Field<string>("userId");
                var pass = dt.Rows[0].Field<string>("password");
                var userType = dt.Rows[0].Field<int>("userType");
                return (user, pass, userType);
            }
            else
            {
                return ("", "", -1);
            }

        }
        public bool InsertEmployee(string userId, string password, int userType)
        {
            string sql = string.Format("insert into tblLogin(userId,password,userType)" +
                "Values('{0}', '{1}', '{2}')", userId, password, userType);
            int rowsAffected = ExecuteComand(sql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool UpdateUser(string userId, string fname, string lname, string gender, string email, string phone)
        {
            string query = "UPDATE tblUser SET firstName= '" + fname + "', lastName= '" + lname + "', gender= '" + gender + "', email= '" + email + "',phoneNumber= '" + phone + "' WHERE userId ='" + userId + "' ";
            int rowsAffected = ExecuteComand(query);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteLogin(string userId)
        {
            string query = "DELETE FROM tblLogin  WHERE userId ='" + userId + "' ";
            int rowsAffected = ExecuteComand(query);
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
