using System;

namespace SageReportsApp.Models
{
    public class SageVatRegister
    {
        public string RegisterName { get; set; }
        public string DocumentShortcut { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }
        public decimal Net { get; set; }
        public decimal Vat { get; set; }
        public decimal Gross { get; set; }
    }
}
