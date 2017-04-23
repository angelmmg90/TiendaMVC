namespace TiendaMVC.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatefields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "Phone", c => c.String());
            AddColumn("dbo.Addresses", "Country", c => c.String());
            AddColumn("dbo.Addresses", "Province", c => c.String());
            AddColumn("dbo.Addresses", "Location", c => c.String());
            AddColumn("dbo.Addresses", "Street", c => c.String());
            AddColumn("dbo.Addresses", "Street2", c => c.String());
            AddColumn("dbo.Addresses", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Categories", "Parent_Id", c => c.Int());
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "Stock", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Tax_Id", c => c.Int(nullable: false));
            AddColumn("dbo.OrderLines", "Tax", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderLines", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Addresses", "ApplicationUser_Id");
            CreateIndex("dbo.Categories", "Parent_Id");
            AddForeignKey("dbo.Categories", "Parent_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Addresses", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Categories", "Parent_Id", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "Parent_Id" });
            DropIndex("dbo.Addresses", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.OrderLines", "Total");
            DropColumn("dbo.OrderLines", "Tax");
            DropColumn("dbo.Products", "Tax_Id");
            DropColumn("dbo.Products", "Stock");
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Categories", "Parent_Id");
            DropColumn("dbo.Addresses", "ApplicationUser_Id");
            DropColumn("dbo.Addresses", "Street2");
            DropColumn("dbo.Addresses", "Street");
            DropColumn("dbo.Addresses", "Location");
            DropColumn("dbo.Addresses", "Province");
            DropColumn("dbo.Addresses", "Country");
            DropColumn("dbo.Addresses", "Phone");
        }
    }
}
