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
    public partial class ViewPatient : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ViewPatient()
        {
            InitializeComponent();
            dataAccess.patients.GetAllPatient(dgvPatient);
            dataAccess.doctors.GetDoctorCombo(cbDoctorName);
            panelBottomViewPatient.Visible = false;
        }

        private void dgvPatient_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panelBottomViewPatient.Visible = true;
            txtPatientId.Enabled = false;
            txtPatientDate.Enabled = false;
            cbDoctorName.Enabled = false;
            string patientId = dgvPatient.SelectedRows[0].Cells[0].Value.ToString();
            string patientName = dgvPatient.SelectedRows[0].Cells[1].Value.ToString();
            string patientAge = dgvPatient.SelectedRows[0].Cells[2].Value.ToString();
            string patientGender = dgvPatient.SelectedRows[0].Cells[3].Value.ToString();
            string doctorName = dgvPatient.SelectedRows[0].Cells[4].Value.ToString();
            string date = dgvPatient.SelectedRows[0].Cells[5].Value.ToString();

            txtPatientId.Text = patientId;
            txtPatientName.Text = patientName;
            txtPatientAge.Text = patientAge;
            txtPatientDate.Text = date;
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

        private void btnPatientUpdate_Click(object sender, EventArgs e)
        {
            int patientId = Int32.Parse(txtPatientId.Text) ;
            string patientName = txtPatientName.Text;
            int patientAge = Int32.Parse(txtPatientAge.Text);
            string gender = (rbMale.Checked) ? "Male" : "Female";
            string doctorName = cbDoctorName.SelectedValue.ToString();
            string date = txtPatientDate.Text;

            bool isPatientUpade = dataAccess.patients.UpdatePatient(patientId,patientName,patientAge,gender,doctorName);
            if (isPatientUpade)
            {
                MessageBox.Show("Patient Update Succesfully");
                dataAccess.patients.GetAllPatient(dgvPatient);
                panelBottomViewPatient.Visible = false;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnPatientDelete_Click(object sender, EventArgs e)
        {
            int patientId = Int32.Parse(txtPatientId.Text);
            bool isDeletePatient = dataAccess.patients.DeletePatient(patientId);
            if (isDeletePatient)
            {
                MessageBox.Show("Delete PAtient Succesfully");
                dataAccess.patients.GetAllPatient(dgvPatient);
                panelBottomViewPatient.Visible = false;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
