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
        string doctor;
        public Prescription(Patient patient, string doctor)
        {
            InitializeComponent();
            this.patient = patient;
            this.doctor = doctor;
            GetPatient();
        }
        private void GetPatient()
        {
            labelPatientId.Text = patient.patientId;
            labelPatientName.Text = patient.patientName;
            labelAge.Text = patient.patientAge.ToString();
            labelGender.Text = patient.patientGender;
            labelDate.Text = patient.appointmentDate;
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
            rtbPrescriptionTest.AppendText("\n" +testName + " ");
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var doctorData = dataAccess.doctors.GetDoctorByUserId(doctor);
            var userData = dataAccess.employees.GetEmployeeByUserId(doctor);
            e.Graphics.DrawString("Hospital Management System", new Font("Times New Roman", 30, FontStyle.Bold), Brushes.Black, new Point(Width/6, 10));
            e.Graphics.DrawString(userData.FirstName +" "+ userData.LastName, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(30, 50));
            e.Graphics.DrawString(doctorData.Specialty, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(30, 75));
            e.Graphics.DrawString(userData.Email, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(30, 100));
            e.Graphics.DrawString(userData.PhoneNumber, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(30, 125));
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, 0, 150, Width, 150);
            e.Graphics.DrawString("Patient Id: " + patient.patientId  +" Name: "  + patient.patientName + " (" + patient.patientGender + ") Age: " + patient.patientAge +" Date: " + patient.appointmentDate, new Font("Times New Roman", 20, FontStyle.Italic), Brushes.Black, new Point(30, 153));
            e.Graphics.DrawLine(pen, 0, 185, Width, 185);
            e.Graphics.DrawString(rtbPrescriptionTest.Text, new Font("Times New Roman", 20, FontStyle.Regular), Brushes.Black, new Point(30, 205));
            e.Graphics.DrawLine(pen, (Width / 4) - 5, 185, (Width / 4) - 5, 950);
            e.Graphics.DrawString(rtbPrescription.Text, new Font("Times New Roman", 20, FontStyle.Italic), Brushes.Black, new Point(Width/4, 205));
            e.Graphics.DrawLine(pen, 0, 960, Width, 960);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
