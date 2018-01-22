using MeetingRoom.DAL.DataConnection;
using MeetingRoomReservation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MeetingRoomReservation.Api
{
    public class MeetingPlanningController : ApiController
    {
        // GET api/<controller>
        //public List<MeetingViewModel> GetMeetingRooms([FromUri]SearchViewModel searchVM)
        [HttpPost]
        public List<MeetingViewModel> GetMeetingRooms([FromBody]SearchViewModel searchVM)
        {
            //todo: context externalise
            try
            {
                var context = new MeetingRoomDbContext();

                var scheduleMeetings = context.MeetingSchedules.ToList();
                var meetingList = new List<MeetingViewModel>();

                foreach (var sm in scheduleMeetings)
                {
                    var room = sm.Room;
                    var meetingVM = new MeetingViewModel()
                    {
                        Id = sm.Id,
                        EmployeeId = sm.EmployeeId,
                        EmployeeName = sm.EmployeeName,
                        StartTime = sm.StartDateTime,
                        EndTime = sm.EndDateTime,
                        NumberOfAttendees = sm.NumberOfAttendees,
                        IsBooked = sm.IsBooked,
                        RoomVM = new RoomViewModel()
                        {
                            Id = room.Id,
                            BuildingName = room.BuildingName,
                            RoomName = room.RoomName,
                            RoomCapacity = room.RoomCapacity
                        }
                    };
                    meetingList.Add(meetingVM);
                }

                return meetingList;
            }
            catch (Exception)
            {
                
                throw;//todo: log to db
            }
        }
        
    }
}