namespace TrashCollector4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addadditionalpickupbool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsAdditionalPickedUp", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsAdditionalPickedUp");
        }
    }
}
