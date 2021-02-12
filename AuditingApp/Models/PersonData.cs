using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class PersonData 
    {
        public int PeriodId { get; set; }
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public int DataValue { get; set; }
        public int SchemaId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DataEntranceDate { get; set; }
        public string CreateUserId { get; set; }
        public string DataEntranceUserId { get; set; }

        public Person Person
        {
            get => default;
            set
            {
            }
        }
    }
}