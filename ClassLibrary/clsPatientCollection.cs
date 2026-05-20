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
                return mPatientList.Count;
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
            //object for the new data connect
            clsDataConnection dB = new clsDataConnection();
            //execute stored procedure
            dB.Execute("sproc_tblPatients_SelectAll");
            //populate the array list with the data table
            PopulateArray(dB);
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

        public void ReportByName(string pName)
        {
            //filters the records based on a full or partial name
            clsDataConnection dB = new clsDataConnection();
            dB.AddParameter("@PName", pName);
            dB.Execute("sproc_tblPatients_FilterByName");
            //populate the array list the data table
            PopulateArray(dB);
        }

        void PopulateArray(clsDataConnection dB)
        {
            //variable for the index
            int Index = 0;
            //variable to store the record 
            int RecordCount = dB.Count;
            //While there are records to process
            mPatientList = new List<clsPatient>();
            while (Index < RecordCount)
            {
                //create blank address
                clsPatient aPatient = new clsPatient();
                aPatient.patientId = Convert.ToInt32(dB.DataTable.Rows[Index]["PatientId"]);
                aPatient.pName = Convert.ToString(dB.DataTable.Rows[Index]["PName"]);
                aPatient.pEmail = Convert.ToString(dB.DataTable.Rows[Index]["PEmail"]);
                aPatient.pDOB = Convert.ToDateTime(dB.DataTable.Rows[Index]["PDOB"]);
                aPatient.pHomeAdd = Convert.ToString(dB.DataTable.Rows[Index]["PHomeAdd"]);
                aPatient.pAccessReq = dB.DataTable.Rows[Index]["PAccessReq"] != DBNull.Value ?
                    Convert.ToBoolean(dB.DataTable.Rows[Index]["PAccessReq"]) : false;
                aPatient.pMainDocId = dB.DataTable.Rows[Index]["PMainDocId"] != DBNull.Value ?
                    Convert.ToInt32(dB.DataTable.Rows[Index]["PMainDocId"]) : (int?)null;
                //add the record to the private data member
                mPatientList.Add(aPatient);
                //point at the next record
                Index++;
            }
        }
    }
}