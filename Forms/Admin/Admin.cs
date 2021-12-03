using Hospital_Management_System.Client.Entities;
using Hospital_Management_System.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Admin
{
    public partial class Admin : Form
    {
        Form previousForm;
        Users user;

        public Admin(Form previousForm, Users user)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.user = user;
            panelEmpoyeSubMenu.Visible = false;
            OpenChildForm(new AdminDashboard());
        }
        private void ControlSubMenu(Panel panel)
        {
            if(panel.Visible == true)
            {
                panel.Visible = false;
            }
            else
            {
                panel.Visible = true;
            }
            
        }

        private void btnEmploye_Click(object sender, EventArgs e)
        {
            ControlSubMenu(panelEmpoyeSubMenu);
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageDoctor());
        }
        private Form activeFrom = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelAdminMain.Controls.Add(childForm);
            panelAdminMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnManagePatient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagePatient());
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageReceptionist());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();
            login.Show();
            this.Hide();
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminDashboard());
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            new OpenChildForm(new ManageRoom(), panelAdminMain);
        }
    }
}
