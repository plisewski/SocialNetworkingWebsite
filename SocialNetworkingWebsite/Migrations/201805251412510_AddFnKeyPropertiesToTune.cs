namespace SocialNetworkingWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFnKeyPropertiesToTune : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tunes", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tunes", new[] { "Artist_Id" });
            RenameColumn(table: "dbo.Tunes", name: "Genre_Id", newName: "GenreId");
            RenameIndex(table: "dbo.Tunes", name: "IX_Genre_Id", newName: "IX_GenreId");
            AddColumn("dbo.Tunes", "ArtistIs", c => c.String(nullable: false));
            AlterColumn("dbo.Tunes", "Artist_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Tunes", "Artist_Id");
            AddForeignKey("dbo.Tunes", "Artist_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tunes", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tunes", new[] { "Artist_Id" });
            AlterColumn("dbo.Tunes", "Artist_Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Tunes", "ArtistIs");
            RenameIndex(table: "dbo.Tunes", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.Tunes", name: "GenreId", newName: "Genre_Id");
            CreateIndex("dbo.Tunes", "Artist_Id");
            AddForeignKey("dbo.Tunes", "Artist_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
