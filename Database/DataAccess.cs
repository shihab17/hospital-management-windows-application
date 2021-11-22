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

        public void GetAllDoctor(DataGridView dataGridView)
        {
            string query = "Select  tblUser.userId, firstName, lastName, gender, email, phoneNumber, specialty, day, time, roomNo, fees, joinDate FROM tblUser, tblDoctor where tblUser.userId = tblDoctor.userId  ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public void GetPatientByDoctorId(DataGridView dataGridView, string doctorId)
        {
            string query = "Select  * FROM tblPatient  where doctorId ='" + doctorId + "' ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
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
        public Doctors GetDoctorByUserId(string userId)
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
                Doctors doctors = new Doctors(doctorId, speciality, scheduleDay, scheduleTime, roomNo, fees, joinDate);
                return doctors;
            }
            else
            {
                return null;
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
        public bool UpdatePatient(int patientId, string name, int age, string doctorName)
        {
            string query = "UPDATE tblPatient SET patientName= '" + name + "', patientAge= '" + age + "', doctorId= '" + doctorName + "' WHERE patientId ='" + patientId + "' ";
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
            for (int i = 0; i< dt.Rows.Count;  i++)
            {
                var user = dt.Rows[i][0].ToString();
                var docotorDays = dt.Rows[i][2].ToString();
                days = docotorDays.Split(',');
                foreach (var day in days)
                {
                    if(day.Trim() == appoinmentDay.Trim())
                    {
                        if(users == "")
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
        private int ExecuteComand(string sql)
        {
            SqlCommand command = GetCommand(sql);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected;
        }


    }
}
