using System;

namespace ClassLibrary
{
    public class clsAppointments
    {
        //private data member for the appointment number property
        private Int32 mAppointmentNumber;
        //private data member for the doctor ID property
        private Int32 mDoctorID;
        //private data member for the patient first name property
        private string mPatientFirstName;
        //private data member for the patient last name property
        private string mPatientLastName;
        //private data member for the date of appointment property
        private DateTime mDateOfAppointment;
        //private data member for the time of appointment property
        private DateTime mTimeOfAppointment;
        //private data member for the floor number property
        private Int32 mFloorNumber;
        //private data member for the room number property
        private Int32 mRoomNumber;
        //private data member for the emergency appointment property
        private bool mEmergencyAppointment;
        //private data member for the notes property
        private string mNotes;
        //AppointmentNumber public property
        public int AppointmentNumber { 
            get
            {
                //sends data out of the property
                return mAppointmentNumber;
            }
            set
            {
                //allows data into the property
                mAppointmentNumber = value;
            }
        }
        public int DoctorID {
            get
            {
                //sends data out of the property
                return mDoctorID;
            }
            set
            {
                //allows data into the property
                mDoctorID = value;
            }
        }
        public string PatientFirstName 
        {
            get
            {
                //sends data out of the property
                return mPatientFirstName;
            }
            set
            {
                //allows data into the property
                mPatientFirstName = value;
            }
        }
        public string PatientLastName
        {
            get
            {
                //sends data out of the property
                return mPatientFirstName;
            }
            set
            {
                //allows data into the property
                mPatientFirstName = value;
            }
        }
        //public property for the date of appointment
        public DateTime DateOfAppointment {
            get
            {
                //sends data out of the property
                return mDateOfAppointment;
            }
            set
            {
                //allows data into the property
                mDateOfAppointment = value;
            }
        }
        public DateTime TimeOfAppointment
        {
            get
            {
                //sends data out of the property
                return mTimeOfAppointment;
            }
            set
            {
                //allows data into the property
                mTimeOfAppointment = value;
            }
        }
        public int FloorNumber
        {
            get
            {
                //sends data out of the property
                return mFloorNumber;
            }
            set
            {
                //allows data into the property
                mFloorNumber = value;
            }
        }
        public int RoomNumber
        {
            get
            {
                //sends data out of the property
                return mRoomNumber;
            }
            set
            {
                //allows data into the property
                mRoomNumber = value;
            }
        }
        public bool EmergencyAppointment
        {
            get
            {
                //sends data out of the property
                return mEmergencyAppointment;
            }
            set
            {
                //allows data into the property
                mEmergencyAppointment = value;
            }
        }
        public string Notes
        {
            get
            {
                //sends data out of the property
                return mNotes;
            }
            set
            {
                //allows data into the property
                mNotes = value;
            }
        }
        /***********************FIND METHOD***************************/
        public bool Find(int appointmentNumber)
        {
            mAppointmentNumber = 1;
            mDateOfAppointment = Convert.ToDateTime("2020-01-01");
            return true;
        }
    }
}