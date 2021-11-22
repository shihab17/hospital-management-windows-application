using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System.Client.Entities
{
    public class Doctors
    {
        public string DoctorId { get; set; }
        public string Specialty { get; set; }
        public string ScheduleDay { get; set; }
        public string ScheduleTime { get; set; }
        public int RoomNo { get; set; }
        public int Fees { get; set; }
        public string JoinDate { get; set; }

        public Doctors(string doctorId, string specialty, string scheduleDay, string scheduleTime, int roomNo, int fees, string joinDate)
        {
            DoctorId = doctorId;
            Specialty = specialty;
            ScheduleDay = scheduleDay;
            ScheduleTime = scheduleTime;
            RoomNo = roomNo;
            Fees = fees;
            JoinDate = joinDate;
        }
    }
}
