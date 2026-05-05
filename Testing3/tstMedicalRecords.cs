using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.Design;

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
        public void PatientIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsMedicalRecords AMedicalRecords = new clsMedicalRecords();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMedicalRecords.PatientID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AMedicalRecords.PatientID, TestData);
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
    }
}