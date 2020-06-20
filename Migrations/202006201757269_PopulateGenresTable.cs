namespace AlongSide.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Engineer')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Scientist')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Administrator')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Doctor')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Software Engineer')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Database Administrator')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Network Engineer')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Teacher')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Coach')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Business Owner')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Minister')");

        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)");
        }
    }
}
