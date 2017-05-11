namespace MySchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropEthosFromSchools : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Schools", "Ethos");
        }
        
        public override void Down()
        {
        }
    }
}
