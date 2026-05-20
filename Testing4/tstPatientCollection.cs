using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing4
{
    [TestClass]
    public class tstPatientCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPatientCollection allPatients = new clsPatientCollection();
            //test to see that it exists
            Assert.IsNotNull(allPatients);
        }

        [TestMethod]

        public void PatientListOK()
        {
            //create an instance of the class we want to create
            clsPatientCollection allPatients = new clsPatientCollection();
            //create some data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsPatient> testList = new List<clsPatient>();
            //add an itme to the list
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
            testList.Add(testItem);
            //assign the data to the property
            allPatients.PatientList = testList;
            //test to see that the two values are the same
            Assert.AreEqual(allPatients.PatientList, testList);
        }


        [TestMethod]

        public void ThisPatientPropertyOk()
        {
            //create an instance of the class we want to create
            clsPatientCollection allPatients = new clsPatientCollection();
            //create some data to asign to the property
            _ = new List<clsPatient>();
            clsPatient testPatient = new clsPatient
            {
                //set its properties
                patientId = 1,
                pName = "Test Name",
                pEmail = "test.email@test.com",
                pDOB = Convert.ToDateTime("01/01/2000"),
                pHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA",
                pAccessReq = true,
                pMainDocId = 1
            };
            allPatients.ThisPatient = testPatient;
            Assert.AreEqual(allPatients.ThisPatient, testPatient);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsPatientCollection allPatients = new clsPatientCollection();
            //create some data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsPatient> testList = new List<clsPatient>();
            //add an itme to the list
            //create the item of test data
            clsPatient testItem = new clsPatient
            {
                //set its properties
                patientId = 1,
                pName = "Test Name",
                pEmail = "test.email@test.com",
                pDOB = Convert.ToDateTime("01/01/2000"),
                pHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA",
                pAccessReq = true,
                pMainDocId = 1
            };
            //add the item to the test list
            testList.Add(testItem);
            //assign the data to the property
            allPatients.PatientList = testList;
            //test to see that the two values are the same
            Assert.AreEqual(allPatients.Count, testList.Count);
        }

        [TestMethod]

        public void AddMethodOK()
        {
            clsPatientCollection allPatients = new clsPatientCollection();
            clsPatient testItem = new clsPatient
            { 
                pName = "Test Name",
                pEmail = "test.email@test.com",
                pDOB = Convert.ToDateTime("01/01/2000"),
                pHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA",
                pAccessReq = true,
                pMainDocId = 1
            };
            //set ThisAddress to the test data
            allPatients.ThisPatient = testItem;
            //add the record
            int primaryKey = allPatients.Add();
            //set the primary key of the test data
            testItem.patientId = primaryKey;
            //find the record
            allPatients.ThisPatient.Find(primaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allPatients.ThisPatient, testItem);
        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            clsPatientCollection allPatients = new clsPatientCollection();
            clsPatient testItem = new clsPatient
            { 
                pName = "Test Name",
                pEmail = "test.email@test.com",
                pDOB = Convert.ToDateTime("01/01/2000"),
                pHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA",
                pAccessReq = true,
                pMainDocId = 1
            };
            allPatients.ThisPatient = testItem;
            Int32 primaryKey = allPatients.Add();
            testItem.patientId = primaryKey;
            //mod testItem
            testItem.pName = "Test Name2";
            testItem.pEmail = "test.email2@test.com";
            testItem.pDOB = Convert.ToDateTime("02/01/2000");
            testItem.pHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA";
            testItem.pAccessReq = false;
            testItem.pMainDocId = null;
            allPatients.ThisPatient = testItem;
            //update record
            allPatients.Update();
            //find the record
            allPatients.ThisPatient.Find(primaryKey);
            Assert.AreEqual(allPatients.ThisPatient, testItem);
        }
    }
}
