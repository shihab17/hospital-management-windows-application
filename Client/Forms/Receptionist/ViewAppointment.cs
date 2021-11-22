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
    public partial class ViewAppointment : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ViewAppointment()
        {
            InitializeComponent();
            dataAccess.GetAllPatient(dgvAppointment);
        }
    }
}
