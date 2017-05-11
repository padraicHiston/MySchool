namespace MySchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEthosToSchools : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "Ethos", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schools", "Ethos");
        }
    }
}
