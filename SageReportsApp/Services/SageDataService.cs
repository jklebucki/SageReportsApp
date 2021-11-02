using Microsoft.Data.SqlClient;
using SageReportsApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace SageReportsApp.Services
{
    public class SageDataService
    {
        private readonly string _connectionString;
        public SageDataService(string connectionString)
        {
            _connectionString = connectionString;
        }

        private static string PrepareQueryString(int registerType, int year)
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
                using (SqlConnection connection = new(_connectionString))
                {
                    using (SqlCommand command = new(PrepareQueryString(registerType, year), connection))
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

        public async Task<List<SageVatRegister>> GetVatRegisterDataAsync(int registerType, int year)
        {
            try
            {
                using (SqlConnection connection = new(_connectionString))
                {
                    using (SqlCommand command = new(PrepareQueryString(registerType, year), connection))
                    {
                        command.Connection.Open();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
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

        private static List<SageVatRegister> ConvertDatatableToList(DataTable dataTable)
        {
            var vatRegisters = new List<SageVatRegister>();
            foreach (DataRow row in dataTable.Rows)
            {
                vatRegisters.Add(new SageVatRegister
                {
                    ContractorId = row.ItemArray[11].ToString(),
                    ContractorVatId = row.ItemArray[12].ToString(),
                    ContractorName = row.ItemArray[27].ToString(),
                    RegisterName = row.ItemArray[3].ToString(),
                    DocumentShortcut = row.ItemArray[4].ToString(),
                    DocumentNumber = row.ItemArray[8].ToString(),
                    DocumentName = row.ItemArray[22].ToString(),
                    DocumentDescription = row.ItemArray[21].ToString(),
                    OperationDate = (DateTime)row.ItemArray[25],
                    DocumentDate = (DateTime)row.ItemArray[9],
                    IssueDate = (DateTime)row.ItemArray[10],
                    Period = row.ItemArray[14] == DBNull.Value ? null : (DateTime?)row.ItemArray[14],
                    PeriodDate = (DateTime)row.ItemArray[23],
                    Net = decimal.Parse(row.ItemArray[16].ToString()),
                    Vat = decimal.Parse(row.ItemArray[17].ToString()),
                    Gross = decimal.Parse(row.ItemArray[18].ToString()),
                    User = row.ItemArray[20].ToString()
                });
            }
            return vatRegisters;
        }
    }
}
