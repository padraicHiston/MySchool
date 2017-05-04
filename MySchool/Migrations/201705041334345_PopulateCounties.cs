namespace MySchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCounties : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Counties (Id, Name) VALUES (1, 'Antrim')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (2, 'Armagh')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (3, 'Carlow')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (4, 'Cavan')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (5, 'Clare')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (6, 'Cork')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (7, 'Derry')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (8, 'Donegal')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (9, 'Down')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (10, 'Dublin')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (11, 'Fermanagh')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (12, 'Galway')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (13, 'Kerry')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (14, 'Kildare')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (15, 'Kilkenny')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (16, 'Laois')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (17, 'Leitrim')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (18, 'Limerick')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (19, 'Longford')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (20, 'Louth')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (21, 'Mayo')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (22, 'Meath')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (23, 'Monaghan')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (24, 'Offaly')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (25, 'Roscommon')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (26, 'Sligo')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (27, 'Tipperary')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (28, 'Tyrone')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (29, 'Waterford')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (30, 'Westmeath')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (31, 'Wexford')");
            Sql("INSERT INTO Counties (Id, Name) VALUES (32, 'Wicklow')");
        }
        
        public override void Down()
        {
        }
    }
}
