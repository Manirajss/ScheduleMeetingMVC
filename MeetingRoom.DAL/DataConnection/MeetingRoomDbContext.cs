//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MeetingRoom.DAL.DataConnection
//{
//    public class MeetingRoomDbContext
//    {
//    }
//}


using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MeetingRoom.DAL.Entities;
using MeetingRoom.DAL.SeedData;

namespace MeetingRoom.DAL.DataConnection
{
    public class MeetingRoomDbContext : DbContext
    {

        public MeetingRoomDbContext()
            : base("MeetingRoomContext")
        {
            Database.SetInitializer(new MeetingDBInitializer());
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<MeetingSchedule> MeetingSchedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}