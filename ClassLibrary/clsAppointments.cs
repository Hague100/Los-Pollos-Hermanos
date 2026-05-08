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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the appointment number to search for
            DB.AddParameter("@AppointmentNumber", appointmentNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_FilterByAppointmentNumber");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mAppointmentNumber = Convert.ToInt32(DB.DataTable.Rows[0]["AppointmentNumber"]);
                mDoctorID = Convert.ToInt32(DB.DataTable.Rows[0]["DoctorID"]);
                mPatientFirstName = Convert.ToString(DB.DataTable.Rows[0]["PatientFirstName"]);
                mPatientLastName = Convert.ToString(DB.DataTable.Rows[0]["PatientLastName"]);
                mDateOfAppointment = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfAppointment"]);
                mTimeOfAppointment = Convert.ToDateTime(DB.DataTable.Rows[0]["TimeOfAppointment"]);
                mFloorNumber = Convert.ToInt32(DB.DataTable.Rows[0]["FloorNumber"]);
                mRoomNumber = Convert.ToInt32(DB.DataTable.Rows[0]["RoomNumber"]);
                mEmergencyAppointment = Convert.ToBoolean(DB.DataTable.Rows[0]["EmergencyAppointment"]);
                mNotes = Convert.ToString(DB.DataTable.Rows[0]["Notes"]);
                //return that everything worked OK
                return true;
             }
             //if no record was found
             else
             {
                 //return false indicating a problem
                 return false;
            }
        }
    }
}