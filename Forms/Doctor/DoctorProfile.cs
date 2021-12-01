using Hospital_Management_System.Client.Entities;
using Hospital_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Doctor
{
    public partial class DoctorProfile : Form
    {
        DataAccess dataAccess = new DataAccess();
        string userId;
        public DoctorProfile(string userId)
        {
            InitializeComponent();
            pbDoctor.Image = pbDoctor.InitialImage;
            this.userId = userId;
            ShowData();
        }

        private void ShowData()
        {
           Employee employee = dataAccess.GetEmployeeByUserId(userId);
           Doctors doctors = dataAccess.GetDoctorByUserId(userId);
            labelDoctorName.Text = employee.FirstName + " " + employee.LastName;
            labelSpeciality.Text = doctors.Specialty;
            labelSchedeule.Text = doctors.ScheduleDay + " (" + doctors.ScheduleTime + ")";
            labelJoinDate.Text = doctors.JoinDate;
            labeluserId.Text = doctors.DoctorId;
            labelRoomNumber.Text = doctors.RoomNo.ToString();
            labelFees.Text = doctors.Fees.ToString();

            labelDoctorFullName.Text = employee.FirstName + " " + employee.LastName;
            labelDoctorGender.Text = employee.Gender;
            labelDoctorEmail.Text = employee.Email;
            labelDoctorPhoneNumber.Text = employee.PhoneNumber;
        }
    }
}
