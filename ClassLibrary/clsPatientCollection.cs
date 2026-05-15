using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsPatientCollection
    {
        List<clsPatient> mPatientList = new List<clsPatient>();

        public List<clsPatient> patientList
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

        public int count
        {
            get
            {
                return patientList.Count;
            }
            set
            {
                //worry about this later
            }
        }

        public clsPatient thisPatient { get; set; }

        public clsPatientCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the new data connect
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblPatients_SelectAll");
            //get count of records
            RecordCount = DB.Count;
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
                aPatient.pAccessReq = Convert.ToBoolean(DB.DataTable.Rows[Index]["PAccessReq"]);
                aPatient.pMainDocId = Convert.ToInt32(DB.DataTable.Rows[Index]["PMainDocId"]);
                //add the record to the private data member
                mPatientList.Add(aPatient);
                //point at the next record
                Index++;
            }
        }
    }
}