using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"oi.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int columnCount = xlRange.Columns.Count;

            for(int i = 1; i <= rowCount; i++)
            {
                for(int j = 1; j <= columnCount; j++)
                {
                    if(j == 1)
                    {
                        Console.Write("\r\n");
                    }
                    if(xlRange.Cells[i,j] != null && xlRange.Cells[i,j].Value2 != null)
                    {
                        Console.Write(xlRange.Cells[i,j].Value2.ToString() + "\t");
                    }
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
