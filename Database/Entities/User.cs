using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Client.Entities
{
    public class Users
    {
        public enum UserTypeEnum
        {
            Admin,
            Doctor,
            Nurse,
            Receptionist
        };
        public string UserId { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }

        public Users()
        {
        }

        public Users(string userId, string password, int userType)
        {
            UserId = userId;
            Password = password;
            UserType = userType;
        }
    }
}
