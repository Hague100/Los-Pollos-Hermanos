using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstRoom
    {
        String WardLocation = "General";
        String BedType = "General";
        String DisabilityAccess = "True";
        String HygieneStatus = "Available";
        String Inspected = "True";
        String Maintained = "True";
        String LastDateCleaned = "29/04/2026 00:00:00";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRoom ARoom = new clsRoom();
            //test to see that it exists
            Assert.IsNotNull(ARoom);
        }

        [TestMethod]
        public void FloorNumberIdPropertyOK()
        {
            clsRoom room = new clsRoom();
            Int32 TestData = 1;
            room.FloorNumber = TestData;
            Assert.AreEqual(room.FloorNumber, TestData);
        }

        [TestMethod]
        public void RoomNumberIdPropertyOK()
        {
            clsRoom room = new clsRoom();
            Int32 TestData = 2;
            room.RoomNumber = TestData;
            Assert.AreEqual(room.RoomNumber, TestData);
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
        /*
        [TestMethod]
        public void FindMethodOK()
        {
            clsRoom room = new clsRoom();
            Boolean Found = false;
            Int32 FloorNumber = 1;
            Int32 RoomNumber = 1;
            Found = room.Find(FloorNumber, RoomNumber);
            Assert.IsTrue(Found);
        }
        */

        [TestMethod]
        public void TestFloorNumberIdFound()
        {
            clsRoom room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FloorNumber = 1;
            Int32 RoomNumber = 1;
            Found = room.Find(FloorNumber, RoomNumber);

            if (room.FloorNumber != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRoomNumberIdFound()
        {
            clsRoom room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FloorNumber = 1;
            Int32 RoomNumber = 1;
            Found = room.Find(FloorNumber, RoomNumber);

            if (room.RoomNumber != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestWardLocationFound()
        {
            clsRoom room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FloorNumber = 1;
            Int32 RoomNumber = 1;
            Found = room.Find(FloorNumber, RoomNumber);

            if (room.WardLocation != "General")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestBedTypeFound()
        {
            clsRoom room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FloorNumber = 1;
            Int32 RoomNumber = 1;
            Found = room.Find(FloorNumber, RoomNumber);

            if (room.BedType != "General")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDisabilityAccessFound()
        {
            clsRoom room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FloorNumber = 1;
            Int32 RoomNumber = 1;
            Found = room.Find(FloorNumber, RoomNumber);

            if (room.DisabilityAccessible != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HygieneStatusFound()
        {
            clsRoom room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FloorNumber = 1;
            Int32 RoomNumber = 1;
            Found = room.Find(FloorNumber, RoomNumber);

            if (room.HygieneStatus != "Available")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void InspectedFound()
        {
            clsRoom room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FloorNumber = 1;
            Int32 RoomNumber = 1;
            Found = room.Find(FloorNumber, RoomNumber);

            if (room.Inspected != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void MaintainedFound()
        {
            clsRoom room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FloorNumber = 1;
            Int32 RoomNumber = 1;
            Found = room.Find(FloorNumber, RoomNumber);

            if (room.Maintained != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastDateCleanedFound()
        {
            clsRoom room = new clsRoom();
            Boolean Found = false;
            Boolean OK = true;
            Int32 FloorNumber = 1;
            Int32 RoomNumber = 1;
            Found = room.Find(FloorNumber, RoomNumber);
            if (room.LastDateCleaned != Convert.ToDateTime("29/04/2026 00:00:00"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsRoom room = new clsRoom();
            String error = "";
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleaned);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void WardLocationNotEqual()
        {
            clsRoom room = new clsRoom();
            String error = "";
            string WardLocation = "";
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleaned);
            Assert.AreEqual(error, "\nWard Location is not valid");
        }

        [TestMethod]
        public void WardLocationEqual()
        {
            clsRoom room = new clsRoom();
            String error = "";
            string WardLocation = "General";
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleaned);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void BedTypeNotEqual()
        {
            clsRoom room = new clsRoom();
            String error = "";
            string BedType = "";
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleaned);
            Assert.AreEqual(error, "\nBed Type is not valid");
        }

        [TestMethod]
        public void BedTypeEqual()
        {
            clsRoom room = new clsRoom();
            String error = "";
            string BedType = "General";
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleaned);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void HygieneStatusNotEqual()
        {
            clsRoom room = new clsRoom();
            String error = "";
            string HygieneStatus = "";
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleaned);
            Assert.AreEqual(error, "\nHygiene Status is not valid");
        }

        [TestMethod]
        public void HygieneStatusEqual()
        {
            clsRoom room = new clsRoom();
            String error = "";
            string HygieneStatus = "Available";
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleaned);
            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void LastDateCleanedExtremeMin()
        {
            clsRoom room = new clsRoom();
            String error = "";
            DateTime LastDateCleaned;
            LastDateCleaned = DateTime.Now.Date;
            LastDateCleaned = LastDateCleaned.AddYears(-100);
            string LastDateCleanedString = LastDateCleaned.ToString();
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleanedString);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastDateCleanedExtremeMinLessOne()
        {
            clsRoom room = new clsRoom();
            String error = "";
            DateTime LastDateCleaned;
            LastDateCleaned = DateTime.Now.Date;
            LastDateCleaned = LastDateCleaned.AddDays(-1);
            string LastDateCleanedString = LastDateCleaned.ToString();
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleanedString);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastDateCleanedMin()
        {
            clsRoom room = new clsRoom();
            String error = "";
            DateTime LastDateCleaned;
            LastDateCleaned = DateTime.Now.Date;
            String LastDateCleanedString = LastDateCleaned.ToString();
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleanedString);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastDateCleanedMinPlusOne()
        {
            clsRoom room = new clsRoom();
            String error = "";
            DateTime LastDateCleaned;
            LastDateCleaned = DateTime.Now.Date;
            LastDateCleaned = LastDateCleaned.AddDays(+1);
            String LastDateCleanedString = LastDateCleaned.ToString();
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleanedString);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LastDateCleanedExtremeMax()
        {
            clsRoom room = new clsRoom();
            String error = "";
            DateTime LastDateCleaned;
            LastDateCleaned = DateTime.Now.Date;
            LastDateCleaned = LastDateCleaned.AddYears(+100);
            String LastDateCleanedString = LastDateCleaned.ToString();
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleanedString);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LastDateCleanedInvalidData()
        {
            clsRoom room = new clsRoom();
            String error = "";
            string LastDateCleaned = "This is not a date";
            error = room.Valid(WardLocation, BedType, HygieneStatus, LastDateCleaned);

        }

    }
}
