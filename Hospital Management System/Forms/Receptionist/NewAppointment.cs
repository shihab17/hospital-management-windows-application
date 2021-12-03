using Hospital_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Receptionist
{
    public partial class NewAppointment : Form
    {
        DataAccess dataAccess = new DataAccess();
        DataTable dt = new DataTable();
        public NewAppointment()
        {
            InitializeComponent();
        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            string name = txtPatientName.Text;
            int age = Int32.Parse(txtPatientAge.Text);
            string gender = (rbMale.Checked) ? "Male" : "Female";
            var doctorId = cbDoctor.SelectedValue.ToString();
            var appointmentDate = dtpAppoinment.Value.ToString("MM/dd/yyyy");
            bool isIsertPatient = dataAccess.patients.InsertPatient(name, age, gender, doctorId, appointmentDate);
            if (isIsertPatient)
            {
                MessageBox.Show("Added New Doctor Appointment");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void dtpAppoinment_ValueChanged(object sender, EventArgs e)
        {
            cbDoctor.DataSource = null;
            cbDoctor.Items.Clear();
            dt.Clear();
            dt.Columns.Clear();
            var date = dtpAppoinment.Value.DayOfWeek.ToString();
            var users = dataAccess.doctors.GetDoctorDay(date);
            string[] doctors = new string[] { "" };
            doctors = users.Split(',');
            cbDoctor.DataSource = dt;
            dt.Columns.Add("userId", typeof(string));
            dt.Columns.Add("doctorName", typeof(string));
            DataRow row = dt.NewRow();
            foreach (string doctor in doctors)
            {
                string doctorName = dataAccess.doctors.GetDoctorName(doctor);
                row = dt.NewRow();
                row["userId"] = doctor;
                row["doctorName"] = doctorName;
                dt.Rows.Add(row);
            }
            cbDoctor.DataSource = dt;
            cbDoctor.DisplayMember = "doctorName";
            cbDoctor.ValueMember = "userId";
        }
    }
}
