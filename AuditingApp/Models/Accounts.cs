using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Accounts
    {
        public int AccountId { get; set; }
        public int AccountCode { get; set; }
        public string AccountName { get; set; }
        public string AccountDescription { get; set; }
        public short AccountPositive { get; set; }
        public short AccountNegative { get; set; }
        public bool ConvertSign { get; set; }
        public string CustomerType { get; set; }
        public bool Character { get; set; }


    }
}