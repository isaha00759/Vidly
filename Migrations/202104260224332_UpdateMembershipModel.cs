namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "Duration");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Duration", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "Name");
            DropColumn("dbo.MembershipTypes", "DurationInMonths");
        }
    }
}
