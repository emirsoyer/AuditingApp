using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Accounts
    {
        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string AccountDescription { get; set; }
        public int SchemaId { get; set; }
        public bool ConvertSign { get; set; }
        public string CustomerType { get; set; }
        public bool Character { get; set; }
        private int _coefficient;
        public int CoefficientNum
        {
            get => _coefficient;
            set
            {
                if (value == 1 || value == -1)
                {
                    _coefficient = value;
                }
            }
        }

        public CustomerComp CustomerComp
        {
            get => default;
            set
            {
            }
        }

        public Table Table
        {
            get => default;
            set
            {
            }
        }
    }

}