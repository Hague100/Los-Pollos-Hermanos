using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsRoomCollection
    {
        List<clsRoom> mRoomsList = new List<clsRoom>();

        clsRoom mThisRoom = new clsRoom();

        public List<clsRoom> RoomList
        {

            get
            {
                return mRoomsList;
            }

            set
            {
                mRoomsList = value;
            }
        }

        public int Count { 
            
            get
            {
                return mRoomsList.Count;
            }
            
            set
            {
                //Set this up later
            }
        
        }
        public clsRoom ThisRoom 
        { 
            get
            {
                return mThisRoom;
            }
            set 
            {
                mThisRoom = value;
            }
        }

        public clsRoomCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblRooms_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsRoom room = new clsRoom();

                room.FloorNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["FloorNumber"]);
                room.RoomNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomNumber"]);
                room.WardLocation = Convert.ToString(DB.DataTable.Rows[Index]["WardLocation"]);
                room.BedType = Convert.ToString(DB.DataTable.Rows[Index]["BedType"]);
                room.DisabilityAccessible = Convert.ToBoolean(DB.DataTable.Rows[Index]["DisabilityAccess"]);
                room.HygieneStatus = Convert.ToString(DB.DataTable.Rows[Index]["HygieneStatus"]);
                room.Inspected = Convert.ToBoolean(DB.DataTable.Rows[Index]["Inspected"]);
                room.Maintained = Convert.ToBoolean(DB.DataTable.Rows[Index]["Maintained"]);
                room.LastDateCleaned = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastDateCleaned"]);
            
                mRoomsList.Add(room);

                Index++;
            }
        }

        public void Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FloorNumber", mThisRoom.FloorNumber);
            DB.AddParameter("@RoomNumber", mThisRoom.RoomNumber);
            DB.AddParameter("@WardLocation", mThisRoom.WardLocation);
            DB.AddParameter("@BedType", mThisRoom.BedType);
            DB.AddParameter("@DisabilityAccess", mThisRoom.DisabilityAccessible);
            DB.AddParameter("@HygieneStatus", mThisRoom.HygieneStatus);
            DB.AddParameter("@Inspected", mThisRoom.Inspected);
            DB.AddParameter("@Maintained", mThisRoom.Maintained);
            DB.AddParameter("@LastDateCleaned", mThisRoom.LastDateCleaned);

            DB.Execute("sproc_tblRoom_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FloorNumber", mThisRoom.FloorNumber);
            DB.AddParameter("@RoomNumber", mThisRoom.RoomNumber);
            DB.AddParameter("@WardLocation", mThisRoom.WardLocation);
            DB.AddParameter("@BedType", mThisRoom.BedType);
            DB.AddParameter("@DisabilityAccess", mThisRoom.DisabilityAccessible);
            DB.AddParameter("@HygieneStatus", mThisRoom.HygieneStatus);
            DB.AddParameter("@Inspected", mThisRoom.Inspected);
            DB.AddParameter("@Maintained", mThisRoom.Maintained);
            DB.AddParameter("@LastDateCleaned", mThisRoom.LastDateCleaned);

            DB.Execute("sproc_tblRoom_Update");
        }
    }
}