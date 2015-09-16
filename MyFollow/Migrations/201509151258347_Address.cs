namespace MyFollow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Street1 = c.String(nullable: false, maxLength: 128),
                        Street2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Street1);
            
            AddColumn("dbo.ProductOwners", "Address", c => c.String());
            DropColumn("dbo.ProductOwners", "Address1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductOwners", "Address1", c => c.String());
            DropColumn("dbo.ProductOwners", "Address");
            DropTable("dbo.Address");
        }
    }
}
