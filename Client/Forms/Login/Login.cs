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
            pictureBox1.Image = pictureBox1.InitialImage;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            var (userId,password,isAccess) = dataAccess.LoginAccess(txtUserId.Text, txtPassword.Text);
            if (isAccess>-1)
            {
                Users user = new Users(userId,password,isAccess);
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
                    case (int)Users.UserTypeEnum.Receptionist:
                        Receptionist.Receptionist receptionist = new Receptionist.Receptionist(this,user);
                        receptionist.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login Failled!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserId_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true;
                txtUserId.Focus();
                errorProvider1.SetError(txtUserId, $"Should not be white");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserId, "");

            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, $"Should not be white");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            
        }


    }
}
