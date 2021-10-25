using SageReportsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageReportsApp.Services
{
    public class GetSageDataService
    {
        public string _connectionString { get; protected set; }
        public GetSageDataService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<SageVatRegister> GetVatRegisterData(int registerType)
        {
            var registerData = new List<SageVatRegister>();
            return registerData;
        }
    }
}
