using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class AuditComp 
    {
        [Key]
        public int AuditCompId { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Denetçi Kuruluş Adı")]
        public string AuditCompName { get; set; }
        public bool AdminStatus { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Mesleki Teşekkül")]
        public string OrganizationMembership { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Mesleki Teşekkül No")]
        public string OrganizationMembershipNumber { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Vergi No")]
        public string TaxNumber { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Vergi Dairesi")]
        public string TaxOffice { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Kuruluş Tarihi")]
        public DateTime EstablishmentDate { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Ticaret Sicil No")]
        public string TradeRegistryNumber { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Mersis No")]
        public string MersisId { get; set; }
        public virtual List<BoardMember> BoardMembers { get; set; }
        public virtual List<Partner> Partners { get; set; }
        public virtual List<HeadAuditor> HeadAuditors { get; set; }
        public virtual List<AuditStaffMembers> AuditStaffMembers { get; set; }

        
    }

    public class BoardMember : AuditComp
    {
        public string MemberName { get; set; }

        public Person Person
        {
            get => default;
            set
            {
            }
        }
    }
    public class Partner : AuditComp
    {
        public string PartnerName { get; set; }

        public Person Person
        {
            get => default;
            set
            {
            }
        }
    }
    public class HeadAuditor : AuditComp
    {
        public string HeadAuditorName { get; set; }
        public string Jurisdiction { get; set; }

        public Person Person
        {
            get => default;
            set
            {
            }
        }
    }
    public class AuditStaffMembers : AuditComp
    {
        public string StaffName { get; set; }
        public string StaffTitle { get; set; }

        public Person Person
        {
            get => default;
            set
            {
            }
        }
    }
}