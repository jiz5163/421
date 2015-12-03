namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncomeAdded2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IncomeName = c.String(),
                        IncomeAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IncomeDate = c.DateTime(nullable: false),
                        ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Incomes", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Incomes", new[] { "ApplicationUserId" });
            DropTable("dbo.Incomes");
        }
    }
}
