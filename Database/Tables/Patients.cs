using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database.Tables
{
    public class Patients
    {
        public string ConnectionString { get; set; }

        public Patients(string connectionString)
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
        public bool InsertPatient(string name, int age, string gender, string doctorId, string date)
        {
            string sql = string.Format("insert into tblPatient(patientName, patientAge, patientGender, doctorId, scheduleDay)" +
               "Values('{0}', '{1}', '{2}', '{3}', '{4}')", name, age, gender, doctorId, date);
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
        public void GetAllPatient(DataGridView dataGridView)
        {
            string query = "Select  * FROM tblPatient ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public void GetPatientByDoctorId(DataGridView dataGridView, string doctorId, string dateTime)
        {
            string query = "Select  * FROM tblPatient  where doctorId ='" + doctorId + "' and scheduleDay ='" + dateTime + "' ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public void GetAllPatientByDoctorId(DataGridView dataGridView, string doctorId)
        {
            string query = "Select  * FROM tblPatient  where doctorId ='" + doctorId + "' ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public bool UpdatePatient(int patientId, string name, int age, string gender, string doctorName)
        {
            string query = "UPDATE tblPatient SET patientName= '" + name + "', patientAge= '" + age + "', patientGender= '" + gender + "', doctorId= '" + doctorName + "' WHERE patientId ='" + patientId + "' ";
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
        public bool DeletePatient(int id)
        {
            string query = "DELETE FROM tblPatient  WHERE patientId ='" + id + "' ";
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
        public int GetTotalPatient()
        {
            string query = "Select  * FROM tblPatient ";
            SqlCommand command = GetCommand(query);

            DataTable dt = Execute(command);
            return dt.Rows.Count;
        }
    }
}
