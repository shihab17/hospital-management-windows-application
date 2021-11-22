using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Client.Entities
{
    public class Patient
    {
        public string patientId { get; set; }
        public string patientName { get; set; }
        public int patientAge { get; set; }
        public string patientGender { get; set; }
        public string appointmentDate { get; set; }

        public Patient(string patientId, string patientName, int patientAge, string patientGender, string appointmentDate)
        {
            this.patientId = patientId;
            this.patientName = patientName;
            this.patientAge = patientAge;
            this.patientGender = patientGender;
            this.appointmentDate = appointmentDate;
        }
    }
}
