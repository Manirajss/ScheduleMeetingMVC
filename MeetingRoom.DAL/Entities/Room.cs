using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoom.DAL.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public string RoomName { get; set; }
        public int RoomCapacity { get; set; }
    }
}
