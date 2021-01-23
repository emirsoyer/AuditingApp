using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class AuditComp
    {
        public int AuditCompId { get; set; }
        public string AuditCompName { get; set; }
        public bool AdminStatus { get; set; }
        public CustomerComp CustomerComps { get; set; }
    }
}