using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetingRoomReservation.ViewModels
{
    public class SearchViewModel
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string RoomName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? NumberOfAttendees { get; set; }
        public bool IsBooked { get; set; }
    }
}