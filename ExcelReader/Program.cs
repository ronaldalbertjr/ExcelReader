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
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocume‌​nts) + "\\oi.xlsx";
        static Answer[] answers;
        static Points[] orderedPoints;
        static Answer currentPerson;
        static void Main(string[] args)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int columnCount = xlRange.Columns.Count;
            answers = new Answer[rowCount];
            for(int i = 2; i <= rowCount; i++)
            {
                for(int j = 1; j <= columnCount; j++)
                {
                    if(j == 1)
                    {
                        answers[i - 2] = new Answer();
                    }

                    if(xlRange.Cells[i,j] != null && xlRange.Cells[i,j].Value2 != null)
                    {
                        if(j == 1)
                            answers[i - 2].time = xlRange.Cells[i, j].Value2.ToString();
                        else if(j == 2)
                            answers[i - 2].name = xlRange.Cells[i, j].Value2.ToString();
                        else if(j == 3)
                            answers[i - 2].group = xlRange.Cells[i, j].Value2.ToString();
                        else
                            answers[i - 2].answers[j-4] = xlRange.Cells[i, j].Value2.ToString();
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

            Console.ReadKey();
            

            foreach(Answer i in answers)
            {
                if(Console.ReadLine() == i.name)
                {
                    currentPerson = i;
                }
            }
            orderedPoints = currentPerson.CheckMatch(answers);
            foreach(Points point in orderedPoints)
            {
                Console.WriteLine(point.person);
            }
        }
    }
}
