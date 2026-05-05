using System;

namespace ClassLibrary
{
    public class clsRoom
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int FloorNumberId { get; set; }
        public int RoomNumberId { get; set; }
        public string WardLocation { get; set; }
        public string BedType { get; set; }
        public bool DisabilityAccessible { get; set; }
        public string HygieneStatus { get; set; }
        public bool Inspected { get; set; }
        public bool Maintained { get; set; }
        public DateTime LastDateCleaned { get; set; }
    }
}