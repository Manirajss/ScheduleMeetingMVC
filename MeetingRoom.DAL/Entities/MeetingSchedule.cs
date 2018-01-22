using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoom.DAL.Entities
{
    public class MeetingSchedule
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public virtual Room Room { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int? NumberOfAttendees { get; set; }
        public bool IsBooked { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
