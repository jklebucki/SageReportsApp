using System;
using System.IO;
using System.Text;

namespace SageReportsApp.Services
{
    public class QueryFileService
    {
        public static string ReadQueryFile(string filePath)
        {
            if (File.Exists(filePath))
                using (StreamReader streamReader = new(filePath, Encoding.UTF8))
                {
                    try
                    {
                        return streamReader.ReadToEnd();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                    }
                }
            else
            {
                throw new Exception($"File {filePath} not exist!");
            }
        }
    }
}
