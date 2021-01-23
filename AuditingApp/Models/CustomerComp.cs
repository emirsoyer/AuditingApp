using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class CustomerComp
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PublicTfrs { get; set; }
        public string PrivateBobifrs { get; set; }
        public bool Consolidation { get; set; }
        
    }
}