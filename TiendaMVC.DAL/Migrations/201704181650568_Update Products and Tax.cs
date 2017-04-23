namespace TiendaMVC.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductsandTax : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Image", c => c.String());
            AddColumn("dbo.Products", "Category_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Tax_Id");
            CreateIndex("dbo.Products", "Category_Id");
            AddForeignKey("dbo.Products", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "Tax_Id", "dbo.Taxes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Tax_Id", "dbo.Taxes");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropIndex("dbo.Products", new[] { "Tax_Id" });
            DropColumn("dbo.Products", "Category_Id");
            DropColumn("dbo.Products", "Image");
        }
    }
}
