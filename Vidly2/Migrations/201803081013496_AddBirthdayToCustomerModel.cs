namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayToCustomerModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Birthday");
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime());
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthday");
        }
    }
}
