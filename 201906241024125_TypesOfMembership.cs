namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypesOfMembership : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "TypesOfMembership", c => c.String());
            

        }
        
        public override void Down()
        {
        }
    }
}
