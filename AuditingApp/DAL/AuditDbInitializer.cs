using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuditingApp.Models;

namespace AuditingApp.DAL
{
    public class AuditDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AuditAppContext>
    {
        protected override void Seed(AuditAppContext context)
        {
            new List<Accounts>();
            new List<Table>();
            new List<AuditComp>();
            new List<CustomerComp>();
            new List<Period>();
            new List<Person>();
        }
    }
}