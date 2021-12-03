using Database.Tables;
using Hospital_Management_System.Client.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Doctors = Database.Tables.Doctors;
using Users = Database.Tables.Users;

namespace Hospital_Management_System.Database
{
    public class DataAccess
    {
        
        public string ConnectionString { get; set; }
        public Rooms rooms;
        public Doctors doctors;
        public Users users;
        public Employees employees;
        public Patients patients;
        public DataAccess()
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\AIUB\HMS\db\hms.mdf;Integrated Security=True;Connect Timeout=30";
            rooms = new Rooms(ConnectionString);
            doctors = new Doctors(ConnectionString);
            users = new Users(ConnectionString);
            employees = new Employees(ConnectionString);
            patients = new Patients(ConnectionString);
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
 
        public bool InsertReceptionist(string userId, string dutyTime, int salary)
        {
            string sql = string.Format("insert into tblReceptionist(userId, dutyTime, salary, joinDate)" +
               "Values('{0}', '{1}', '{2}', '{3}')", userId, dutyTime, salary, DateTime.Now.ToString("MM/dd/yyyy"));
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

        public bool InsertPrescription(string prescription, string investigation, string patientId)
        {
            string sql = string.Format("insert into tblPrescription(prescription, investigation, patientId)" +
              "Values('{0}', '{1}', '{2}')", prescription, investigation, patientId);
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
        public void GetAllReceptionist(DataGridView dataGridView)
        {
            string query = "Select  tblUser.userId, firstName, lastName, gender, email, phoneNumber, dutyTime, salary, joinDate FROM tblUser, tblReceptionist where tblUser.userId = tblReceptionist.userId  ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public void GetPrecriptionByPatient(string patientId, DataGridView dataGridView)
        {
            string query = "Select * FROM tblPrescription where patientId ='" + patientId + "' ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }

     
        public int GetTotalReceptionist( )
        {
            string query = "Select  * FROM tblReceptionist ";
            SqlCommand command = GetCommand(query);
            DataTable dt = Execute(command);
            return dt.Rows.Count;
        }
     

        public bool IsPrescriptionByPatient(int patientId)
        {
            string query = "Select  * FROM tblPrescription where patientId ='" + patientId + "' ";
            SqlCommand command = GetCommand(query);
            DataTable dt = Execute(command);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

        public bool UpdateReceptionist(string userId, string dutyTime, string salary)
        {
            string query = "UPDATE tblReceptionist SET dutyTime = '" + dutyTime + "', salary = '" + salary + "' WHERE userId ='" + userId + "' ";
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

       
        public bool DeleteReceptionist(string userId)
        {
            string query = "DELETE FROM tblReceptionist  WHERE userId ='" + userId + "' ";
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

        private int ExecuteComand(string sql)
        {
            SqlCommand command = GetCommand(sql);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected;
        }


    }
}
