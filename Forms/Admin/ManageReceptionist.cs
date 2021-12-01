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
    public partial class ManageReceptionist : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ManageReceptionist()
        {
            InitializeComponent();
            int totalReceptionist = dataAccess.GetTotalReceptionist();
            labelToatlReceptionist.Text = totalReceptionist.ToString();
        }

        private void ManageReceptionist_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewRecptionist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewReceptionist());
            btnAddNewRecptionist.Enabled = false;
        }
        private Form activeFrom = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelManageReceptionistMain.Controls.Add(childForm);
            panelManageReceptionistMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnViewReceptionist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewRecptionist());
        }
    }
}
