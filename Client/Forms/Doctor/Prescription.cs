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
    public partial class Prescription : Form
    {
        DataAccess dataAccess = new DataAccess();
        Patient patient;
        public Prescription(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            GetPatient();
        }
        private void GetPatient()
        {
            labelPatientId.Text = patient.patientId;
            labelPatientName.Text = patient.patientName;
            labelAge.Text = patient.patientAge.ToString();
            labelGender.Text = patient.patientGender;
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            var medicineName = txtMedecineName.Text;
            var dosages = txtDosages.Text;
            var duration = txtDuration.Text;
            var time = (rbBefore.Checked) ? "Before Food" : "After Food";
            var medicine = "\n" + medicineName + "\n" + dosages + " - (" + time + ") - " + duration + " Days" ;
            rtbPrescription.AppendText(medicine + "\n");
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            var testName = cbTestName.SelectedItem;
            rtbPrescriptionTest.AppendText(testName + ",\n");
        }

        private void btnSavePrescription_Click(object sender, EventArgs e)
        {
            var patientId = patient.patientId;
            var prescription = rtbPrescription.Text;
            var investigation= rtbPrescriptionTest.Text;
            bool isInsertPresction = dataAccess.InsertPrescription(prescription, investigation, patientId);
            if (isInsertPresction)
            {
                MessageBox.Show("Prescription Insert Successfully");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
