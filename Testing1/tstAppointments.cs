using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class TstAppointments
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //test to see that it exists
            Assert.IsNotNull(AnAppointment);
        }
        [TestMethod]
        public void AppointmentNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAppointment.AppointmentNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.AppointmentNumber, TestData);
        }
        [TestMethod]
        public void DoctorIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAppointment.DoctorID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.DoctorID, TestData);
        }
        [TestMethod]
        public void PatientIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAppointment.PatientID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.PatientID, TestData);
        }
        [TestMethod]
        public void DateOfAppointmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAppointment.DateOfAppointment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.DateOfAppointment, TestData);
        }
        [TestMethod]
        public void TimeOfAppointmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //assign the data to the property
            AnAppointment.TimeOfAppointment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.TimeOfAppointment, TestData);
        }
        [TestMethod]
        public void FloorNUmberPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAppointment.FloorNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.FloorNumber, TestData);
        }
        [TestMethod]
        public void RoomNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAppointment.RoomNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.RoomNumber, TestData);
        }
        [TestMethod]
        public void EmergencyAppointmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAppointment.EmergencyAppointment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.EmergencyAppointment, TestData);
        }
        [TestMethod]
        public void NotesPropertyOK()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property
            string TestData = "This is a test note.";
            //assign the data to the property
            AnAppointment.Notes = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.Notes, TestData);
        }
    }
}
