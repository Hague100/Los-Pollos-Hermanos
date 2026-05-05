using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstRoom
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //test to see that it exists
            Assert.IsNotNull(ARoom);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ARoom.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARoom.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ARoom.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ARoom.DateAdded, TestData);
        }

        [TestMethod]
        public void FloorNumberIdPropertyOK()
        {
            clsRoom room = new clsRoom();
            Int32 TestData = 1;
            room.FloorNumberId = TestData;
            Assert.AreEqual(room.FloorNumberId, TestData);
        }

        [TestMethod]
        public void RoomNumberIdPropertyOK()
        {
            clsRoom room = new clsRoom();
            Int32 TestData = 2;
            room.RoomNumberId = TestData;
            Assert.AreEqual(room.RoomNumberId, TestData);
        }

        [TestMethod]
        public void WardLocationPropertyOK()
        {
            clsRoom room = new clsRoom();
            string TestData = "General Ward";
            room.WardLocation = TestData;
            Assert.AreEqual(room.WardLocation, TestData);
        }

        [TestMethod]
        public void BedTypePropertyOK()
        {
            clsRoom room = new clsRoom();
            string TestData = "Single";
            room.BedType = TestData;
            Assert.AreEqual(room.BedType, TestData);
        }

        [TestMethod]
        public void DisabilityAccessPropertyOK()
        {
            clsRoom room = new clsRoom();
            Boolean TestData = true;
            room.DisabilityAccessible = TestData;
            Assert.AreEqual(room.DisabilityAccessible, TestData);
        }

        [TestMethod]
        public void HygieneStatusPropertyOK()
        {
            clsRoom room = new clsRoom();
            string TestData = "Occupied";
            room.HygieneStatus = TestData;
            Assert.AreEqual(room.HygieneStatus, TestData);
        }

        [TestMethod]
        public void InspectedPropertyOK()
        {
            clsRoom room = new clsRoom();
            Boolean TestData = true;
            room.Inspected = TestData;
            Assert.AreEqual(room.Inspected, TestData);
        }

        [TestMethod]
        public void MaintainedPropertyOK()
        {
            clsRoom room = new clsRoom();
            Boolean TestData = true;
            room.Maintained = TestData;
            Assert.AreEqual(room.Maintained, TestData);
        }

        [TestMethod]
        public void LastDateCleanedPropertyOK()
        {
            clsRoom room = new clsRoom();
            DateTime TestData = DateTime.Now.Date;
            room.LastDateCleaned = TestData;
            Assert.AreEqual(room.LastDateCleaned, TestData);
        }
    }
}
