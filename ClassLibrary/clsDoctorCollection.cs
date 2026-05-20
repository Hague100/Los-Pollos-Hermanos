using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsDoctorCollection
    {
        List<clsDoc> mDoctorsList = new List<clsDoc>();
        // private data member for this address
        clsDoc mThisDoctor = new clsDoc();

        public List<clsDoc> doctorList
        {
            get
            {
                return mDoctorsList;
            }
            set
            {
                mDoctorsList = value;
            }
        }
        public int count
        {
            get
            {
                return mDoctorsList.Count;
            }
            set
            {
               
            }
        }
        public clsDoc thisDoctor {

            get
            {
                return mThisDoctor;
            }
            set
            {
                mThisDoctor = value;
            }

        }

        // constructor for the class
        public clsDoctorCollection()
        {
            // variable for the index
            Int32 index = 0;
            // variable to store the record count
            Int32 recourdCount = 0;
            // object for the data connect
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblDoctors_selectAll");
            // get the count of records
            recourdCount = DB.Count;
            // while ther are records to process
            while(index < recourdCount)
            {
                // create a blank doctor
                clsDoc someDoctor = new clsDoc();
                // read in the field for the current record
                someDoctor.dId = Convert.ToInt32(DB.DataTable.Rows[index]["DoctorId"]);
                someDoctor.dFirstName = Convert.ToString(DB.DataTable.Rows[index]["DFirstName"]);
                someDoctor.dLastName = Convert.ToString(DB.DataTable.Rows[index]["DLastName"]);
                someDoctor.dAddress = Convert.ToString(DB.DataTable.Rows[index]["DAddress"]);
                someDoctor.dEmail = Convert.ToString(DB.DataTable.Rows[index]["DEmail"]);
                someDoctor.dPhoneNumber = Convert.ToString(DB.DataTable.Rows[index]["DPhoneNumber"]);
                someDoctor.dAvailability = Convert.ToBoolean(DB.DataTable.Rows[index]["DAvailability"]);
                // add the record to the private data member
                mDoctorsList.Add(someDoctor);
                index++;
            }

            //clsDoc testDoctor = new clsDoc();
            //// set its properties
            //testDoctor.dId = 1;
            //testDoctor.dFirstName = "Niche";
            //testDoctor.dLastName = "cazoi";
            //testDoctor.dAddress = "33 road road";
            //testDoctor.dEmail = "a@d.com";
            //testDoctor.dPhoneNumber = "123456789";
            //testDoctor.dAvailability = true;
            //// assign the test data to the property
            //mDoctorsList.Add(testDoctor);
            //// re-initiate test doctor
            //testDoctor = new clsDoc();
            //// set its properties
            //testDoctor.dId = 2;
            //testDoctor.dFirstName = "sami";
            //testDoctor.dLastName = "laurence";
            //testDoctor.dAddress = "98 brad drive";
            //testDoctor.dEmail = "oik@boik.co.uk";
            //testDoctor.dPhoneNumber = "1011121314";
            //testDoctor.dAvailability = false;
            //// assign the test data to the property
            //mDoctorsList.Add(testDoctor);       
        }

        public int Add()
        {
            // adds a record to the database based on the values of mThisDoctor
            // connect ot the databse
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@DFirstName", mThisDoctor.dFirstName);
            DB.AddParameter("@DLastName", mThisDoctor.dLastName);
            DB.AddParameter("@DAddress", mThisDoctor.dAddress);
            DB.AddParameter("@DEmail", mThisDoctor.dEmail);
            DB.AddParameter("@DPhoneNumber", mThisDoctor.dPhoneNumber);
            DB.AddParameter("@DAvailability", mThisDoctor.dAvailability);
            // execute the query retuning the primary key value
            return DB.Execute("sproc_tblDoctors_Insert");
        }

        public void Update()
        {
            // update an existing reecord based on the values of this doctor
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the new stored procedure
            DB.AddParameter("@DoctorId", mThisDoctor.dId);
            DB.AddParameter("@DFirstName", mThisDoctor.dFirstName);
            DB.AddParameter("@DLastName", mThisDoctor.dLastName);
            DB.AddParameter("@DAddress", mThisDoctor.dAddress);
            DB.AddParameter("@DEmail", mThisDoctor.dEmail);
            DB.AddParameter("@DPhoneNumber", mThisDoctor.dPhoneNumber);
            DB.AddParameter("@DAvailability", mThisDoctor.dAvailability);
            // execute the stored procedure
            DB.Execute("sproc_tblDoctors_Update");
        }
    }
}