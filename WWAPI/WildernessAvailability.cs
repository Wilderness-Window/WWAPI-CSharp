using System;
using WWAPI.WWAPI; //cross-reference

namespace WWAPI
{
    internal class WildernessAvailability
    {
        public DateTime Date { get; set; }
        public string PropertyCode { get; set; }
        public WWAPI.GetAvailabilityByDayResponseAvailabilityByDayAvailabilityByDayRoomType RoomType { get; set; } 
        public long RoomsAvail { get; set; }
    }
}