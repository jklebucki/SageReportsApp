using System;

namespace SageReportsApp.Models
{
    public class SageVatRegister
    {
        public string ContractorId { get; set; }
        public string ContractorVatId { get; set; }
        public string ContractorName { get; set; }
        public string RegisterName { get; set; }
        public string DocumentShortcut { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDescription { get; set; }
        public DateTime OperationDate { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? Period { get; set; }
        public DateTime PeriodDate { get; set; }
        public decimal Net { get; set; }
        public decimal Vat { get; set; }
        public decimal Gross { get; set; }
        public string User { get; set; }
    }
}
