﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }
        public string TableName { get; set; }
        public int ReportId { get; set; }
        public string ReportCode { get; set; }
        public string ReportDescription { get; set; }
        public int PageId { get; set; }
    }
        
}