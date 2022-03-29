using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Safeguard.Xpath
{
    class WriteDataToExcel
    {
        public static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

        public static void ExcelCode(string res, string msg, int row, string scen)
        {
            Thread.Sleep(2000);
            Excel.Application x1 = new Excel.Application();
            bool resultDirExists = (System.IO.Directory.Exists(path + "\\TestResult"));
            if (resultDirExists)
            {
                bool resultExcel = (System.IO.File.Exists(path + "\\TestResult" + "\\SafeResult" + ".xlsx"));
                if (resultExcel)
                {
                    //Open excel and write result data
                    Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResult" + "\\SafeResult" + ".xlsx");
                    Excel._Worksheet s1 = w1.Sheets[1];
                    Excel.Range r1 = s1.UsedRange;
                    r1.Cells[row, 4] = res;
                    r1.Cells[row, 5] = msg;
                    r1.Cells[row, 3] = scen;
                    w1.Save();
                    w1.Close();
                }
                else
                {
                    //Copy excel file from backup folder
                    Console.WriteLine("path not found");
                }
            }
            else
            {
                //Create the result Directory
                DirectoryInfo di = Directory.CreateDirectory(path + "\\TestResult");


            }
        }
    }
}
