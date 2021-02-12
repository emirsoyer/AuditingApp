using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class SchemaCustomerComp
    {
        public int SchemaId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreateDate { get; set; }
        public int PageId { get; set; }

        public SchemaStandard SchemaStandard
        {
            get => default;
            set
            {
            }
        }

        public CustomerComp CustomerComp
        {
            get => default;
            set
            {
            }
        }
    }
}