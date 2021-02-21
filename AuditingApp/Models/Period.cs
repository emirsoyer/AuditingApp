using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Period
    {
        [Key]
        public int PeriodId { get; set; }
        public string PeriodStart { get; set; }
        public string PeriodMiddle { get; set; }
        public string PeriodEnd { get; set; }
        public string PeriodDescription { get; set; }
        public bool IsDataEntryAwaiting { get; set; }
        public int CurrentState { get; set; }
        public DateTime LastModifyDate { get; set; }
        public string LastModifyUser { get; set; }

        public Table Table
        {
            get => default;
            set
            {
            }
        }
    }
}