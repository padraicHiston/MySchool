namespace MySchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSchoolImageCol : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Schools ADD SchoolImage VARCHAR(20)");
        }
        
        public override void Down()
        {
        }
    }
}
