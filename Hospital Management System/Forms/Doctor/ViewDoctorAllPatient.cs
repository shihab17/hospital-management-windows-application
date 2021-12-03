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
    public partial class ViewDoctorAllPatient : Form
    {
        DataAccess dataAccess = new DataAccess();
        Users user;
        public ViewDoctorAllPatient(Users user)
        {
            InitializeComponent();
            this.user = user;
            ViewData();
        }

        private void ViewData()
        {
            dataAccess.patients.GetAllPatientByDoctorId(dgvAllPrient, user.UserId);
        }
    }
}
