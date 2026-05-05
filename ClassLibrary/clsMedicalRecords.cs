using System;

namespace ClassLibrary
{
    public class clsMedicalRecords
    {
        public int appID;
        public bool pendingApp;
        public string appNotes;

        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime Date { get; set; }
    }
}