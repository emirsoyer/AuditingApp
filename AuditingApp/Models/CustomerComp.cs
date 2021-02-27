using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Web;

namespace AuditingApp.Models
{
    public class CustomerComp
    {
        [Key]
        public string CustomerId { get; set; }
        [Required]
        [Display(Name = "Kuruluş İsmi")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Raporlama Türüne 'Bobi' ya da 'Tfrs' yazınız.")]
        [Display(Name = "Raporlama Türü")]
        public CstmrType CustomerType { get; set; }
        public int CustomerTypeId { get; set; }
        [Required]
        [Display(Name = "Konsolidasyon")]
        public bool Consolidation { get; set; }
        [Required]
        [Display(Name = "Açıklama")]
        public string CustomerDescription { get; set; }
        [Required]
        [Display(Name = "Mesleki Teşekkül")]
        public string OrganizationMembership { get; set; }
        [Required]
        [Display(Name = "Taahhüt Edilen Sermaye")]
        public float ObligatedCapital { get; set; }
        [Required]
        [Display(Name = "Ödenen Sermaye")]
        public float PaidCapital { get; set; }
        [Required]
        [Display(Name = "Vergi No")]
        public string TaxNumber { get; set; }
        [Required]
        [Display(Name = "Vergi Dairesi")]
        public string TaxOffice { get; set; }
        [Required]
        [Display(Name = "Kuruluş Tarihi")]
        public DateTime EstablishmentDate { get; set; }
        [Required]
        [Display(Name = "Faaliyet Kodu")]
        public string ActivityCode { get; set; }
        [Required]
        [Display(Name = "Sicil No")]
        public string RegistryCode { get; set; }
        [Required]
        [Display(Name = "Hukuki Mahiyeti")]
        public string LegalNature { get; set; } //LTD or A.S Company 
        [Required]
        [Display(Name = "Ticaret/Oda Sicil No")]
        public string TradeRegistryNumber { get; set; }
        [Required]
        [Display(Name = "Mesleki Teşekkül Üye No")]
        public string OrganizationMembershipNumber { get; set; }
        [Required]
        [Display(Name = "Mersis No")]
        public string MersisId { get; set; }
        
    }

    public enum CstmrType
    {
        Bobi,
        Tfrs
    }
}