namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTypesofMembership : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO MembershipTypes (Id, TypesOfMembership) VALUES (1,'Pay as You Go')");
            //Sql("INSERT INTO MembershipTypes (Id, TypesOfMembership) VALUES (2,'Monthly')");
            //Sql("INSERT INTO MembershipTypes (Id, TypesOfMembership) VALUES (3,'Quarterly')");
            //Sql("INSERT INTO MembershipTypes (Id, TypesOfMembership) VALUES (4,'Annual')");

            Sql("UPDATE MembershipTypes SET TypesOfMembership = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET TypesOfMembership = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET TypesOfMembership = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET TypesOfMembership = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
