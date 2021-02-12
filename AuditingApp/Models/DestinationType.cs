using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class DestinationType
    {
        public int AccountDestinationTypeId { get; set; }
        public string AccountDestinationTypeName { get; set; }

        public Destination Destination
        {
            get => default;
            set
            {
            }
        }
    }
}