namespace AuditingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerComp", "CustomerName", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerComp", "CustomerType", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerComp", "CustomerDescription", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerComp", "OrganizationMembership", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerComp", "TaxNumber", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerComp", "TaxOffice", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerComp", "ActivityCode", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerComp", "RegistryCode", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerComp", "LegalNature", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerComp", "TradeRegistryNumber", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerComp", "OrganizationMembershipNumber", c => c.String(nullable: false));
            AlterColumn("dbo.CustomerComp", "MersisId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerComp", "MersisId", c => c.String());
            AlterColumn("dbo.CustomerComp", "OrganizationMembershipNumber", c => c.String());
            AlterColumn("dbo.CustomerComp", "TradeRegistryNumber", c => c.String());
            AlterColumn("dbo.CustomerComp", "LegalNature", c => c.String());
            AlterColumn("dbo.CustomerComp", "RegistryCode", c => c.String());
            AlterColumn("dbo.CustomerComp", "ActivityCode", c => c.String());
            AlterColumn("dbo.CustomerComp", "TaxOffice", c => c.String());
            AlterColumn("dbo.CustomerComp", "TaxNumber", c => c.String());
            AlterColumn("dbo.CustomerComp", "OrganizationMembership", c => c.String());
            AlterColumn("dbo.CustomerComp", "CustomerDescription", c => c.String());
            AlterColumn("dbo.CustomerComp", "CustomerType", c => c.String());
            AlterColumn("dbo.CustomerComp", "CustomerName", c => c.String());
        }
    }
}
