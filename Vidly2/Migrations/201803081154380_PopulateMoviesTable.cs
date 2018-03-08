namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock) VALUES(1, 'Hangover', '2014-04-02', '2018-05-08', 5)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock) VALUES(2, 'The Sixth Sense', '1997-05-14', '2017-04-08', 5)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock) VALUES(3, 'Titanic', '1997-04-02', '2015-04-02', 5)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock) VALUES(4, 'Harry Potter 1', '2001-12-16', '2015-05-12', 5)");
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock) VALUES(5, 'The Conjuring', '2015-01-02', '2016-05-08', 5)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Movies");
        }
    }
}
