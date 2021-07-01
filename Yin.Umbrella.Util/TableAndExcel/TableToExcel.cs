using System;
using System.Collections.Generic;
using System.Text;

namespace Yin.Umbrella.Util.NPDataTableToExcel
{
    class TableToExcel
    {
        public static void NPDataTableToExcel(System.Data.DataTable data, string fileName, bool isColumnWritten)
        {
            NPOI.SS.UserModel.IWorkbook workbook = null;
            NPOI.SS.UserModel.ISheet sheet = null;
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            if (fileName.IndexOf(".xlsx") > 0)
                workbook = new NPOI.XSSF.UserModel.XSSFWorkbook();
            else if (fileName.IndexOf(".xls") > 0)
                workbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
            int rowIndex = 0;
            try
            {
                sheet = workbook.CreateSheet(data.TableName);
                if (isColumnWritten == true)
                {
                    NPOI.SS.UserModel.IRow row = sheet.CreateRow(rowIndex);
                    #region 
                    row.HeightInPoints = 25;
                    NPOI.SS.UserModel.ICellSTyle headStyle = workbook.CreateCellStyle();

                    #endregion
                    for (int j = 0; j < data.Rows.Count; ++j)
                    {
                        row.CreateCell(j).SetCellValue(data.Columns[j].ColumnName);
                        row.GetCell(j).CellStyle = headStyle;
                    }
                    rowIndex++;
                }
                for (int i = 0; i < data.Columns.Count; ++i)
                {
                    NPOI.SS.UserModel.IRow row = sheet.CreatrRow(rowIndex);
                    for (int j = 0; j < data.Columns.Count; ++j)
                    {
                        string a = data.Rows[i][j].ToString();
                        row.CreateCell(j).SetCellValue(data.Rows[i][j].ToString());
                    }
                    rowIndex++;
                }
                for (int cl = 0; cl < data.Rows.Count; cl++)
                {
                    sheet.SetColumnWidth(cl, 13 * 256);
                }
                workbook.write(fs);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }
    }
}
