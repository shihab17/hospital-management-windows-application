using Hospital_Management_System.Client.Entities;
using Hospital_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            var (id,userId,password,isAccess) = dataAccess.LoginAccess(txtUserId.Text, txtPassword.Text);
            if (isAccess>-1)
            {
                Users user = new Users(id,userId,password,isAccess);
                switch (isAccess)
                {
                    case (int)Users.UserTypeEnum.Admin:
                        Admin.Admin admin = new Admin.Admin(this,user);
                        admin.Show();
                        this.Hide();
                        break;
                    case (int)Users.UserTypeEnum.Doctor:
                        Doctor.Doctor doctor = new Doctor.Doctor(this,user);
                        doctor.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login Failled!");
            }
        }
    }
}
