using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditingApp.Models
{
    public class TableDetail
    {
        public int TableId { get; set; }
        public bool IsSubTable { get; set; }
        public int SubTableId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public bool HasCalculation { get; set; }
        public string RowType { get; set; }
        public string BackColor { get; set; }
        public string ForeColor { get; set; }
        public string FontSize { get; set; }
        public string LineHeight { get; set; }
        public string HorizontalAlign { get; set; }
        public string VerticalAlign { get; set; }
        public string Font { get; set; }


    }
}