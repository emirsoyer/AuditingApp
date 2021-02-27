using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Accounts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }
        [Display(Name = "Hesap Kodu")]
        public string AccountCode { get; set; }
        [Display(Name = "Hesap Adı")]
        public string AccountName { get; set; }
        [Display(Name = "Rapor Kod")]
        public string ReportCode { get; set; }
        [Display(Name = "Rapor Adı")]
        public string ReportDescription { get; set; }
        public int? SchemaId { get; set; }
        public string CustomerType { get; set; }
        private int _coefficient;

        [DefaultValue(true)]
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

        public virtual CustomerComp CustomerComp
        {
            get => default;
            set
            {
            }
        }

        public virtual Table Table
        {
            get => default;
            set
            {
            }
        }
    }

}