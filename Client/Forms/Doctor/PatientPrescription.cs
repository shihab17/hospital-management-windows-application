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
    public partial class PatientPrescription : Form
    {
        DataAccess dataAccess = new DataAccess();
        Patient patient;
        string doctor;
        public PatientPrescription(Patient patient, string doctor)
        {
            InitializeComponent();
            this.patient = patient;
            this.doctor = doctor;
            dataAccess.GetPrecriptionByPatient(patient.patientId, dgvViewPrescription);
            rtvPrescription.Enabled = false;
            rtvInvestigation.Enabled = false;
            btnPrint.Visible = false;
        }

        private void dgvViewPrescription_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rtvInvestigation.Text =  dgvViewPrescription.SelectedRows[0].Cells[2].Value.ToString();
            rtvPrescription.Text = dgvViewPrescription.SelectedRows[0].Cells[1].Value.ToString();
            btnPrint.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var doctorData = dataAccess.GetDoctorByUserId(doctor);
            var userData = dataAccess.GetEmployeeByUserId(doctor);
            e.Graphics.DrawString("Hospital Management System", new Font("Times New Roman", 30, FontStyle.Bold), Brushes.Black, new Point(Width / 6, 10));
            e.Graphics.DrawString(userData.FirstName + " " + userData.LastName, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(30, 50));
            e.Graphics.DrawString(doctorData.Specialty, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(30, 75));
            e.Graphics.DrawString(userData.Email, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(30, 100));
            e.Graphics.DrawString(userData.PhoneNumber, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(30, 125));
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, 0, 150, Width, 150);
            e.Graphics.DrawString("Patient Id: " + patient.patientId + " Name: " + patient.patientName + " (" + patient.patientGender + ") Age: " + patient.patientAge + " Date: " + patient.appointmentDate, new Font("Times New Roman", 20, FontStyle.Italic), Brushes.Black, new Point(30, 153));
            e.Graphics.DrawLine(pen, 0, 185, Width, 185);
            e.Graphics.DrawString(rtvInvestigation.Text, new Font("Times New Roman", 20, FontStyle.Regular), Brushes.Black, new Point(30, 205));
            e.Graphics.DrawLine(pen, (Width / 4) - 5, 185, (Width / 4) - 5, 950);
            e.Graphics.DrawString(rtvPrescription.Text, new Font("Times New Roman", 20, FontStyle.Italic), Brushes.Black, new Point(Width / 4, 205));
            e.Graphics.DrawLine(pen, 0, 960, Width, 960);
        }
    }
}
