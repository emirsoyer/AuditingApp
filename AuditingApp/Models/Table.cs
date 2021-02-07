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
        public int ReportId { get; set; }
        public string ReportDescription { get; set; }
        public int PageId { get; set; }
    }
        
}