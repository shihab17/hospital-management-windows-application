using Hospital_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Receptionist
{
    public partial class ViewAllDoctor : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ViewAllDoctor()
        {
            InitializeComponent();
            dataAccess.doctors.GetAllDoctor(dgvDoctor);
        }

        private void dgvDoctor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var userId = dgvDoctor.SelectedRows[0].Cells[0].Value.ToString();
            Doctor.DoctorProfile doctorProfile = new Doctor.DoctorProfile(userId);
            doctorProfile.Show();
        }
    }
}
