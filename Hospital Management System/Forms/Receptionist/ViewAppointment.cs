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
    public partial class ViewAppointment : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ViewAppointment()
        {
            InitializeComponent();
            dataAccess.patients.GetAllPatient(dgvAppointment);
            dataAccess.doctors.GetDoctorCombo(cbDoctorName);
            panelAppointmentData.Visible = false;
        }

        private void dgvAppointment_DoubleClick(object sender, EventArgs e)
        {
            panelAppointmentData.Visible = true;
            txtAppointmentId.Enabled = false;
            txtAppointmentDate.Enabled = false;
            cbDoctorName.Enabled = false;
            string patientId = dgvAppointment.SelectedRows[0].Cells[0].Value.ToString();
            string patientName = dgvAppointment.SelectedRows[0].Cells[1].Value.ToString();
            string patientAge = dgvAppointment.SelectedRows[0].Cells[2].Value.ToString();
            string patientGender = dgvAppointment.SelectedRows[0].Cells[3].Value.ToString();
            string doctorName = dgvAppointment.SelectedRows[0].Cells[4].Value.ToString();
            string date = dgvAppointment.SelectedRows[0].Cells[5].Value.ToString();

            txtAppointmentId.Text = patientId;
            txtName.Text = patientName;
            txtAge.Text = patientAge;
            txtAppointmentDate.Text = date;
            cbDoctorName.SelectedValue = doctorName;
            if (patientGender.Trim() == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
        }

        private void btnAppointmentUpdate_Click(object sender, EventArgs e)
        {
            int patientId = Int32.Parse(txtAppointmentId.Text);
            string patientName = txtName.Text;
            int patientAge = Int32.Parse(txtAge.Text);
            string gender = (rbMale.Checked) ? "Male" : "Female";
            string doctorName = cbDoctorName.SelectedValue.ToString();
            string date = txtAppointmentDate.Text;

            bool isPatientUpade = dataAccess.patients.UpdatePatient(patientId, patientName, patientAge, gender, doctorName);
            if (isPatientUpade)
            {
                MessageBox.Show("Patient Update Succesfully");
                dataAccess.patients.GetAllPatient(dgvAppointment);
                panelAppointmentData.Visible = false;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnAppointmentDelete_Click(object sender, EventArgs e)
        {
            int patientId = Int32.Parse(txtAppointmentId.Text);
            bool isDeletePatient = dataAccess.patients.DeletePatient(patientId);
            if (isDeletePatient)
            {
                MessageBox.Show("Delete PAtient Succesfully");
                dataAccess.patients.GetAllPatient(dgvAppointment);
                panelAppointmentData.Visible = false;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
