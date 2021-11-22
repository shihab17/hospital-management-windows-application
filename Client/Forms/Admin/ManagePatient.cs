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
    public partial class ManagePatient : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ManagePatient()
        {
            InitializeComponent();
            int toatlPatient = dataAccess.GetTotalPatient();
            labelTotalPatient.Text = toatlPatient.ToString();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddPatient());
            btnAddPatient.Enabled = false;
        }
        private Form activeFrom = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelManagePatientMain.Controls.Add(childForm);
            panelManagePatientMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewPatient());
        }
    }
}
