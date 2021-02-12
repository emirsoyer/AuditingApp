using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AuditingApp.Models;

namespace AuditingApp.Context
{
    public class DenetimDbContext:DbContext
    {
        
        public DbSet<Accounts> AccountsEnumerable { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<AuditComp> AuditComps { get; set; }
        public DbSet<CustomerComp> Customers { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Person> PersonEnumerable { get; set; }
        public DbSet<SchemaStandard> Schemas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}