namespace SocialNetworkingWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFnKeyPropertiesToTune1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tunes", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tunes", new[] { "Artist_Id" });
            RenameColumn(table: "dbo.Tunes", name: "Artist_Id", newName: "ArtistId");
            AlterColumn("dbo.Tunes", "ArtistId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Tunes", "ArtistId");
            AddForeignKey("dbo.Tunes", "ArtistId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.Tunes", "ArtistIs");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tunes", "ArtistIs", c => c.String(nullable: false));
            DropForeignKey("dbo.Tunes", "ArtistId", "dbo.AspNetUsers");
            DropIndex("dbo.Tunes", new[] { "ArtistId" });
            AlterColumn("dbo.Tunes", "ArtistId", c => c.String(maxLength: 128));
            RenameColumn(table: "dbo.Tunes", name: "ArtistId", newName: "Artist_Id");
            CreateIndex("dbo.Tunes", "Artist_Id");
            AddForeignKey("dbo.Tunes", "Artist_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
