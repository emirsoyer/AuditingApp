﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class SchemaStandard
    {
        public int SchemaId { get; set; }
        public string SchemaName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatorId { get; set; }
    }
}