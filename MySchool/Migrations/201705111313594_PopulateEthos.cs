namespace MySchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEthos : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Ethos (Id, Name) VALUES (1, 'Catholic')");
            Sql("INSERT INTO Ethos (Id, Name) VALUES (2, 'Church of Ireland')");
            Sql("INSERT INTO Ethos (Id, Name) VALUES (3, 'Multi-Denominational')");
            Sql("INSERT INTO Ethos (Id, Name) VALUES (4, 'Other')");
        }
        
        public override void Down()
        {
        }
    }
}
