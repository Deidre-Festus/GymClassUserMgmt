namespace GymClassUserMgmt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGymClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GymClasses", "StartTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GymClasses", "StartTime", c => c.DateTime(nullable: false));
        }
    }
}
