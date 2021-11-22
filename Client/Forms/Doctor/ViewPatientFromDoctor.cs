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
    public partial class ViewPatientFromDoctor : Form
    {
        DataAccess dataAccess = new DataAccess();
        Users user;
        public ViewPatientFromDoctor(Users user)
        {
            InitializeComponent();
            this.user = user;
            ViewData();
        }
        private void ViewData()
        {
            dataAccess.GetPatientByDoctorId(dgvDoctorsPatient, user.UserId);
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dgvDoctorsPatient.Columns.Add(btn);
            //btn.HeaderText = "Action";
            //btn.Text = "Add Prescription";
            //btn.Name = "btnPrescription";
            //btn.UseColumnTextForButtonValue = true;
            
        }

        private void dgvDoctorsPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            //if (e.ColumnIndex == dgvDoctorsPatient.Columns["Action"].Index)
            //{
            //    int rowIndex = e.RowIndex;
            //    var patientId = dgvDoctorsPatient.Rows[rowIndex].Cells[1].Value.ToString();
            //    MessageBox.Show(patientId);
            //}
        }

        private void dgvDoctorsPatient_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtAge.Enabled = false;
            txtName.Enabled = false;
            txtAppointmentId.Enabled = false;
            txtAppointmentDate.Enabled = false;
            groupBox1.Enabled = false;
            var patientId = dgvDoctorsPatient.SelectedRows[0].Cells[0].Value.ToString();
            var name = dgvDoctorsPatient.SelectedRows[0].Cells[1].Value.ToString();
            var age = dgvDoctorsPatient.SelectedRows[0].Cells[2].Value.ToString();
            var gender = dgvDoctorsPatient.SelectedRows[0].Cells[3].Value.ToString();
            var date = dgvDoctorsPatient.SelectedRows[0].Cells[5].Value.ToString();

            txtAppointmentId.Text = patientId;
            txtName.Text = name;
            txtAge.Text = age;
            if (gender.Trim() == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtAppointmentDate.Text = date;

            bool isPreviousPrescription = dataAccess.IsPrescriptionByPatient(Int32.Parse(patientId));
            if (isPreviousPrescription)
            {
                btnPreviousPrescription.Enabled = true;
            }
            else
            {
                btnPreviousPrescription.Enabled = false;
            }
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            string gender = (rbMale.Checked) ? "Male" : "Female";
            Patient patient = new Patient(txtAppointmentId.Text, txtName.Text, Int32.Parse(txtAge.Text), gender,txtAppointmentDate.Text); ;
            Prescription prescription = new Prescription(patient);
            prescription.Show();
        }

        private void btnPreviousPrescription_Click(object sender, EventArgs e)
        {
            string gender = (rbMale.Checked) ? "Male" : "Female";
            Patient patient = new Patient(txtAppointmentId.Text, txtName.Text, Int32.Parse(txtAge.Text), gender, txtAppointmentDate.Text); ;
            PatientPrescription patientPrescription = new PatientPrescription(patient);
            patientPrescription.Show(); 
        } 
    }
}
