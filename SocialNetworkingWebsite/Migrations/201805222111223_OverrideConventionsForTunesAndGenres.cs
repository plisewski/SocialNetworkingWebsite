namespace SocialNetworkingWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForTunesAndGenres : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tunes", "Artist_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tunes", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Tunes", new[] { "Artist_Id" });
            DropIndex("dbo.Tunes", new[] { "Genre_Id" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Tunes", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Tunes", "Artist_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Tunes", "Genre_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Tunes", "Artist_Id");
            CreateIndex("dbo.Tunes", "Genre_Id");
            AddForeignKey("dbo.Tunes", "Artist_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tunes", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tunes", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Tunes", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tunes", new[] { "Genre_Id" });
            DropIndex("dbo.Tunes", new[] { "Artist_Id" });
            AlterColumn("dbo.Tunes", "Genre_Id", c => c.Byte());
            AlterColumn("dbo.Tunes", "Artist_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Tunes", "Venue", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            CreateIndex("dbo.Tunes", "Genre_Id");
            CreateIndex("dbo.Tunes", "Artist_Id");
            AddForeignKey("dbo.Tunes", "Genre_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.Tunes", "Artist_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
