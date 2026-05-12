using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Testing3
{
    [TestClass]
    public class tstMedicalRecords
    {
        [TestMethod]
        public void ImstanceOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //test to see that it exists
            Assert.IsNotNull(AMedicalRecords);
        }

        [TestMethod]
        public void RecordIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMedicalRecords.recordId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.recordId, TestData);
        }

        [TestMethod]
        public void PatientIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMedicalRecords.patientId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.patientId, TestData);
        }
        [TestMethod]
        public void DoctorIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMedicalRecords.DoctorID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.DoctorID, TestData);
        }
        [TestMethod]
        public void AppIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMedicalRecords.appID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.appID, TestData);
        }
        [TestMethod]
        public void DatePropertyOk()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AMedicalRecords.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.Date, TestData);
        }

        [TestMethod]
        public void PendingAppPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AMedicalRecords.pendingApp = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.pendingApp, TestData);
        }


        [TestMethod]
        public void AppNotesPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            string TestData = "This is a test note";
            //assign the data to the property
            AMedicalRecords.appNotes = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.appNotes, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestRecordIDFound()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            // create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //check the record id
            if (AMedicalRecords.recordId != 1)
            {
                OK = false;
            }
            //return the result of the test
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPatientIDFound()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            // create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //check the patient id
            if (AMedicalRecords.patientId != 456)
            {
                OK = false;
            }
            //return the result of the test
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDoctorIDFound()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            // create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 recordId = 1;
            //invoke the method
            Found = AMedicalRecords.Find(recordId);
            //check the doctor id
            if (AMedicalRecords.doctorId != 123)
            {
                OK = false;
            }
            //return the result of the test
            Assert.IsTrue(OK); 

            }

                [TestMethod]
                public void TestAppIDFound()
                {
                    // create an instance of the class we want to create
                    clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
                    //boolean variable to store the result of the validation
                    Boolean Found = false;
                    // create a boolean variable to record if data is OK (assume it is)
                    Boolean OK = true;
                    //create some test data to use with the method
                    Int32 recordId = 1;
                    //invoke the method
                    Found = AMedicalRecords.Find(recordId);
                    //check the app id
                    if (AMedicalRecords.appID != 1)
                    {
                        OK = false;
                    }
                    //return the result of the test
                    Assert.IsTrue(OK);

        }

                    [TestMethod]
                    public void pendingAppFound()
                    {
                        // create an instance of the class we want to create
                        clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
                        //boolean variable to store the result of the validation
                        Boolean Found = false;
                        // create a boolean variable to record if data is OK (assume it is)
                        Boolean OK = true;
                        //create some test data to use with the method
                        Int32 recordId = 1;
                        //invoke the method
                        Found = AMedicalRecords.Find(recordId);
                        //check the pending app
                        if (AMedicalRecords.pendingApp != true)
                        {
                            OK = false;
                        }
                        //return the result of the test
                        Assert.IsTrue(OK);
                    }


                    [TestMethod]
                    public void AppNotesFound()
                    {
                        // create an instance of the class we want to create
                        clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
                        //boolean variable to store the result of the validation
                        Boolean Found = false;
                        // create a boolean variable to record if data is OK (assume it is)
                        Boolean OK = true;
                        //create some test data to use with the method
                        Int32 recordId = 1;
                        //invoke the method
                        Found = AMedicalRecords.Find(recordId);
                        //check the app notes
                        if (AMedicalRecords.appNotes != "Test note")
                        {
                            OK = false;
                        }
                        //return the result of the test
                        Assert.IsTrue(OK);
                    }

           }
    }