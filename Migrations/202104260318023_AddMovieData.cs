namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieData : DbMigration
    {
        public override void Up()
        {

            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,Stock,Genre_Id) VALUES ('Nun','05/04/2019','06/04/2019',15,13)");
            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,Stock,Genre_Id) VALUES ('Hera Pheri','05/04/2000','06/04/2019',15,14)");
            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,Stock,Genre_Id) VALUES ('Phir Hera Pheri','05/04/2010','06/04/2019',15,14)");
            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,Stock,Genre_Id) VALUES ('Notebook','05/04/2018','06/04/2019',15,15)");
            Sql("Insert into Movies(Name,ReleaseDate,DateAdded,Stock,Genre_Id) VALUES ('John Wick','05/04/2017','06/04/2019',15,16)");
        }
        
        public override void Down()
        {
        }
    }
}
