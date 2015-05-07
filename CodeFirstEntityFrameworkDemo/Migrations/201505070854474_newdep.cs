namespace CodeFirstEntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdep : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "RoleMaster_Id");
            AddForeignKey("dbo.Users", "RoleMaster_Id", "dbo.RoleMasters", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleMaster_Id", "dbo.RoleMasters");
            DropIndex("dbo.Users", new[] { "RoleMaster_Id" });
        }
    }
}
