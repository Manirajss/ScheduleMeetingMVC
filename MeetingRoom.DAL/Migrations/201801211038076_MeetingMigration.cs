namespace MeetingRoom.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MeetingMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MeetingSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.String(),
                        EmployeeName = c.String(),
                        RoomId = c.Int(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        NumberOfAttendees = c.Int(),
                        IsBooked = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BuildingName = c.String(),
                        RoomName = c.String(),
                        RoomCapacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MeetingSchedules", "RoomId", "dbo.Rooms");
            DropIndex("dbo.MeetingSchedules", new[] { "RoomId" });
            DropTable("dbo.Rooms");
            DropTable("dbo.MeetingSchedules");
        }
    }
}
