using Database.Entities;
using Hospital_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_Management_System.Forms.Admin
{
    public partial class ManageRoom : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ManageRoom()
        {
            InitializeComponent();
            txtRoomId.Enabled = false;
            btnUpdateRoom.Enabled = false;
            btnDelete.Enabled = false;
            dataAccess.rooms.GetAllRooms(dgvRoom);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomType = cbRoomType.SelectedItem.ToString();
            int level = (int)numericUpDownLevel.Value;
            Room room = new Room();
            room.RoomLevel = level;
            room.RoomType = roomType;
            bool isInsertRoom = dataAccess.rooms.InsertRoom(room); 
            if (isInsertRoom)
            {
                MessageBox.Show("Succefully Intered a new room");
                dataAccess.rooms.GetAllRooms(dgvRoom);
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void dgvRoom_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAddRoom.Enabled = false;
            btnUpdateRoom.Enabled = true;
            btnDelete.Enabled = true;
            txtRoomId.Text = dgvRoom.SelectedRows[0].Cells[0].Value.ToString();
            cbRoomType.SelectedItem = dgvRoom.SelectedRows[0].Cells[1].Value.ToString();
            numericUpDownLevel.Value =Int32.Parse(dgvRoom.SelectedRows[0].Cells[2].Value.ToString());
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            int roomId = Int32.Parse(txtRoomId.Text);
            string roomType = cbRoomType.SelectedItem.ToString();
            int level = (int)numericUpDownLevel.Value;
            Room room = new Room();
            room.RoomId = roomId;
            room.RoomLevel = level;
            room.RoomType = roomType;
            bool isUpdateRoom = dataAccess.rooms.UpdateRoom(room);
            if (isUpdateRoom)
            {
                MessageBox.Show("Succefully Update room");
                dataAccess.rooms.GetAllRooms(dgvRoom);
                txtRoomId.Text = "";
                numericUpDownLevel.Value = 100;
                cbRoomType.SelectedItem = "";
                btnAddRoom.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdateRoom.Enabled = false;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int roomId = Int32.Parse(txtRoomId.Text);
            bool isDeleteRoom = dataAccess.rooms.DeleteRoom(roomId);
            if (isDeleteRoom)
            {
                MessageBox.Show("Succefully Delete room");
                txtRoomId.Text = "";
                numericUpDownLevel.Value = 100;
                cbRoomType.SelectedItem = "";
                btnAddRoom.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdateRoom.Enabled = false;
                dataAccess.rooms.GetAllRooms(dgvRoom);
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
