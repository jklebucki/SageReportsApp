﻿using Microsoft.Data.SqlClient;
using SageReportsApp.Data;
using SageReportsApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SageReportsApp.Services
{
    public class SageDataService
    {
        private readonly string _connectionString;
        private readonly AppDbContext _appDbContext;
        public SageDataService(string connectionString, AppDbContext appDbContext)
        {
            _connectionString = connectionString;
            _appDbContext = appDbContext;
        }

        private string PrepareQueryString(int registerType, int year)
        {
            try
            {
                var queryString = QueryFileService.ReadQueryFile(Path.Combine(Directory.GetCurrentDirectory(), "Queries", "SalesAndPurchase.sql"));
                var relatedFirmsIds = _appDbContext.RelatedFirms
                    .Where(r => !string.IsNullOrEmpty(r.ErpSystemId) && r.VatId == "1")
                    .Select(f => f.ErpSystemId).Distinct()
                    .ToArray();
                return queryString
                    .Replace(":regType", registerType.ToString())
                    .Replace(":year", year.ToString())
                    .Replace(":firms", string.Join(",", relatedFirmsIds));
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
                    OperationDate = row.ItemArray[25] == DBNull.Value ? new DateTime(9999, 1, 1) : (DateTime)row.ItemArray[25],
                    DocumentDate = row.ItemArray[9] == DBNull.Value ? new DateTime(9999, 1, 1) : (DateTime)row.ItemArray[9],
                    IssueDate = row.ItemArray[10] == DBNull.Value ? new DateTime(9999, 1, 1) : (DateTime)row.ItemArray[10],
                    Period = row.ItemArray[14] == DBNull.Value ? null : (DateTime?)row.ItemArray[14],
                    PeriodDate = row.ItemArray[23] == DBNull.Value ? new DateTime(9999, 1, 1) : (DateTime)row.ItemArray[23],
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
