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
            //create the item of test data
            clsPatient testItem = new clsPatient();
            //set its properties
            testItem.patientId = 1;
            testItem.pName = "Test Name";
            testItem.pEmail = "test.email@test.com";
            testItem.pDOB = Convert.ToDateTime("01/01/2000");
            testItem.pHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA";
            testItem.pAccessReq = true;
            testItem.pMainDocId = 1;
            //add the item to the test list
            mPatientList.Add(testItem);
            //re initialise the object for new data
            testItem = new clsPatient();
            //set its properties
            testItem.patientId = 2;
            testItem.pName = "Other Name";
            testItem.pEmail = "other.email@test.com";
            testItem.pDOB = Convert.ToDateTime("01/01/1999");
            testItem.pHomeAdd = "1OtherStreet,TestCity,Testshire,TE11AA";
            testItem.pAccessReq = false;
            testItem.pMainDocId = 1;
            //add the item to the test list
            mPatientList.Add(testItem);
        }
    }
}