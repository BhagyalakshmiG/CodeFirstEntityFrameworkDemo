namespace CodeFirstEntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BedNo = c.Int(nullable: false),
                        Rent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IDProofMasters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProofName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PGs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoleMasters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        MobileNo = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        Password = c.String(),
                        Address = c.String(),
                        RoleMaster_Id = c.Int(nullable: false),
                        PG_Id = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        JoiningDate = c.DateTime(nullable: false),
                        LeavingDate = c.DateTime(nullable: false),
                        FoodOption = c.Boolean(nullable: false),
                        IDProofMaster_Id = c.Int(nullable: false),
                        Room_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Email, t.MobileNo });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Rooms");
            DropTable("dbo.RoleMasters");
            DropTable("dbo.PGs");
            DropTable("dbo.IDProofMasters");
            DropTable("dbo.Beds");
        }
    }
}
