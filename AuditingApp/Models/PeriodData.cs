using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class PeriodData
    {
        public int PeriodId { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public double DataValue { get; set; }
        public DateTime CreateDate { get; set; }
        public int SchemaId { get; set; }
        public DateTime DataEntranceDate { get; set; }

        public Period Period
        {
            get => default;
            set
            {
            }
        }
    }
}