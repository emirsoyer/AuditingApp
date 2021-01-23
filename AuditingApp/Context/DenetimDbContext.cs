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
        public DbSet<ReportCode> ReportCodes { get; set; }
        public DbSet<Accounts> AccountsEnumerable { get; set; }
        public DbSet<MizanTable> MizanTables { get; set; }
        public DbSet<AuditComp> AuditComps { get; set; }
        public DbSet<CustomerComp> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}