using Hospital_Management_System.Client.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Receptionist
{
    public partial class Receptionist : Form
    {
        Form previousForm;
        Users user;
        public Receptionist(Form previousForm, Users user)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.user = user;
            panelAppoinment.Visible = false;
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ControlSubMenu(panelAppoinment); 
        }
        private void ControlSubMenu(Panel panel)
        {
            if (panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();
            login.Show();
            this.Hide();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewAppointment());
        }
        private Form activeFrom = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnViewAppoinment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewAppointment());
        }

        private void btnDoctorView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewAllDoctor());
        }
    }
}
