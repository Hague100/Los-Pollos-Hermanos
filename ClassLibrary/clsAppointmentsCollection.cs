using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    //constructor for the class
    public class clsAppointmentsCollection
    {
        //private data member for the list
        List<clsAppointments> mAppointmentsList = new List<clsAppointments>();
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
        public int Count {
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
        public clsAppointments ThisAppointment { get; set; }
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
                //read in the fields from the current record
                AnAppointment.AppointmentNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["AppointmentNumber"]);
                AnAppointment.DoctorID = Convert.ToInt32(DB.DataTable.Rows[Index]["DoctorID"]);
                AnAppointment.PatientFirstName = Convert.ToString(DB.DataTable.Rows[Index]["PatientFirstName"]);
                AnAppointment.PatientLastName = Convert.ToString(DB.DataTable.Rows[Index]["PatientLastName"]);
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
    }
}