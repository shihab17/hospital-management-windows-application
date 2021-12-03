using Hospital_Management_System.Client.Entities;
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
    public class Doctors
    {
        public string ConnectionString { get; set; }

        public Doctors(string connectionString)
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
        public bool InsertDoctor(string userId, string specialty, string day, string time, int roomNo, int fees, string joinDate)
        {
            string sql = string.Format("insert into tblDoctor(userId,specialty,day,time,roomNo,fees,joinDate)" +
                "Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", userId, specialty, day, time, roomNo, fees, joinDate);
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
        public void GetAllDoctor(DataGridView dataGridView)
        {
            string query = "Select  tblUser.userId, firstName, lastName, gender, email, phoneNumber, specialty, day, time, roomNo, fees, joinDate FROM tblUser, tblDoctor where tblUser.userId = tblDoctor.userId  ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public Doctor GetDoctorByUserId(string userId)
        {
            string query = "Select  * FROM tblDoctor where userId ='" + userId + "' ";
            SqlCommand command = GetCommand(query);

            DataTable dt = Execute(command);
            if (dt.Rows.Count > 0)
            {
                var doctorId = dt.Rows[0].Field<string>("userId");
                var speciality = dt.Rows[0].Field<string>("specialty");
                var scheduleDay = dt.Rows[0].Field<string>("day");
                var scheduleTime = dt.Rows[0].Field<string>("time");
                var roomNo = dt.Rows[0].Field<int>("roomNo");
                var fees = dt.Rows[0].Field<int>("fees");
                var joinDate = dt.Rows[0].Field<string>("joinDate");
                Doctor doctor = new Doctor(doctorId, speciality, scheduleDay, scheduleTime, roomNo, fees, joinDate);
                return doctor;
            }
            else
            {
                return null;
            }
        }
        public int GetTotalDoctor()
        {
            string query = "Select  * FROM tblDoctor ";
            SqlCommand command = GetCommand(query);

            DataTable dt = Execute(command);
            return dt.Rows.Count;
        }
        public int GetTotalDeptByDptName(string deptName)
        {
            string query = "Select  * FROM tblDoctor where specialty ='" + deptName + "' ";
            SqlCommand command = GetCommand(query);

            DataTable dt = Execute(command);
            return dt.Rows.Count;
        }
        public bool UpdateDoctor(string userId, string specialty, string day, string time, int roomNo, int fees)
        {
            string query = "UPDATE tblDoctor SET specialty= '" + specialty + "', day= '" + day + "', time= '" + time + "', roomNo= '" + roomNo + "',fees= '" + fees + "' WHERE userId ='" + userId + "' ";
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
        public bool DeleteDoctor(string userId)
        {
            string query = "DELETE FROM tblDoctor  WHERE userId ='" + userId + "' ";
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
        public string GetDoctorName(string userId)
        {
            string query = "Select  userId, firstName, lastName FROM tblUser where userId ='" + userId + "' ";
            SqlCommand command = GetCommand(query);
            DataTable dt = Execute(command);
            if (dt.Rows.Count > 0)
            {
                var firstName = dt.Rows[0].Field<string>("firstName");
                var lastName = dt.Rows[0].Field<string>("lastName");
                var user = firstName + " " + lastName;
                return user;
            }
            else
            {
                return "";
            }
        }
        public void GetDoctorComboByDate(ComboBox comboBox)
        {
            DataRow dr;
            string sql = "select day from tblDoctor";
            SqlCommand command = GetCommand(sql);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new Object[] { 0, "--Select Doctor--" };
            dt.Rows.InsertAt(dr, 0);
            comboBox.ValueMember = "userId";
            comboBox.DisplayMember = "firstName";
            comboBox.DataSource = dt;
        }
        public string GetDoctorDay(string appoinmentDay)
        {
            string sql = "select * from tblDoctor";
            SqlCommand command = GetCommand(sql);
            DataTable dt = Execute(command);

            string[] days = new string[] { "" };
            string users = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var user = dt.Rows[i][0].ToString();
                var docotorDays = dt.Rows[i][2].ToString();
                days = docotorDays.Split(',');
                foreach (var day in days)
                {
                    if (day.Trim() == appoinmentDay.Trim())
                    {
                        if (users == "")
                        {
                            users = user;
                        }
                        else
                        {
                            users += "," + user;
                        }

                    }
                }

            }
            return users;

        }
        public void GetDoctorCombo(ComboBox comboBox)
        {
            DataRow dr;
            string sql = "select * from tblUser";
            SqlCommand command = GetCommand(sql);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new Object[] { 0, "--Select Doctor--" };
            dt.Rows.InsertAt(dr, 0);
            comboBox.ValueMember = "userId";
            comboBox.DisplayMember = "firstName";
            comboBox.DataSource = dt;
        }
        public bool isAvailableRoom(string time, int roomNo)
        {
            string query = "Select * FROM tblDoctor where time ='" + time + "' and roomNo = '"+ roomNo +"' ";
            SqlCommand command = GetCommand(query);
            DataTable dt = Execute(command);
            return dt.Rows.Count > 0;
        }

    }
}
