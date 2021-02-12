using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class SchemaConciliation
    {
        public int SchemaId { get; set; }
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public double AmountActual { get; set; }
        public double AmountFixed { get; set; }
        public double AmountReport { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DataEntranceDate { get; set; }
        public int PageId { get; set; }

        public SchemaStandard SchemaStandard
        {
            get => default;
            set
            {
            }
        }

        public Conciliation Conciliation
        {
            get => default;
            set
            {
            }
        }
    }
}