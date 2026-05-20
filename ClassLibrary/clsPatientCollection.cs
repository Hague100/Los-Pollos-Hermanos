using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsPatientCollection
    {
        List<clsPatient> mPatientList = new List<clsPatient>();
        clsPatient mThisPatient = new clsPatient();

        public List<clsPatient> PatientList
        {
            get
            {
                return mPatientList;
            }
            set
            {
                mPatientList = value;
            }
        }

        public int Count
        {
            get
            {
                return PatientList.Count;
            }
            set
            {
                //worry about this later
            }
        }

        public clsPatient ThisPatient 
        { 
            get
            {
                return mThisPatient;
            }
            set
            {
                mThisPatient = value;
            } 
        }
        //constructor
        public clsPatientCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //object for the new data connect
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblPatients_SelectAll");
            //variable to store the record count
            //get count of records
            int RecordCount = DB.Count;
            //While there are records to process
            while (Index < RecordCount)
            {
                //create blank address
                clsPatient aPatient = new clsPatient();
                aPatient.patientId = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientId"]);
                aPatient.pName = Convert.ToString(DB.DataTable.Rows[Index]["PName"]);
                aPatient.pEmail = Convert.ToString(DB.DataTable.Rows[Index]["PEmail"]);
                aPatient.pDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["PDOB"]);
                aPatient.pHomeAdd = Convert.ToString(DB.DataTable.Rows[Index]["PHomeAdd"]);
                aPatient.pAccessReq = DB.DataTable.Rows[Index]["PAccessReq"] != DBNull.Value ?
                    Convert.ToBoolean(DB.DataTable.Rows[Index]["PAccessReq"]): false;
                aPatient.pMainDocId = DB.DataTable.Rows[Index]["PMainDocId"] != DBNull.Value ?
                    Convert.ToInt32(DB.DataTable.Rows[Index]["PMainDocId"]) : (int?)null;
                //add the record to the private data member
                mPatientList.Add(aPatient);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection dB = new clsDataConnection();
            //set the parameters for the stored procedure
            dB.AddParameter("@PName", mThisPatient.pName);
            dB.AddParameter("@PEmail", mThisPatient.pEmail);
            dB.AddParameter("@PDOB", mThisPatient.pDOB);
            dB.AddParameter("@PHomeAdd", mThisPatient.pHomeAdd);
            dB.AddParameter("@PAccessReq",  mThisPatient.pAccessReq);
            dB.AddParameter("@PMainDocId", mThisPatient.pMainDocId != null ?
                (object)mThisPatient.pMainDocId : DBNull.Value);

            return dB.Execute("sproc_tblPatient_Insert");
        }

        public void Update()
        {
            clsDataConnection dB = new clsDataConnection();
            //set the parameters for the stored procedure
            dB.AddParameter("@PatientId", mThisPatient.patientId);
            dB.AddParameter("@PName", mThisPatient.pName);
            dB.AddParameter("@PEmail", mThisPatient.pEmail);
            dB.AddParameter("@PDOB", mThisPatient.pDOB);
            dB.AddParameter("@PHomeAdd", mThisPatient.pHomeAdd);
            dB.AddParameter("@PAccessReq", mThisPatient.pAccessReq);
            dB.AddParameter("@PMainDocId", mThisPatient.pMainDocId != null ?
                (object)mThisPatient.pMainDocId : DBNull.Value);

            dB.Execute("sproc_tblPatient_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisPatient
            //connect to the database
            clsDataConnection dB = new clsDataConnection();
            //set params for the stored procedure
            dB.AddParameter("@PatientId", mThisPatient.patientId);
            //execute the stored procedure
            dB.Execute("sproc_tblPatients_Delete");
        }
    }
}