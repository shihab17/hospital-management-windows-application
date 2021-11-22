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
        public PatientPrescription(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            dataAccess.GetPrecriptionByPatient(patient.patientId, dgvViewPrescription);
            rtvPrescription.Enabled = false;
            rtvInvestigation.Enabled = false;
        }

        private void dgvViewPrescription_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rtvInvestigation.Text =  dgvViewPrescription.SelectedRows[0].Cells[2].Value.ToString();
            rtvPrescription.Text = dgvViewPrescription.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
