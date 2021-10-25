using Microsoft.Data.SqlClient;
using SageReportsApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace SageReportsApp.Services
{
    public class SageDataService
    {
        public string _connectionString { get; protected set; }
        public SageDataService(string connectionString)
        {
            _connectionString = connectionString;
        }

        private string PrepareQueryString(int registerType, int year)
        {
            try
            {
                var queryString = QueryFileService.ReadQueryFile(Path.Combine(Directory.GetCurrentDirectory(), "Queries", "SalesAndPurchase.sql"));
                return queryString.Replace(":regType", registerType.ToString()).Replace(":year", year.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }

        }

        public List<SageVatRegister> GetVatRegisterData(int registerType, int year)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(PrepareQueryString(registerType, year), connection))
                    {
                        command.Connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            var dt = new DataTable();
                            dt.Load(reader);
                            return ConvertDatatableToList(dt);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
            }

        }

        private List<SageVatRegister> ConvertDatatableToList(DataTable dataTable)
        {
            var vatRegisters = new List<SageVatRegister>();
            foreach (DataRow row in dataTable.Rows)
            {
                vatRegisters.Add(new SageVatRegister
                {
                    RegisterName = row.ItemArray[3].ToString(),
                    DocumentShortcut = row.ItemArray[4].ToString(),
                    DocumentNumber = row.ItemArray[8].ToString()
                });
            }
            return vatRegisters;
        }
    }
}
