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
            allPatients.patientList = testList;
            //test to see that the two values are the same
            Assert.AreEqual(allPatients.patientList, testList);
        }

        [TestMethod]

        public void CountPropertyOk()
        {
            clsPatientCollection allPatient = new clsPatientCollection();
            Int32 someCount = 2;
            allPatient.count = someCount;
            Assert.AreEqual(allPatient.count, someCount);
        }

        [TestMethod]

        public void ThisPatientPropertyOk()
        {
            //create an instance of the class we want to create
            clsPatientCollection allPatients = new clsPatientCollection();
            //create some data to asign to the property
            List<clsPatient> testList = new List<clsPatient>();
            clsPatient testPatient = new clsPatient();
            //set its properties
            testPatient.patientId = 1;
            testPatient.pName = "Test Name";
            testPatient.pEmail = "test.email@test.com";
            testPatient.pDOB = Convert.ToDateTime("01/01/2000");
            testPatient.pHomeAdd = "1TestStreet,TestCity,Testshire,TE11AA";
            testPatient.pAccessReq = true;
            testPatient.pMainDocId = 1;
            allPatients.thisPatient = testPatient;
            Assert.AreEqual(allPatients.thisPatient, testPatient);
        }

        [TestMethod]

        public void listAndCountOK()
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
            allPatients.patientList = testList;
            //test to see that the two values are the same
            Assert.AreEqual(allPatients.count, testList.Count);
        }

        [TestMethod]

        public void twoRecordsPresent()
        {
            clsPatientCollection allPatients = new clsPatientCollection();
            Assert.AreEqual(allPatients.count, 2);
        }
    }
}
