using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    //constructor for the class
    public class clsAppointmentsCollection
    {
        //private data member for the list
        List<clsAppointments> mAppointmentsList = new List<clsAppointments>();
        //private member data for thisAppointment
        clsAppointments mThisAppointment = new clsAppointments();
        //public property for the appointment list
        public List<clsAppointments> AppointmentsList
        {
            get
            {
                //return the private data
                return mAppointmentsList;
            }
            set
            {
                //set the private data
                mAppointmentsList = value;
            }
        }
        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mAppointmentsList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }
        //public property for thisAppointment
        public clsAppointments ThisAppointment
        {
            get
            {
                //return the private data
                return mThisAppointment;
            }
            set
            {
                //set the private data
                mThisAppointment = value;
            }
        }
        public clsAppointmentsCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the data
            DB.Execute("sproc_tblAppointments_SelectAll");
            //get the count of records returned
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank appointment
                clsAppointments AnAppointment = new clsAppointments();
                //create a data connection to find the patient id
                clsDataConnection DBPatient = new clsDataConnection();
                //set the parameters for the stored procedure
                DBPatient.AddParameter("@PatientId", Convert.ToString(DB.DataTable.Rows[Index]["PatientID"]));
                //execute the stored procedure to find the patient name
                DBPatient.Execute("sproc_tblAppointments_GetPatientById");
                //read in the fields from the current record
                AnAppointment.AppointmentNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["AppointmentNumber"]);
                AnAppointment.DoctorID = Convert.ToInt32(DB.DataTable.Rows[Index]["DoctorID"]);
                AnAppointment.PatientFirstName = Convert.ToString(DBPatient.DataTable.Rows[0]["PName"]).Split(' ')[0];
                AnAppointment.PatientLastName = Convert.ToString(DBPatient.DataTable.Rows[0]["PName"]).Split(' ')[1];
                AnAppointment.PatientID = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientID"]);
                AnAppointment.DateOfAppointment = Convert.ToDateTime(DB.DataTable.Rows[Index]["AppointmentDate"]);
                AnAppointment.TimeOfAppointment = (TimeSpan)DB.DataTable.Rows[Index]["AppointmentTime"];
                AnAppointment.FloorNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["FloorNumber"]);
                AnAppointment.RoomNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomNumber"]);
                AnAppointment.EmergencyAppointment = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmergencyAppointment"]);
                AnAppointment.Notes = Convert.ToString(DB.DataTable.Rows[Index]["Notes"]);
                //add the record to the private data member
                mAppointmentsList.Add(AnAppointment);
                //point to the next record
                Index++;
            }
        }
        public int Add()
        {
            System.Diagnostics.Debug.WriteLine(mThisAppointment.DateOfAppointment);
            //adds a new record to the database based on the values of mThisAppointment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //connect to patient database
            clsDataConnection DBPatient = new clsDataConnection();
            //set parameters for the stored procedure to find the patient id
            DBPatient.AddParameter("@FirstName", Convert.ToString(mThisAppointment.PatientFirstName));
            DBPatient.AddParameter("@LastName", Convert.ToString(mThisAppointment.PatientLastName));
            //execute the stored procedure to find the patient id
            DBPatient.Execute("sproc_tblAppointments_GetPatientByName");
            string[] PatientName = Convert.ToString(DBPatient.DataTable.Rows[0]["PName"]).Split(' ');
            //set the parameters for the stored procedure
            DB.AddParameter("@DoctorID", mThisAppointment.DoctorID);
            DB.AddParameter("@PatientID", DBPatient.DataTable.Rows[0]["PatientID"]);
            DB.AddParameter("@AppointmentDate", mThisAppointment.DateOfAppointment);
            DB.AddParameter("@AppointmentTime", mThisAppointment.TimeOfAppointment);
            DB.AddParameter("@FloorNumber", mThisAppointment.FloorNumber);
            DB.AddParameter("@RoomNumber", mThisAppointment.RoomNumber);
            DB.AddParameter("@EmergencyAppointment", mThisAppointment.EmergencyAppointment);
            DB.AddParameter("@Notes", mThisAppointment.Notes);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAppointments_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisAppointment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AppointmentID", mThisAppointment.AppointmentNumber);
            DB.AddParameter("@DoctorID", mThisAppointment.DoctorID);
            DB.AddParameter("@PatientID", mThisAppointment.PatientID);
            DB.AddParameter("@AppointmentDate", mThisAppointment.DateOfAppointment);
            DB.AddParameter("@AppointmentTime", mThisAppointment.TimeOfAppointment);
            DB.AddParameter("@FloorNumber", mThisAppointment.FloorNumber);
            DB.AddParameter("@RoomNumber", mThisAppointment.RoomNumber);
            DB.AddParameter("@EmergencyAppointment", mThisAppointment.EmergencyAppointment);
            DB.AddParameter("@Notes", mThisAppointment.Notes);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointments_Update");
        }
    }
}