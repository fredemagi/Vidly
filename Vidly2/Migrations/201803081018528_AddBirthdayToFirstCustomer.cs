namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayToFirstCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday='1974-03-01' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
