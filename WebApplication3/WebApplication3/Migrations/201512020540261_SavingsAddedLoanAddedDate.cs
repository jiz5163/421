namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SavingsAddedLoanAddedDate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SavingAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckingName = c.String(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
            AddColumn("dbo.Loans", "LoanDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SavingAccounts", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.SavingAccounts", new[] { "ApplicationUserId" });
            DropColumn("dbo.Loans", "LoanDate");
            DropTable("dbo.SavingAccounts");
        }
    }
}
