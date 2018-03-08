namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres(Id, Name) VALUES(1, 'Comedy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(2, 'Drama')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(3, 'Action')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(4, 'Science Fiction')");
        }
        
        public override void Down()
        {
        }
    }
}
