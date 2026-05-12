using System;

namespace ClassLibrary
{
    public class clsPatient
    {
        public string pName;
        public string pEmail;
        public DateTime pDOB;
        public string pHomeAdd;
        public bool pAccessReq;
        public int pMainDocId;

        public int patientId { get; set; }
        public string pPhoneNO { get; set; }
    }
}