using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstAppointmentsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create and instance of the class we want to create
            clsAppointmentsCollection AllAppointments = new clsAppointmentsCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAppointments);
        }
        [TestMethod]
        public void AppointmentsListOK()
        {
            //create an instance of the class we want to create
            clsAppointmentsCollection AllAppointments = new clsAppointmentsCollection();
            //create some test data to assign to the property
            List<clsAppointments> TestList = new List<clsAppointments>();
            //add an item to the list
            clsAppointments TestItem = new clsAppointments();
            TestItem.AppointmentNumber = 2;
            TestItem.DoctorID = 2;
            TestItem.PatientFirstName = "Test";
            TestItem.PatientLastName = "Patient";
            TestItem.DateOfAppointment = DateTime.Now.Date;
            TestItem.TimeOfAppointment = new TimeSpan(12, 0, 0);
            Console.WriteLine(TestItem.TimeOfAppointment);
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 2;
            TestItem.EmergencyAppointment = true;
            TestItem.Notes = "Test Description";
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.AppointmentsList, TestList);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsAppointmentsCollection AllAppointments = new clsAppointmentsCollection();
            //create some test data to assign to the property
            List<clsAppointments> TestList = new List<clsAppointments>();
            //add an item to the list
            clsAppointments TestItem = new clsAppointments();
            TestItem.AppointmentNumber = 2;
            TestItem.DoctorID = 2;
            TestItem.PatientFirstName = "Test2";
            TestItem.PatientLastName = "Patient2";
            TestItem.DateOfAppointment = DateTime.Now.Date;
            TestItem.TimeOfAppointment = new TimeSpan(12, 0, 0);
            Console.WriteLine(TestItem.TimeOfAppointment);
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 2;
            TestItem.EmergencyAppointment = false;
            TestItem.Notes = "Test Description";
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentsList = TestList;
            AllAppointments.Count = TestList.Count;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.Count, TestList.Count);
        }
    }
}
