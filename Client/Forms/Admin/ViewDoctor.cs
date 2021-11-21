using Hospital_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Client.Forms.Admin
{
    public partial class ViewDoctor : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ViewDoctor()
        {
            InitializeComponent();
            DoctorView();
        }
        public void DoctorView()
        {
            dataAccess.GetAllDoctor(dgvDoctor);
        }

        private void dgvDoctor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDoctorUserId.Enabled = false;
            txtDoctorJoinDate.Enabled = false;
            var userId = dgvDoctor.SelectedRows[0].Cells[0].Value.ToString();
            var firstName = dgvDoctor.SelectedRows[0].Cells[1].Value.ToString();
            var lastName = dgvDoctor.SelectedRows[0].Cells[2].Value.ToString();
            string gender = dgvDoctor.SelectedRows[0].Cells[3].Value.ToString();
            var email = dgvDoctor.SelectedRows[0].Cells[4].Value.ToString();
            var phoneNumber = dgvDoctor.SelectedRows[0].Cells[5].Value.ToString();
            var speciality= dgvDoctor.SelectedRows[0].Cells[6].Value.ToString();
            string docotorDay = dgvDoctor.SelectedRows[0].Cells[7].Value.ToString();
            var docotorTime = dgvDoctor.SelectedRows[0].Cells[8].Value.ToString();
            var roomNo = dgvDoctor.SelectedRows[0].Cells[9].Value.ToString();
            var fees = dgvDoctor.SelectedRows[0].Cells[10].Value.ToString();
            var JoinDate = dgvDoctor.SelectedRows[0].Cells[11].Value.ToString();

            txtDoctorUserId.Text = userId;
            txtDoctorFirstName.Text = firstName;
            txtDoctorLastName.Text = lastName;
            if(gender.Trim() == "Male")
            {
                rbMale.Checked = true;
            }
            else 
            {
                rbFemale.Checked = true;
            }
            txtDoctorEmail.Text = email;
            txtDoctorPhoneNumber.Text = phoneNumber;
            cbDoctorSpeciality.SelectedItem = speciality;

            string[] days = new string[] { "" };
            days = docotorDay.Split(',');
            foreach(string selectedDay in days)
            {
                for(int i = 0; i< clbDoctorDay.Items.Count; i++)
                {
                    if(clbDoctorDay.GetItemText(clbDoctorDay.Items[i]) == selectedDay)
                    {
                        clbDoctorDay.SetItemChecked(i, true);
                    }
                }
            }

            cbDoctorTime.SelectedItem = docotorTime;
            cbDoctorRoom.SelectedItem = roomNo;
            txtDoctorJoinDate.Text = JoinDate;
            txtDocotorfees.Text = fees;
        }

        private void btnDoctorUpdate_Click(object sender, EventArgs e)
        {
            var userId = txtDoctorUserId.Text;
            var firstName = txtDoctorFirstName.Text;
            var lastName = txtDoctorLastName.Text;
            string gender = (rbMale.Checked) ? "Male" : "Female";
            var email = txtDoctorEmail.Text;
            var phoneNumber = txtDoctorPhoneNumber.Text;
            var speciality = cbDoctorSpeciality.SelectedItem;
            string docotorDay = getItem(clbDoctorDay);
            var docotorTime = cbDoctorTime.SelectedItem;
            var roomNo = Int32.Parse(cbDoctorRoom.SelectedItem.ToString());
            var fees = Int32.Parse(txtDocotorfees.Text);

            bool isUpdate = dataAccess.UpdateUser(userId, firstName, lastName, gender, email, phoneNumber);
            bool isDoctorUpdate = dataAccess.UpdateDoctor(userId, speciality.ToString(), docotorDay, docotorTime.ToString(), roomNo, fees);
            if (isUpdate && isDoctorUpdate)
            {
                MessageBox.Show("User Update Succesfully");
                DoctorView();
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

        private void btnDoctorDelete_Click(object sender, EventArgs e)
        {
            bool isDeleteLogin = dataAccess.DeleteLogin(txtDoctorUserId.Text);
            bool isDeleteUser = dataAccess.DeleteUser(txtDoctorUserId.Text);
            bool isDeleteDoctor = dataAccess.DeleteDoctor(txtDoctorUserId.Text);
            if (isDeleteLogin && isDeleteUser && isDeleteDoctor)
            {
                MessageBox.Show("User Update Succesfully");
                DoctorView();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
