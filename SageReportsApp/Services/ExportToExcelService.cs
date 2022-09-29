using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace SageReportsApp.Services
{
    public class ExportToExcelService
    {
        public static IWorkbook AddSheetToWorkbook<T>(IWorkbook workbook, List<T> data, string sheetName)
        {
            ISheet excelSheet = workbook.CreateSheet(sheetName);
            IRow row;
            ICellStyle dateCellStyle = workbook.CreateCellStyle();
            IDataFormat dateFormat = workbook.CreateDataFormat();
            dateCellStyle.DataFormat = dateFormat.GetFormat("yyyy-MM-dd");
            ICellStyle doubleCellStyle = workbook.CreateCellStyle();
            doubleCellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00");

            int rowCounter = 0;
            row = excelSheet.CreateRow(rowCounter);
            int columnCounter = 0;
            foreach (PropertyInfo prop in data[0].GetType().GetProperties())
            {
                row.CreateCell(columnCounter).SetCellValue(prop.Name);
                columnCounter++;
            }
            rowCounter++;

            foreach (var item in data)
            {
                row = excelSheet.CreateRow(rowCounter);
                columnCounter = 0;
                foreach (PropertyInfo prop in item.GetType().GetProperties())
                {
                    if (rowCounter > 0)
                    {
                        var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                        if (type == typeof(decimal) || type == typeof(double) || type == typeof(int))
                        {
                            row.CreateCell(columnCounter).SetCellValue(Convert.ToDouble(prop.GetValue(item, null)));
                            var c = row.GetCell(columnCounter);
                            c.CellStyle = doubleCellStyle;
                        }
                        else if (type == typeof(DateTime))
                        {
                            var val = prop.GetValue(item, null);
                            if (val != null)
                                row.CreateCell(columnCounter).SetCellValue((DateTime)val);
                            else
                                row.CreateCell(columnCounter);
                            var c = row.GetCell(columnCounter);
                            c.CellStyle = dateCellStyle;
                        }
                        else
                        {
                            var val = prop.GetValue(item, null);
                            row.CreateCell(columnCounter).SetCellValue(val == null ? "" : val.ToString());
                        }

                    }
                    columnCounter++;
                }
                rowCounter++;
            }
            return workbook;
        }
    }
}
