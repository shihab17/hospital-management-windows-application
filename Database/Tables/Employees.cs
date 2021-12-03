using Hospital_Management_System.Client.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Tables
{
    public class Employees
    {
        public string ConnectionString { get; set; }

        public Employees(string connectionString)
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
        public bool InsertUser(string userId, string fname, string lname, string gender, string email, string phone, int role)
        {
            string sql = string.Format("insert into tblUser(userId,firstName,lastName,gender,email,phoneNumber,userType)" +
                "Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", userId, fname, lname, gender, email, phone, role);
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
        public bool DeleteUser(string userId)
        {
            string query = "DELETE FROM tblUser  WHERE userId ='" + userId + "' ";
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
        public Employee GetEmployeeByUserId(string userId)
        {
            string query = "Select * FROM tblUser where userId ='" + userId + "' ";
            SqlCommand command = GetCommand(query);

            DataTable dt = Execute(command);
            if (dt.Rows.Count > 0)
            {
                var empId = dt.Rows[0].Field<string>("userId");
                var fname = dt.Rows[0].Field<string>("firstName");
                var lname = dt.Rows[0].Field<string>("lastName");
                var gender = dt.Rows[0].Field<string>("gender");
                var email = dt.Rows[0].Field<string>("email");
                var phoneNumber = dt.Rows[0].Field<string>("phoneNumber");
                Employee employee = new Employee(empId, fname, lname, gender, email, phoneNumber);
                return employee;
            }
            else
            {
                return null;
            }
        }
        public int GetTotalEmployee()
        {
            string query = "Select  * FROM tblUser ";
            SqlCommand command = GetCommand(query);

            DataTable dt = Execute(command);
            return dt.Rows.Count;
        }
    }
}
