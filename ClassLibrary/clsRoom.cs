using System;

namespace ClassLibrary
{
    public class clsRoom
    {
        private Int32 mFloorNumber;
        private Int32 mRoomNumber;
        private string mWardLocation;
        private string mBedType;
        private bool mDisabilityAccessible;
        private string mHygieneStatus;
        private bool mInspected;
        private bool mMaintained;
        private DateTime mLastDateCleaned;

        public Int32 FloorNumber
        {
            get
            {
                return mFloorNumber;
            }
            set
            {
                mFloorNumber = value;
            }
        }

        public Int32 RoomNumber
        {
            get
            {
                return mRoomNumber;
            }
            set
            {
                mRoomNumber = value;
            }
        }

        public string WardLocation
        {
            get
            {
                return mWardLocation;
            }
            set
            {
                mWardLocation = value;
            }
        }

        public string BedType
        {
            get
            {
                return mBedType;
            }
            set
            {
                mBedType = value;
            }
        }

        public bool DisabilityAccessible
        {
            get
            {
                return mDisabilityAccessible;
            }
            set
            {
                mDisabilityAccessible = value;
            }
        }

        public string HygieneStatus
        {
            get
            {
                return mHygieneStatus;
            }
            set
            {
                mHygieneStatus = value;
            }
        }

        public bool Inspected
        {
            get
            {
                return mInspected;
            }
            set
            {
                mInspected = value;
            }
        }

        public bool Maintained
        {
            get
            {
                return mMaintained;
            }
            set
            {
                mMaintained = value;
            }
        }

        public DateTime LastDateCleaned
        {
            get
            {
                return mLastDateCleaned;
            }
            set
            {
                mLastDateCleaned = value;
            }
        }

        public bool Find(int FloorNumber, int RoomNumber)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FloorNumber", FloorNumber);
            DB.AddParameter("@RoomNumber", RoomNumber);

            DB.Execute("sproc_tblRoom_FilterByFloorNRoomNumberId");

            if (DB.Count == 1)
            {
                mFloorNumber = Convert.ToInt32(DB.DataTable.Rows[0]["FloorNumber"]);
                mRoomNumber = Convert.ToInt32(DB.DataTable.Rows[0]["RoomNumber"]);
                mWardLocation = Convert.ToString(DB.DataTable.Rows[0]["WardLocation"]);
                mBedType = Convert.ToString(DB.DataTable.Rows[0]["BedType"]);
                mDisabilityAccessible = Convert.ToBoolean(DB.DataTable.Rows[0]["DisabilityAccess"]);
                mHygieneStatus = Convert.ToString(DB.DataTable.Rows[0]["HygieneStatus"]);
                mInspected = Convert.ToBoolean(DB.DataTable.Rows[0]["Inspected"]);
                mMaintained = Convert.ToBoolean(DB.DataTable.Rows[0]["Maintained"]);
                mLastDateCleaned = Convert.ToDateTime(DB.DataTable.Rows[0]["LastDateCleaned"]);


                return true;
            }

            else
            {
                return false;

            }
        }
    }
}