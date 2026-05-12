using System;

namespace ClassLibrary
{
    public class clsDoc
    {
        private Int32 doctorId;
        private Boolean doctorAvailability;
        private String doctorFirstName;
        private String doctorLastName;
        private String doctorAddress;
        private String doctorEmail;
        private String doctorPhoneNumber;

        public int dId
        {
            get {
                return doctorId;
            }
            set { 
                doctorId = value;
            }
        }
        public bool dAvailability
        {
            get
            {
                return doctorAvailability;
            }
            set
            {
                doctorAvailability = value;
            }
        }
        public string dPhoneNumber
        {
            get
            {
                return doctorPhoneNumber;
            }
            set
            {
                doctorPhoneNumber = value;
            }
        }
        public string dEmail
        {
            get
            {
                return doctorEmail;
            }
            set
            {
                doctorEmail = value;
            }
        }
        public string dAddress
        {
            get
            {
                return doctorAddress;
            }
            set
            {
                doctorAddress = value;
            }
        }
        public string dLastName
        {
            get
            {
                return doctorLastName;
            }
            set
            {
                doctorLastName = value;
            }
        }
        public string dFirstName
        {
            get
            {
                return doctorFirstName;
            }
            set
            {
                doctorFirstName = value;
            }
        }


        public bool Find(int docId)
        {

            // create an instance of a dataconnection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the address id to search for
            DB.AddParameter("@DoctorId", docId);
            // excute the stored procidure
            DB.Execute("sproc_tblDoctors_FilterByDoctorId");
            //  if one ecourd is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // coppy the data from the database to ht private data members
                doctorId = Convert.ToInt32(DB.DataTable.Rows[0]["DoctorId"]);
                doctorAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["DAvailability"]); 
                doctorFirstName = Convert.ToString(DB.DataTable.Rows[0]["DFirstName"]);
                doctorLastName = Convert.ToString(DB.DataTable.Rows[0]["DLastName"]);
                doctorAddress = Convert.ToString(DB.DataTable.Rows[0]["DAddress"]);
                doctorEmail = Convert.ToString(DB.DataTable.Rows[0]["DEmail"]);
                doctorPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["DPhoneNumber"]);
                return true;
            }
            // if noo record was found
            else
            {
                // return false indicating there was a problem
                return false;
            }
           

        }
    }
}