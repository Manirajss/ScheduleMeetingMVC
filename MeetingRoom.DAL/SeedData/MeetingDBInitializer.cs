using MeetingRoom.DAL.DataConnection;
using MeetingRoom.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoom.DAL.SeedData
{
    
    public class MeetingDBInitializer : CreateDatabaseIfNotExists<MeetingRoomDbContext>
    {
        protected override void Seed(MeetingRoomDbContext context)
        {
            var rooms = new List<Room>();
            var buildingNames = new List<string>() { "Building 1", "Building 2", "Building 3" };
            var roomNames = new List<string>() { "Nehru Halls", "Gandhi Hall", "Steve Hall", "BillGates Innovation Lab", "Peter Hall", "Grant Mall", "Ben Lab", "Mark Library Hall", "DisQus Forum Hall" };
            var roomCapacities = new List<int>() { 10, 20, 30 };

            //var id = 1;
            var buildingRandomnessId = 1;
            var roomCapacityRandomId = 1;

            foreach (var roomName in roomNames)
            {
                //reset
                if (buildingRandomnessId == (buildingNames.Count() + 1))
                {
                    buildingRandomnessId = 1;
                    roomCapacityRandomId++;
                }
                if (roomCapacityRandomId == (roomCapacities.Count() + 1 ))
                    roomCapacityRandomId = 1;

                var room = new Room()
                {
                    //Id = id,
                    RoomName = roomName,
                    BuildingName = buildingNames.ElementAtOrDefault(buildingRandomnessId - 1),
                    RoomCapacity = roomCapacities.ElementAtOrDefault(roomCapacityRandomId - 1)
                };
                context.Rooms.Add(room);
                context.SaveChanges();
                buildingRandomnessId++;
                
            }
            var roomsList = context.Rooms.ToList();
            foreach (var room in roomsList)
            {
        //         public int Id { get; set; }
        //public string EmployeeId { get; set; }
        //public string EmployeeName { get; set; }
        //public virtual RoomViewModel RoomVM { get; set; }
        //public int RoomId { get; set; }
        //public DateTime StartTime { get; set; }
        //public DateTime EndTime { get; set; }
        //public int NumberOfAttendees { get; set; }
        //public bool IsBooked { get; set; }
                var ms = new MeetingSchedule()
                {
                    EmployeeId = null,
                    EmployeeName = null,
                    StartDateTime = DateTime.Now.Date,
                    EndDateTime = DateTime.Now.Date.AddDays(1).AddMinutes(-1),
                    NumberOfAttendees = null,
                    IsBooked = false,
                    Room = room,
                    RoomId = room.Id
                };
                context.MeetingSchedules.Add(ms);
                context.SaveChanges();
            }

            base.Seed(context);
        }
    }
}
