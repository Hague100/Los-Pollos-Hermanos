using System;
using System.Collections.Generic;



namespace ClassLibrary
{
    public class clsMedicalRecordCollection{
        
        // private backing field to avoid recursion
        private List<clsMedicalRecords> medicalRecordList = new List<clsMedicalRecords>();
        // private member for this address 
        clsMedicalRecords mThisMedicalRecord = new clsMedicalRecords();

        public clsMedicalRecordCollection()
        {
            // construction for the class 
            // variable for the index 
            Int32 Index = 0;
            Int32 RecordCount = 0;
            // onject for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("Testing");
            // variable to store the record count
            // get the count of the records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank medical record
                clsMedicalRecords AnMedicalRecord = new clsMedicalRecords();
                // read in the fields from the current record
                AnMedicalRecord.recordId = Convert.ToInt32(DB.DataTable.Rows[Index]["recordId"]);
                AnMedicalRecord.patientId = Convert.ToInt32(DB.DataTable.Rows[Index]["patientId"]);
                AnMedicalRecord.AppID = Convert.ToInt32(DB.DataTable.Rows[Index]["AppID"]);
                AnMedicalRecord.PendingApp = Convert.ToBoolean(DB.DataTable.Rows[Index]["PendingApp"]);
                AnMedicalRecord.AppNotes = Convert.ToString(DB.DataTable.Rows[Index]["AppNotes"]);
                AnMedicalRecord.doctorId = Convert.ToInt32(DB.DataTable.Rows[Index]["doctorId"]);
                AnMedicalRecord.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                medicalRecordList.Add(AnMedicalRecord);
                // point to the next record
                Index++;
            }
        }



        public List<clsMedicalRecords> MedicalRecordList
        {


            get { return medicalRecordList; }

            set { medicalRecordList = value ?? new List<clsMedicalRecords>(); }


        }
        public int Count


        {
            get { return medicalRecordList.Count; }




            set { /* keep for compatibility; consider removing or throwing if not needed */ }

        }

        public clsMedicalRecords ThisMedicalRecord 
        { 
            get
            {
                // return the private data
                return mThisMedicalRecord;
            }
            set
            {
                // set the private data 
                mThisMedicalRecord = value;
            }
        }

        internal int Add()
        {
            // adds the record to the database on the values of mThisMedicalRecord
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the primary key value of the new record
            DB.AddParameter("@patientId", mThisMedicalRecord.patientId);
            DB.AddParameter("@AppID", mThisMedicalRecord.AppID);
            DB.AddParameter("@PendingApp", mThisMedicalRecord.PendingApp);
            DB.AddParameter("@AppNotes", mThisMedicalRecord.AppNotes);
            DB.AddParameter("@doctorId", mThisMedicalRecord.doctorId);
            DB.AddParameter("@Date", mThisMedicalRecord.Date);
            // execute the query returning the primart key valuse
            return DB.Execute("sproc_tblmedicalRecords_Insert");
        }

        internal void Update()
        {
           // update an existing record based on the values of mThisMedicalRecord
            // connect to the db
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@recordId", mThisMedicalRecord.recordId);
            DB.AddParameter("@patientId", mThisMedicalRecord.patientId);
            DB.AddParameter("@AppID", mThisMedicalRecord.AppID);
            DB.AddParameter("@PendingApp", mThisMedicalRecord.PendingApp);
            DB.AddParameter("@AppNotes", mThisMedicalRecord.AppNotes);
            DB.AddParameter("@doctorId", mThisMedicalRecord.doctorId);
            DB.AddParameter("@Date", mThisMedicalRecord.Date);
            // execute the stored procedure
            DB.Execute("sproc_tblmedicalRecords_Update");
        }
    } 
}