using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class ReportCode
    {
        public string CodeId { get; set; }
        public string CodeName { get; set; }

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