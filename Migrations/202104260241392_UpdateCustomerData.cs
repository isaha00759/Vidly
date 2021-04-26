namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerData : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers set DOB='28/10/1993' where Id=1");
            Sql("Update Customers set DOB='29/11/1993' where Id=3");
            Sql("Update Customers set DOB='20/08/1993' where Id=5");
        }
        
        public override void Down()
        {
        }
    }
}
