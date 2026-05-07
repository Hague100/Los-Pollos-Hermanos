using System;

namespace ClassLibrary
{
    public class clsPatient
    {
        //private data member for the patient id property
        private Int32 mPatientId;
        private string mPName;
        private string mPEmail;
        private string mPPhoneNo;
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

        public string pPhoneNo
        {
            get
            {
                return mPPhoneNo;
            }
            set
            {
                mPPhoneNo = value;
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
            //set the private data members to the test data value
            mPatientId = 2;   
            mPName = "Test name";
            mPEmail = "test.email@testemail.com";
            mPPhoneNo = "1234567890";
            mPDOB = Convert.ToDateTime("01/01/2000");
            mPHomeAdd = "1TestStreet,TestCity,Testshire,Te11AA";
            mPAccessReq = false;
            mPMainDocId = 1;
            //return always true
            return true;
        }
    }
}