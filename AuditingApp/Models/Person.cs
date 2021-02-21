using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AuditingApp.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Adı-Soyadı")]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Ünvan")]
        public string JobTitle { get; set; }
        public int AuditCompId { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Şirket")]
        public string AuditCompName { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "E-Mail Adresi")]
        public string PersonEmail { get; set; }
        [Required(ErrorMessage = "Bu alan doldurulmalıdır.")]
        [Display(Name = "Telefon Numarası")]
        public string PersonPhone { get; set; }
        public int CustomerId { get; set; }
        
    }
}