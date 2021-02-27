namespace AuditingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        AccountCode = c.String(),
                        AccountName = c.String(),
                        ReportCode = c.String(),
                        ReportDescription = c.String(),
                        SchemaId = c.Int(),
                        CustomerType = c.String(),
                        CoefficientNum = c.Int(nullable: false),
                        CustomerComp_CustomerId = c.String(maxLength: 128),
                        Table_TableId = c.Int(),
                    })
                .PrimaryKey(t => t.AccountId)
                .ForeignKey("dbo.CustomerComp", t => t.CustomerComp_CustomerId)
                .ForeignKey("dbo.Table", t => t.Table_TableId)
                .Index(t => t.CustomerComp_CustomerId)
                .Index(t => t.Table_TableId);
            
            CreateTable(
                "dbo.CustomerComp",
                c => new
                    {
                        CustomerId = c.String(nullable: false, maxLength: 128),
                        CustomerName = c.String(),
                        CustomerType = c.String(),
                        CustomerTypeId = c.Int(nullable: false),
                        Consolidation = c.Boolean(nullable: false),
                        CustomerDescription = c.String(),
                        OrganizationMembership = c.String(),
                        ObligatedCapital = c.Single(nullable: false),
                        PaidCapital = c.Single(nullable: false),
                        TaxNumber = c.String(),
                        TaxOffice = c.String(),
                        EstablishmentDate = c.DateTime(nullable: false),
                        ActivityCode = c.String(),
                        RegistryCode = c.String(),
                        LegalNature = c.String(),
                        TradeRegistryNumber = c.String(),
                        OrganizationMembershipNumber = c.String(),
                        MersisId = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Table",
                c => new
                    {
                        TableId = c.Int(nullable: false, identity: true),
                        TableName = c.String(),
                        ReportId = c.Int(nullable: false),
                        ReportCode = c.String(),
                        ReportDescription = c.String(),
                        PageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TableId);
            
            CreateTable(
                "dbo.AuditComp",
                c => new
                    {
                        AuditCompId = c.Int(nullable: false, identity: true),
                        AuditCompName = c.String(nullable: false),
                        AdminStatus = c.Boolean(nullable: false),
                        OrganizationMembership = c.String(nullable: false),
                        OrganizationMembershipNumber = c.String(nullable: false),
                        TaxNumber = c.String(nullable: false),
                        TaxOffice = c.String(nullable: false),
                        EstablishmentDate = c.DateTime(nullable: false),
                        TradeRegistryNumber = c.String(nullable: false),
                        MersisId = c.String(nullable: false),
                        StaffName = c.String(),
                        StaffTitle = c.String(),
                        MemberName = c.String(),
                        HeadAuditorName = c.String(),
                        Jurisdiction = c.String(),
                        PartnerName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Person_PersonId = c.Int(),
                        Person_PersonId1 = c.Int(),
                        Person_PersonId2 = c.Int(),
                        Person_PersonId3 = c.Int(),
                        AuditComp_AuditCompId = c.Int(),
                        AuditComp_AuditCompId1 = c.Int(),
                        CustomerComp_CustomerId = c.String(maxLength: 128),
                        AuditComp_AuditCompId2 = c.Int(),
                        AuditComp_AuditCompId3 = c.Int(),
                    })
                .PrimaryKey(t => t.AuditCompId)
                .ForeignKey("dbo.Person", t => t.Person_PersonId)
                .ForeignKey("dbo.Person", t => t.Person_PersonId1)
                .ForeignKey("dbo.Person", t => t.Person_PersonId2)
                .ForeignKey("dbo.Person", t => t.Person_PersonId3)
                .ForeignKey("dbo.AuditComp", t => t.AuditComp_AuditCompId)
                .ForeignKey("dbo.AuditComp", t => t.AuditComp_AuditCompId1)
                .ForeignKey("dbo.CustomerComp", t => t.CustomerComp_CustomerId)
                .ForeignKey("dbo.AuditComp", t => t.AuditComp_AuditCompId2)
                .ForeignKey("dbo.AuditComp", t => t.AuditComp_AuditCompId3)
                .Index(t => t.Person_PersonId)
                .Index(t => t.Person_PersonId1)
                .Index(t => t.Person_PersonId2)
                .Index(t => t.Person_PersonId3)
                .Index(t => t.AuditComp_AuditCompId)
                .Index(t => t.AuditComp_AuditCompId1)
                .Index(t => t.CustomerComp_CustomerId)
                .Index(t => t.AuditComp_AuditCompId2)
                .Index(t => t.AuditComp_AuditCompId3);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        PersonName = c.String(nullable: false),
                        JobTitle = c.String(nullable: false),
                        AuditCompId = c.Int(nullable: false),
                        AuditCompName = c.String(nullable: false),
                        PersonEmail = c.String(nullable: false),
                        PersonPhone = c.String(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Period",
                c => new
                    {
                        PeriodId = c.Int(nullable: false, identity: true),
                        PeriodStart = c.String(),
                        PeriodMiddle = c.String(),
                        PeriodEnd = c.String(),
                        PeriodDescription = c.String(),
                        IsDataEntryAwaiting = c.Boolean(nullable: false),
                        CurrentState = c.Int(nullable: false),
                        LastModifyDate = c.DateTime(nullable: false),
                        LastModifyUser = c.String(),
                        Table_TableId = c.Int(),
                    })
                .PrimaryKey(t => t.PeriodId)
                .ForeignKey("dbo.Table", t => t.Table_TableId)
                .Index(t => t.Table_TableId);
            
            CreateTable(
                "dbo.SchemaStandard",
                c => new
                    {
                        SchemaId = c.Int(nullable: false, identity: true),
                        SchemaName = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatorId = c.String(),
                    })
                .PrimaryKey(t => t.SchemaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Period", "Table_TableId", "dbo.Table");
            DropForeignKey("dbo.AuditComp", "AuditComp_AuditCompId3", "dbo.AuditComp");
            DropForeignKey("dbo.AuditComp", "AuditComp_AuditCompId2", "dbo.AuditComp");
            DropForeignKey("dbo.AuditComp", "CustomerComp_CustomerId", "dbo.CustomerComp");
            DropForeignKey("dbo.AuditComp", "AuditComp_AuditCompId1", "dbo.AuditComp");
            DropForeignKey("dbo.AuditComp", "AuditComp_AuditCompId", "dbo.AuditComp");
            DropForeignKey("dbo.AuditComp", "Person_PersonId3", "dbo.Person");
            DropForeignKey("dbo.AuditComp", "Person_PersonId2", "dbo.Person");
            DropForeignKey("dbo.AuditComp", "Person_PersonId1", "dbo.Person");
            DropForeignKey("dbo.AuditComp", "Person_PersonId", "dbo.Person");
            DropForeignKey("dbo.Accounts", "Table_TableId", "dbo.Table");
            DropForeignKey("dbo.Accounts", "CustomerComp_CustomerId", "dbo.CustomerComp");
            DropIndex("dbo.Period", new[] { "Table_TableId" });
            DropIndex("dbo.AuditComp", new[] { "AuditComp_AuditCompId3" });
            DropIndex("dbo.AuditComp", new[] { "AuditComp_AuditCompId2" });
            DropIndex("dbo.AuditComp", new[] { "CustomerComp_CustomerId" });
            DropIndex("dbo.AuditComp", new[] { "AuditComp_AuditCompId1" });
            DropIndex("dbo.AuditComp", new[] { "AuditComp_AuditCompId" });
            DropIndex("dbo.AuditComp", new[] { "Person_PersonId3" });
            DropIndex("dbo.AuditComp", new[] { "Person_PersonId2" });
            DropIndex("dbo.AuditComp", new[] { "Person_PersonId1" });
            DropIndex("dbo.AuditComp", new[] { "Person_PersonId" });
            DropIndex("dbo.Accounts", new[] { "Table_TableId" });
            DropIndex("dbo.Accounts", new[] { "CustomerComp_CustomerId" });
            DropTable("dbo.SchemaStandard");
            DropTable("dbo.Period");
            DropTable("dbo.Person");
            DropTable("dbo.AuditComp");
            DropTable("dbo.Table");
            DropTable("dbo.CustomerComp");
            DropTable("dbo.Accounts");
        }
    }
}
