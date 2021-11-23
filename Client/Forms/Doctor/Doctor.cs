using Hospital_Management_System.Client.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Doctor
{
    public partial class Doctor : Form
    {
        Form previousForm;
        Users user;
        public Doctor(Form previousForm, Users user)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.user = user;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();
            login.Show();
            this.Hide();
        }
        private Form activeFrom = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelDoctorMain.Controls.Add(childForm);
            panelDoctorMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewPatientFromDoctor(user));
        }

        private void btnDoctorProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoctorProfile(user.UserId));
        }

        private void btnViewAllPatient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDoctorAllPatient(user));
        }
    }
}
