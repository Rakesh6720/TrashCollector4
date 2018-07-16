namespace TrashCollector4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class additionalpickupday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "AdditionalPickupDay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "AdditionalPickupDay");
        }
    }
}
