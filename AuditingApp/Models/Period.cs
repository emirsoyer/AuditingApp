using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Period
    {
        public int PeriodId { get; set; }
        public string PeriodStart { get; set; }
        public string PeriodMiddle { get; set; }
        public string PeriodEnd { get; set; }
        public string PeriodDescription { get; set; }
        public bool IsDataEntryAwaiting { get; set; }
        public int CurrentState { get; set; }
        public DateTime LastModifyDate { get; set; }
        public string LastModifyUser { get; set; }
        
    }
}