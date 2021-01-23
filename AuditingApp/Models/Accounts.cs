using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Accounts
    {
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public short MultiplicationNum1
        {
            get { return -1; }
        }
        public short MultiplicationNum2
        {
            get { return 1; }
        }
    }
}