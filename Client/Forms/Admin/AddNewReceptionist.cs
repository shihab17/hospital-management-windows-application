using Hospital_Management_System.Client.Entities;
using Hospital_Management_System.Client.RandomSample;
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
    public partial class AddNewReceptionist : Form
    {
        DataAccess dataAccess = new DataAccess();
        public AddNewReceptionist()
        {
            InitializeComponent();
            LoadControl();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            RandomGenerator randomGenerator = new RandomGenerator();
            string randomUser = randomGenerator.RandomString(5, false);
            string userId = "rec" + randomUser;
            string password = "1234";
            txtRecetionistUserId.Text = userId;
            txtReceptionistPassword.Text = password;
            int role = (int)Users.UserTypeEnum.Receptionist;
            bool isInsert = dataAccess.InsertEmployee(userId, password, role);
            if (isInsert == true)
            {
                panelEmployeeAdd.Enabled = false;
                panelReceptionist.Enabled = true;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
        private void LoadControl()
        {
            panelReceptionist.Enabled = false;
            panelAddReceptionist.Visible = false;
            txtRecetionistUserId.Enabled = false;
            txtReceptionistPassword.Enabled = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string userId, firstName, lastName, gender, email, phoneNumber;
            userId = txtRecetionistUserId.Text;
            firstName = txtReceptionistFirstName.Text;
            lastName = txtReceptionistLastName.Text;
            gender = (rbMale.Checked) ? "Male" : "Female";
            email = txtReceptionistEmail.Text;
            phoneNumber = txtReceptionistPhoneNumber.Text;
            int userType = (int)Users.UserTypeEnum.Doctor;

            bool isInsertUser = dataAccess.InsertUser(userId, firstName, lastName, gender, email, phoneNumber, userType);
            if (isInsertUser)
            {
                panelAddReceptionist.Visible = true;
                panelReceptionistAddUser.Enabled = false;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnAddReceptionist_Click(object sender, EventArgs e)
        {
            string userId, dutyTime;
            userId = txtRecetionistUserId.Text;
            dutyTime = cbReceptionistSchedule.SelectedItem.ToString();
            int salary = Int32.Parse(cbReceptionistSalary.SelectedItem.ToString());

            bool isReceptionist = dataAccess.InsertReceptionist(userId, dutyTime, salary);
            if (isReceptionist)
            {
                MessageBox.Show("Successfully Add New Receptionist");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
