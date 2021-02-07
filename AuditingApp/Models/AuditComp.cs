using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class AuditComp
    {
        public int AuditCompId { get; set; }
        public string AuditCompName { get; set; }
        public bool AdminStatus { get; set; }
        public bool IsSubCompany { get; set; }
        public CustomerComp CustomerComps { get; set; }
        public string AuditingCompanyDescription { get; set; }
        public string OrganizationMembership { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string ActivityCode { get; set; }
        public string RegistryCode { get; set; }
        public string LegalNature { get; set; } //LTD or A.S Company 
        public string TradeRegistryNumber { get; set; }
        public string OrganizationMembershipNumber { get; set; }
        public string MersisId { get; set; }
        public virtual List<BoardMember> BoardMembers { get; set; }
        public virtual List<Partner> Partners { get; set; }
        public virtual List<HeadAuditor> HeadAuditors { get; set; }
        public virtual List<AuditStaffMembers> AuditStaffMembers { get; set; }


    }

    public class BoardMember : AuditComp
    {
        public string MemberName { get; set; }
    }
    public class Partner : AuditComp
    {
        public string PartnerName { get; set; }
    }
    public class HeadAuditor : AuditComp
    {
        public string HeadAuditorName { get; set; }
        public string Jurisdiction { get; set; }
    }
    public class AuditStaffMembers : AuditComp
    {
        public string StaffName { get; set; }
        public string StaffTitle { get; set; }
    }
}