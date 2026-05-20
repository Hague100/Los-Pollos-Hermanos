using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    [TestClass]
    public class tstRoomCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsRoomCollection room = new clsRoomCollection();
            Assert.IsNotNull(room);
        }

        [TestMethod]
        public void RoomListOK()
        {
            clsRoomCollection room = new clsRoomCollection();
            List<clsRoom> TestList = new List<clsRoom>();
            clsRoom TestItem = new clsRoom();
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 4;
            TestItem.WardLocation = "Intensive Care Unit";
            TestItem.BedType = "Heavy";
            TestItem.DisabilityAccessible = true;
            TestItem.HygieneStatus = "Available";
            TestItem.Inspected = true;
            TestItem.Maintained = true;
            TestItem.LastDateCleaned = DateTime.Now;

            TestList.Add(TestItem);

            room.RoomList = TestList;

            Assert.AreEqual(room.RoomList, TestList);
        }

        [TestMethod]
        public void ThisRoomOK()
        {
            clsRoomCollection rooms = new clsRoomCollection();
            clsRoom TestRoom = new clsRoom();

            TestRoom.FloorNumber = 1;
            TestRoom.RoomNumber = 1;
            TestRoom.WardLocation = "General";
            TestRoom.BedType = "General";
            TestRoom.DisabilityAccessible = true;
            TestRoom.HygieneStatus = "Available";
            TestRoom.Inspected = true;
            TestRoom.Maintained = true;
            TestRoom.LastDateCleaned = Convert.ToDateTime("29/04/2026 00:00:00");

            rooms.ThisRoom = TestRoom;
            Assert.AreEqual(rooms.ThisRoom, TestRoom);
        
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsRoomCollection rooms = new clsRoomCollection();
            List<clsRoom> TestList = new List<clsRoom>();
            clsRoom TestItem = new clsRoom();
            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 4;
            TestItem.WardLocation = "Intensive Care Unit";
            TestItem.BedType = "Heavy";
            TestItem.DisabilityAccessible = true;
            TestItem.HygieneStatus = "Available";
            TestItem.Inspected = true;
            TestItem.Maintained = true;
            TestItem.LastDateCleaned = DateTime.Now;
            TestList.Add(TestItem);

            rooms.RoomList = TestList;

            Assert.AreEqual(rooms.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsRoomCollection AllRooms = new clsRoomCollection();
            clsRoom TestItem = new clsRoom();

            Int32 PrimaryKeyFloor = 2;
            Int32 SecondaryKeyRoom = 6;

            TestItem.FloorNumber = 2;
            TestItem.RoomNumber = 6;
            TestItem.WardLocation = "General";
            TestItem.BedType = "General";
            TestItem.DisabilityAccessible = true;
            TestItem.HygieneStatus = "Available";
            TestItem.Inspected = true;
            TestItem.Maintained = true;
            TestItem.LastDateCleaned = Convert.ToDateTime("29/04/2026 00:00:00");
        
            AllRooms.ThisRoom = TestItem;

            PrimaryKeyFloor = AllRooms.Add();

            TestItem.FloorNumber = PrimaryKeyFloor;
            TestItem.RoomNumber = SecondaryKeyRoom;

            AllRooms.ThisRoom.Find(PrimaryKeyFloor, SecondaryKeyRoom);

            Assert.AreEqual(AllRooms.ThisRoom, TestItem);
        }
    }
}
