namespace MySchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEthosId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "EthosId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Schools", "EthosId");
            AddForeignKey("dbo.Schools", "EthosId", "dbo.Ethos", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schools", "EthosId", "dbo.Ethos");
            DropIndex("dbo.Schools", new[] { "EthosId" });
        }
    }
}
