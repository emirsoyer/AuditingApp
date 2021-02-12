using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string JobTitle { get; set; }
        public int AuditCompId { get; set; }
        public string AuditCompName { get; set; }
        public string PersonEmail { get; set; }
        public string PersonPhone { get; set; }
        public int CustomerId { get; set; }
        public string Gender { get; set; }

        public BoardMember BoardMember
        {
            get => default;
            set
            {
            }
        }

        public HeadAuditor HeadAuditor
        {
            get => default;
            set
            {
            }
        }

        public AuditStaffMembers AuditStaffMembers
        {
            get => default;
            set
            {
            }
        }

        public Partner Partner
        {
            get => default;
            set
            {
            }
        }
    }
}