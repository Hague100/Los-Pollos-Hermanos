using System;

namespace ClassLibrary
{
    public class clsAppointments
    {
        public int AppointmentNumber { get; set; }
        public int DoctorID { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public DateTime TimeOfAppointment { get; set; }
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }
        public bool EmergencyAppointment { get; set; }
        public string Notes { get; set; }
    }
}