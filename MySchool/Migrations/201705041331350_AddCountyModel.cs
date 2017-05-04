namespace MySchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountyModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Counties");
        }
    }
}
