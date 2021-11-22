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
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            MessageBox.Show("Doctor: "+doctorId);
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
    }
}
