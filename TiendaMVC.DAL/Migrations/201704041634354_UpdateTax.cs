namespace TiendaMVC.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTax : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taxes", "Name", c => c.String());
            AddColumn("dbo.Taxes", "Value", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Taxes", "Value");
            DropColumn("dbo.Taxes", "Name");
        }
    }
}
