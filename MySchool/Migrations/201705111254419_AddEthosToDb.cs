namespace MySchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEthosToDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ethos",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ethos");
        }
    }
}
