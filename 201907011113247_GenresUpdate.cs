namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenresUpdate : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES ( Genres) VALUES ('Action')");
            Sql("INSERT INTO GENRES ( GENRES) VALUES ('Drama')");
            Sql("INSERT INTO GENRES ( GENRES) VALUES ('Romantic')");
            Sql("INSERT INTO GENRES ( GENRES) VALUES ('SCI-FI')");
            Sql("INSERT INTO GENRES ( GENRES) VALUES ('Thriller')");
            Sql("INSERT INTO GENRES ( GENRES) VALUES ('Anime')");
        }

        public override void Down()
        {
        }
    }
}
