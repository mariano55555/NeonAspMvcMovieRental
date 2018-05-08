namespace Neon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, DateAdded, ReleaseDate, NumberInStock, GenreId) VALUES (1, 'HangOver', '1981-12-20','1981-12-20', 5, 1)");
            Sql("INSERT INTO Movies (Id, Name, DateAdded, ReleaseDate, NumberInStock, GenreId) VALUES (2, 'Terminator','1981-12-20','1981-12-20', 4, 2)");
            Sql("INSERT INTO Movies (Id, Name, DateAdded, ReleaseDate, NumberInStock, GenreId) VALUES (3, 'I wont back down', '1981-12-20','1981-12-20', 3, 3)");
            Sql("INSERT INTO Movies (Id, Name, DateAdded, ReleaseDate, NumberInStock, GenreId) VALUES (4, '11 dias sin agua', '1981-12-20','1981-12-20', 2, 4)");
            Sql("INSERT INTO Movies (Id, Name, DateAdded, ReleaseDate, NumberInStock, GenreId) VALUES (5, 'Animalistic','1981-12-20','1981-12-20', 1, 5)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
