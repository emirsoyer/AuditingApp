using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class SchemaAccounts
    {
        public int SchemaId { get; set; }
        public int AccountId { get; set; }
        public DateTime CreateDate { get; set; }
        public int PageId { get; set; }

        public SchemaStandard SchemaStandard
        {
            get => default;
            set
            {
            }
        }

        public Accounts Accounts
        {
            get => default;
            set
            {
            }
        }
    }
}