using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Conciliation
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public string Period { get; set; }
        public int PeriodId { get; set; }
        public double AmountActual { get; set; }
        public double AmountFixed { get; set; }
        public double AmountReport { get; set; }

        public Table Table
        {
            get => default;
            set
            {
            }
        }
    }
}