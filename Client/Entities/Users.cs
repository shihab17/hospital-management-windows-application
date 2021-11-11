using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Client.Entities
{
    class Users
    {
        public enum UserType
        {
            Admin,
            Doctor,
            Nurse
        };
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Users(int id, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
        }
    }
}
