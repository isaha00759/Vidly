namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres(Name) VALUES ('Horror')");
            Sql("Insert into Genres(Name) VALUES ('Comedy')");
            Sql("Insert into Genres(Name) VALUES ('Romantic')");
            Sql("Insert into Genres(Name) VALUES ('Action')");
        }
        
        public override void Down()
        {
        }
    }
}
