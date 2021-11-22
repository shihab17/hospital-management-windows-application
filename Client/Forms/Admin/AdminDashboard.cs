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
    public partial class AdminDashboard : Form
    {
        DataAccess dataAccess = new DataAccess();
        public AdminDashboard()
        {
            InitializeComponent();
            int totalDoctor = dataAccess.GetTotalDoctor();
            int totalPatient = dataAccess.GetTotalPatient();
            int totalEmployee = dataAccess.GetTotalEmployee();
            labelTotalDoctor.Text = totalDoctor.ToString(); 
            labelTotalPatient.Text = totalPatient.ToString();
            labelTotalEmployee.Text = totalEmployee.ToString();
        }
    }
}
