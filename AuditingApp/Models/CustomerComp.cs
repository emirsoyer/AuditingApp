using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace AuditingApp.Models
{
    public class CustomerComp
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public int CustomerTypeId { get; set; }
        public bool Consolidation { get; set; }
        public string CustomerDescription { get; set; }
        public string OrganizationMembership { get; set; }
        public float ObligatedCapital { get; set; }
        public float PaidCapital { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string ActivityCode { get; set; }
        public string RegistryCode { get; set; }
        public string LegalNature { get; set; } //LTD or A.S Company 
        public string TradeRegistryNumber { get; set; }
        public string OrganizationMembershipNumber { get; set; }
        public string MersisId { get; set; }
        
        
        
        
        
    }
}