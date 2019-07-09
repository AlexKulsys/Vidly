namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovieGenres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieGenres",
                c => new
                {
                    Id = c.Int(nullable: true, identity: false),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (1,'Drama')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (2,'Action')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (3,'Romantic')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (4,'Cartoon')");
        }
        
        public override void Down()
        {
        }
    }
}
