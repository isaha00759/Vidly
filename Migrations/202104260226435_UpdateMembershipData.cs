namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipData : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set DurationInMonths=0,Name='Free' where Id=1");
            Sql("Update MembershipTypes set DurationInMonths=1,Name='Pay As You Go' where Id=2");
            Sql("Update MembershipTypes set DurationInMonths=3,Name='Quaterly' where Id=3");
            Sql("Update MembershipTypes set DurationInMonths=12,Name='Yearly' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
