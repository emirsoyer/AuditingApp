using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using AuditingApp.Models;

namespace AuditingApp.DAL
{
    public class AuditAppContext:DbContext
    {
        public AuditAppContext() : base("AuditAppContext")
        {
            Database.SetInitializer<AuditAppContext>(new MigrateDatabaseToLatestVersion<AuditAppContext,AuditingApp.Migrations.Configuration>());
        }
        public DbSet<Accounts> AccountsEnumerable { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<AuditComp> AuditComps { get; set; }
        public DbSet<CustomerComp> Customers { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Person> PersonEnumerable { get; set; }
        public DbSet<SchemaStandard> Schemas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Accounts>().Property(p => p.AccountId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}