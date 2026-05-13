using System;

namespace ClassLibrary
{
    public class clsPatient
    {
        //private data member for the patient id property
        private Int32 mPatientId;
        private string mPName;
        private string mPEmail;
        private DateTime mPDOB;
        private string mPHomeAdd;
        private bool mPAccessReq;
        private int mPMainDocId;
        //patientId public property
        public Int32 patientId
        {
            get
            {
                //this line of code sends data out of the property
                return mPatientId;
            }
            set
            {
                //this line of code allows data into the property
                mPatientId = value;
            }
        }
        public string pName
        {
            get
            {
                return mPName;
            }
            set
            {
                mPName = value;
            }
        }
        public string pEmail
        {
            get
            {
                return mPEmail;
            }
            set
            {
                mPEmail = value;
            }
        }
        public DateTime pDOB
        {
            get
            {
                return mPDOB;
            }
            set
            {
                mPDOB = value;
            }
        }
        public string pHomeAdd
        {
            get
            {
                return mPHomeAdd;
            }
            set
            {
                mPHomeAdd = value;
            }
        }
        public bool pAccessReq
        {
            get
            {
                return mPAccessReq;
            }
            set
            {
                mPAccessReq = value;
            }
        }
        public int pMainDocId
        {
            get
            {
                return mPMainDocId;
            }
            set
            {
                mPMainDocId = value;
            }
        }

        public bool Find(int patientId)
        {
            //create an instance if the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the param for new patient id to search for
            DB.AddParameter("@PatientId", patientId);
            //execute stored procedure
            DB.Execute("sproc_tblPatient_FilterByPatientId");
            //if one record is found(should be 1 or 0)
            if (DB.Count == 1)
            {
                //coppy the data from the database to the private data members
                mPatientId = Convert.ToInt32(DB.DataTable.Rows[0]["PatientId"]);
                mPName = Convert.ToString(DB.DataTable.Rows[0]["PName"]);
                mPEmail = Convert.ToString(DB.DataTable.Rows[0]["PEmail"]);
                mPDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["PDOB"]);
                mPHomeAdd = Convert.ToString(DB.DataTable.Rows[0]["PHomeAdd"]);
                mPAccessReq = Convert.ToBoolean(DB.DataTable.Rows[0]["PAccessReq"]);
                mPMainDocId = Convert.ToInt32(DB.DataTable.Rows[0]["PMainDocId"]);
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }

        public string Valid(string patientName, string email, string address, DateTime dateOfBirth, int drId)
        {
            //create a string variable to store the error
            String Error = "";
            //if the patientName is blank
            if (patientName.Length == 0)
            {
                //record error
                Error += "The patient name may not be blank : ";
            }
            if(patientName.Length > 100)
            {
                //record error
                Error += "The patient name may not be more than 100 char: ";
            }
            if (email.Length > 255)
            {
                Error += "The email may not be more than 256 char: ";
            }
            //return error message
            return Error;
        }
    }
}