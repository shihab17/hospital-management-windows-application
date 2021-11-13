using Hospital_Management_System.Client.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Hospital_Management_System.Database
{
    class DataAccess
    {
        
        public string ConnectionString { get; set; }
        public DataAccess()
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\AIUB\HMS\db\hospital.mdf;Integrated Security=True;Connect Timeout=30";
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
        public (int id, string userId, string password, int userType) LoginAccess(string userId, string password)
        {
            string sql = "select * " +
               " from [dbo].[tblLogin] where userId='" + userId
               + "' and password='" + password + "'";
            SqlCommand command = GetCommand(sql);

            DataTable dt = Execute(command);
            if(dt.Rows.Count > 0)
            {
                var id = dt.Rows[0].Field<int>("Id");
                var user = dt.Rows[0].Field<string>("userId");
                var pass = dt.Rows[0].Field<string>("password");
                var userType = dt.Rows[0].Field<int>("userType");
                return (id,user, pass, userType);
            }
            else
            {
                return (-1, "","",-1);
            }
            
        }

    }
}
