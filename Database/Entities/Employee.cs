using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Client.Entities
{
    public class Employee
    {
        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Employee(string empId, string firstName, string lastName, string gender, string email, string phoneNumber)
        {
            EmpId = empId;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
