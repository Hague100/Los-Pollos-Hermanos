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
            // hardcoded to always return true for now
            doctorId = 1;
            doctorAvailability = true;
            doctorFirstName = "Josh";
            doctorLastName = "Heins";
            doctorAddress = "98 Nulview Rd";
            doctorEmail = "Doc@Nullard.com";
            doctorPhoneNumber = "07938383812";
            return true;
        }
    }
}