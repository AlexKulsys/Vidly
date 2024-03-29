namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieGenres : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieGenres", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MovieGenres");
        }
    }
}
