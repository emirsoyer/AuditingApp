using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class PeriodSchema
    {
        public int PeriodId { get; set; }
        public int SchemaId { get; set; }
        public DateTime CreateDate { get; set; }

        public SchemaStandard SchemaStandard
        {
            get => default;
            set
            {
            }
        }

        public Period Period
        {
            get => default;
            set
            {
            }
        }
    }
}