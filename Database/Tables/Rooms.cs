using Database.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database.Tables
{
    public class Rooms
    {
        public string ConnectionString { get; set; }

        public Rooms(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public SqlCommand GetCommand(string sqlQuery)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            return sqlCmd;
        }
        public DataTable Execute(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            DataTable dt = Execute(cmd);
            return dt;
        }
        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection.Open();
            dt.Load(command.ExecuteReader());
            command.Connection.Close();
            return dt;
        }
        private int ExecuteComand(string sql)
        {
            SqlCommand command = GetCommand(sql);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected;
        }

        public void GetAllRooms(DataGridView dataGridView)
        {
            string query = "Select  * FROM tblRooms ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public List<Room> GetRoomByRoomType(string roomTypes)
        {
            string query = "Select  * FROM tblRooms where RoomType ='" + roomTypes + "' ";
            SqlCommand command = GetCommand(query);
            List <Room> data = new List<Room>();
            DataTable dt = Execute(command);
            for (int i = 0; i < dt.Rows.Count ; i++)
            {
                Room room = new Room();
                room.RoomId = dt.Rows[i].Field<int>("RoomId");
                room.RoomType = dt.Rows[i].Field<string>("RoomType");
                room.RoomLevel = dt.Rows[i].Field<int>("RoomLevel");
                data.Add(room);
            }
            return data;
        }
        public bool InsertRoom(Room room)
        {
            string sql = string.Format("insert into tblRooms(RoomType, RoomLevel)" +
                "Values('{0}', '{1}')", room.RoomType, room.RoomLevel);
            int rowsAffected = ExecuteComand(sql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateRoom(Room room)
        {
            string query = "UPDATE tblRooms SET  RoomType= '" + room.RoomType + "', RoomLevel= '" + room.RoomLevel + "' WHERE RoomId ='" + room.RoomId + "' ";
            int rowsAffected = ExecuteComand(query);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteRoom(int roomId)
        {
            string query = "DELETE FROM tblRooms WHERE RoomId ='" + roomId + "' ";
            int rowsAffected = ExecuteComand(query);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
