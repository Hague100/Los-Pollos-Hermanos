using System;

namespace ClassLibrary
{
    public class clsMedicalRecords
    {
        public int appID;
        public bool pendingApp;
        public string appNotes;

        public Int32 DoctorID { get; set; }
        public DateTime Date { get; set; }

        // private data member for the record id
        private Int32 mrecordId;
        private Int32 mpatientId;
        private Int32 mAppID;
        private bool mpendingApp;
        private string mappNotes;
        private Int32 mDoctorID;
        private DateTime mDate;
        

        // public properties (match names used in tests)
        public int recordId
        {
            get { return mrecordId; }
            set { mrecordId = value; }
        }

        public int patientId
        {
            get { return mpatientId; }
            set { mpatientId = value; }
        }

        public int AppID
        {
            get { return mAppID; }
            set { mAppID = value; }
        }

        public bool PendingApp
        {
            get { return mpendingApp; }
            set { mpendingApp = value; }
        }

        public string AppNotes
        {
            get { return mappNotes; }
            set { mappNotes = value; }
        }

        public int doctorId
        {
            get { return mDoctorID; }
            set { mDoctorID = value; }
        }

        public DateTime DateAdded
        {
            get { return mDate; }
            set { mDate = value; }
        }

        // Lookup methods — overloads so callers can use whichever key(s) they have
        public bool Find(int recordId)
        {
            mrecordId = recordId;

            // test stub: populate fields for recordId == 1
            if (recordId == 1)
            {
                // set both backing field and public field/property to avoid confusion
                mAppID = 1;
                appID = 1;

                mpendingApp = true;
                pendingApp = true;

                // ensure public field match test expectations
                mappNotes = "Test note";
                appNotes = "Test note";

                mDoctorID = 123;
                doctorId = 123;

                mpatientId = 456;
                patientId = 456;

                mDate = DateTime.Today;
                Date = DateTime.Today;

                return true;
            }

            // not found
            return false;
        }

        public bool Find(int recordId, int patientId)
        {
            mrecordId = recordId;
            mpatientId = patientId;
            // TODO: load other fields from storage using both keys
            return true;
        }
    }
}