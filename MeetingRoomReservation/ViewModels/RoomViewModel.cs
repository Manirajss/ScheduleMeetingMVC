using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetingRoomReservation.ViewModels
{
    public class RoomViewModel
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public string RoomName { get; set; }
        public int RoomCapacity { get; set; }
    }
}