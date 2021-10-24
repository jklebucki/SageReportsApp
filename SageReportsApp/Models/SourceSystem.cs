using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageReportsApp.Models
{
    public class SourceSystem
    {
        public int SourceSystemId { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string DbName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
