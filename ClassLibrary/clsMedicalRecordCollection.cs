using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsMedicalRecordCollection
    {



        // backing fields
        private List<clsMedicalRecords> mMedicalRecordList = new List<clsMedicalRecords>();
        private clsMedicalRecords mThisMedicalRecord = new clsMedicalRecords()  ;

        public clsMedicalRecordCollection()
        {
            mThisMedicalRecord = new clsMedicalRecords();

            // construction for the class 
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("Testing");

            int recordCount = DB.Count;
            for (int i = 0; i < recordCount; i++)
            {
                var record = new clsMedicalRecords
                {
                    recordId = Convert.ToInt32(DB.DataTable.Rows[i]["recordId"]),
                    patientId = Convert.ToInt32(DB.DataTable.Rows[i]["patientId"]),
                    AppID = Convert.ToInt32(DB.DataTable.Rows[i]["AppID"]),
                    PendingApp = Convert.ToBoolean(DB.DataTable.Rows[i]["PendingApp"]),
                    AppNotes = Convert.ToString(DB.DataTable.Rows[i]["AppNotes"]),
                    doctorId = Convert.ToInt32(DB.DataTable.Rows[i]["doctorId"]),
                    Date = Convert.ToDateTime(DB.DataTable.Rows[i]["Date"])
                };

                mMedicalRecordList.Add(record);
            }
        }

        public List<clsMedicalRecords> MedicalRecordList
        {
            get => mMedicalRecordList;
            set => mMedicalRecordList = value ?? new List<clsMedicalRecords>(); // need to re look into this 
        }

        public int Count
        {
            get => mMedicalRecordList.Count;
            set { /* setter intentionally left blank or can be removed */ }
        }

        public clsMedicalRecords ThisMedicalRecord
        {
            get => mThisMedicalRecord;
            set => mThisMedicalRecord = value;
        }

        public int Add()
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

        public void Delete()
        {
            // deletes the record pointed to by ThisMedicalRecord
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the primary key value of the record to delete
            DB.AddParameter("@recordId", mThisMedicalRecord.recordId);
            // execute the query
            DB.Execute("sproc_tblmedicalRecords_Delete");


        }

        public void Update()
        {
            // update an existing record based on the values of ThisMedicalRecord
            // connect to the database
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