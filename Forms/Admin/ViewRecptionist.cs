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
    public partial class ViewRecptionist : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ViewRecptionist()
        {
            InitializeComponent();
            dataAccess.GetAllReceptionist(dgvRecptionist);
            btnReceptionistDelete.Enabled = false;
            btnReceptionistUpdate.Enabled = false;
            panelRecptionistViewData.Visible = false;
        }

        private void dgvRecptionist_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtReceptionistUserId.Enabled = false;
            txtRecetionistJoinDate.Enabled = false;
            btnReceptionistDelete.Enabled = true;
            btnReceptionistUpdate.Enabled = true;
            panelRecptionistViewData.Visible = true;
            var userId = dgvRecptionist.SelectedRows[0].Cells[0].Value.ToString();
            var firstName = dgvRecptionist.SelectedRows[0].Cells[1].Value.ToString();
            var lastName = dgvRecptionist.SelectedRows[0].Cells[2].Value.ToString();
            string gender = dgvRecptionist.SelectedRows[0].Cells[3].Value.ToString();
            var email = dgvRecptionist.SelectedRows[0].Cells[4].Value.ToString();
            var phoneNumber = dgvRecptionist.SelectedRows[0].Cells[5].Value.ToString();
            var dutyTime = dgvRecptionist.SelectedRows[0].Cells[6].Value.ToString();
            var salary = dgvRecptionist.SelectedRows[0].Cells[7].Value.ToString();
            var joinDate = dgvRecptionist.SelectedRows[0].Cells[8].Value.ToString();
            txtReceptionistUserId.Text = userId;
            txtReceptionistFirstName.Text = firstName;
            txtReceptionistLastName.Text = lastName;
            if (gender.Trim() == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtReceptionistEmail.Text = email;
            txtReceptionistPhoneNumber.Text = phoneNumber;
            cbReceptionistDutyTime.SelectedItem = dutyTime;
            cbReceptionistSalary.SelectedItem = salary;
            txtRecetionistJoinDate.Text = joinDate;
        }

        private void btnReceptionistUpdate_Click(object sender, EventArgs e)
        {
            var userId = txtReceptionistUserId.Text;
            var firstName = txtReceptionistFirstName.Text;
            var lastName = txtReceptionistLastName.Text;
            string gender = (rbMale.Checked) ? "Male" : "Female";
            var email = txtReceptionistEmail.Text;
            var phoneNumber = txtReceptionistPhoneNumber.Text;
            var dutyTime = cbReceptionistDutyTime.SelectedItem;
            var salary = cbReceptionistSalary.SelectedItem;

            bool isUpdate = dataAccess.UpdateUser(userId, firstName, lastName, gender, email, phoneNumber);
            bool isReceptionistUpdate = dataAccess.UpdateReceptionist(userId, dutyTime.ToString(), salary.ToString());
            if (isUpdate && isReceptionistUpdate)
            {
                MessageBox.Show("Update Succesfully");

                dataAccess.GetAllReceptionist(dgvRecptionist);

                panelRecptionistViewData.Visible = false;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnReceptionistDelete_Click(object sender, EventArgs e)
        {
            bool isDeleteLogin = dataAccess.DeleteLogin(txtReceptionistUserId.Text);
            bool isDeleteUser = dataAccess.DeleteUser(txtReceptionistUserId.Text);
            bool isDeleteReceptionist = dataAccess.DeleteReceptionist(txtReceptionistUserId.Text);
            if (isDeleteLogin && isDeleteUser && isDeleteReceptionist)
            {
                MessageBox.Show("User Update Succesfully");
                dataAccess.GetAllReceptionist(dgvRecptionist);
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
