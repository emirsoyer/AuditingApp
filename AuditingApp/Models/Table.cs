using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Table
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public bool HasCalculation { get; set; }

    }
        
}