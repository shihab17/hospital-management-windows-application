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
    public partial class ManageDoctor : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ManageDoctor()
        {
            InitializeComponent();
            int totalSurgeon = dataAccess.doctors.GetTotalDeptByDptName("Surgeon");
            int totalDutyDoctor = dataAccess.doctors.GetTotalDeptByDptName("Duty doctor");
            int totalDentist = dataAccess.doctors.GetTotalDeptByDptName("Dentist");

            labelSurgeon.Text = totalSurgeon.ToString();
            labelDentist.Text = totalDentist.ToString();
            labelDutyDoctor.Text = totalDutyDoctor.ToString();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddDoctor());
            btnAddDoctor.Enabled = false;
        }
        private Form activeFrom = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelManageDoctorMain.Controls.Add(childForm);
            panelManageDoctorMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnViewDoctor_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDoctor());
        }
    }
}
