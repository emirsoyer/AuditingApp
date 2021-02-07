using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string AccountDestinationType { get; set; }
        public int AccountId { get; set; }
        public int CustomerTypeId { get; set; }
        
    }
}