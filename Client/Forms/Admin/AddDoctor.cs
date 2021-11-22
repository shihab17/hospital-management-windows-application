using Hospital_Management_System.Client.Entities;
using Hospital_Management_System.Client.RandomSample;
using Hospital_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Admin
{
    public partial class AddDoctor : Form
    {
        DataAccess dataAccess = new DataAccess();
        public AddDoctor()
        {
            InitializeComponent();
            LoadControl();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }
        private void LoadControl()
        {
            panelRight.Visible = false;
            panelUser.Enabled = false;

            btnNext.Enabled = false;

            txtDoctorUserId.Enabled = false;
            txtDoctorPassword.Enabled = false;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            RandomGenerator randomGenerator = new RandomGenerator();
            string randomUser =  randomGenerator.RandomString(5, false);
            string userId = "Doc" + randomUser;
            //string password = randomGenerator.RandomPassword() ;
            string password = "1234";
            txtDoctorUserId.Text = userId;
            txtDoctorPassword.Text = password;
            int role = (int)Users.UserTypeEnum.Doctor;
            bool isInsert = dataAccess.InsertEmployee(userId, password, role);
            if(isInsert == true)
            {
                panelAddEmplyee.Enabled = false;
                panelUser.Enabled = true;
                btnNext.Enabled = true;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string userId, firstName, lastName, gender, email, phoneNumber;
            userId = txtDoctorUserId.Text;
            firstName = txtDocotorFirstName.Text;
            lastName = txtDoctorLastName.Text;
            gender = (rbMale.Checked) ? "Male" : "Female";
            email = txtDoctorEmail.Text;
            phoneNumber = txtDoctorPhoneNumber.Text;
            int userType = (int)Users.UserTypeEnum.Doctor;

            bool isInsertUser = dataAccess.InsertUser(userId,firstName,lastName,gender,email,phoneNumber,userType);
            if (isInsertUser)
            {
                panelRight.Visible = true;
                panelLeft.Enabled = false;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnAddNewDoctor_Click(object sender, EventArgs e)
        {
            string userId = txtDoctorUserId.Text;
            var specialty = cbDoctorSpeciality.SelectedItem;
            string day = getItem(clbDoctorSchedeule);

            var scheduleTime = cbDoctorSchedule.SelectedItem;
            int roomNo = Int32.Parse(cbDoctorRoom.SelectedItem.ToString());
            int fees = Int32.Parse( txtDocotrFees.Text);
            string joinDate = DateTime.Now.ToString("MM/dd/yyyy");

            bool isInsertDoctor = dataAccess.InsertDoctor(userId, specialty.ToString(), day, scheduleTime.ToString(), roomNo, fees, joinDate);
            if (isInsertDoctor)
            {
                MessageBox.Show("Doctor insert Succesfully");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        public string getItem(CheckedListBox cbName)
        {
            string str = "";
            if (cbName.CheckedItems.Count > 0)
            {
                for (int i = 0; i < cbName.CheckedItems.Count; i++)
                {
                    if (str == "")
                    {
                        str = cbName.CheckedItems[i].ToString();
                    }
                    else
                    {
                        str += "," + cbName.CheckedItems[i].ToString();
                    }
                }

            }
            return str;
        }
    }
}
