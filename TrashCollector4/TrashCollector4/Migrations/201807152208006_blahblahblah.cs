namespace TrashCollector4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blahblahblah : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "AmountDue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "AmountDue", c => c.Double(nullable: false));
        }
    }
}
