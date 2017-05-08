namespace MySchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "CountyId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Schools", "CountyId");
            AddForeignKey("dbo.Schools", "CountyId", "dbo.Counties", "Id", cascadeDelete: true);
            DropColumn("dbo.Schools", "County");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schools", "County", c => c.String(nullable: false));
            DropForeignKey("dbo.Schools", "CountyId", "dbo.Counties");
            DropIndex("dbo.Schools", new[] { "CountyId" });
            DropColumn("dbo.Schools", "CountyId");
        }
    }
}
