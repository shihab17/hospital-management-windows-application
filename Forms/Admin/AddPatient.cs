using Hospital_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Admin
{
    public partial class AddPatient : Form
    {
        DataAccess dataAccess = new DataAccess();
        DataTable dt = new DataTable();
        public AddPatient()
        {
            InitializeComponent();
            dataAccess.GetDoctorCombo(cbDoctor);
        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            string patientName = txtPatientName.Text;
            int patientAge = Int32.Parse(txtPatientAge.Text);
            string gender = (rbMale.Checked) ? "Male" : "Female";
            string doctorId = cbDoctor.SelectedValue.ToString();
            var date = dtpAppoinment.Value.ToString("MM/dd/yyyy");
            bool isIsertPatient = dataAccess.InsertPatient(patientName, patientAge, gender, doctorId, date);
            if (isIsertPatient)
            {
                MessageBox.Show("Added New Patient");
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
            var users = dataAccess.GetDoctorDay(date);
            string[] doctors = new string[] { "" };
            doctors = users.Split(',');
            cbDoctor.DataSource = dt;
            dt.Columns.Add("userId", typeof(string));
            dt.Columns.Add("doctorName", typeof(string));
            DataRow row = dt.NewRow();
            foreach (string doctor in doctors)
            {
                string doctorName = dataAccess.GetDoctorName(doctor);
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
