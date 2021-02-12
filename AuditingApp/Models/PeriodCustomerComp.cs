using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class PeriodCustomerComp
    {
        public int PeriodId { get; set; }
        public int CustomerId { get; set; }
        public int CurrentState { get; set; }
        public DateTime SaveDate { get; set; }

        public CustomerComp CustomerComp
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