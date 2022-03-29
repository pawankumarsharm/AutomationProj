using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace SelectCartridgeChile.Helpers
{
    class WriteDataToExcel
    {
        public static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
        public static string region = "";
        public static void ExcelCode(string res, string msg, int row)
        {
            Thread.Sleep(2000);
            Excel.Application x1 = new Excel.Application();
            region = "Chile";  //SelectRegion();
            bool resultDirExists = (System.IO.Directory.Exists(path + "\\TestResults"));
            if (resultDirExists)
            {

                if (region == "Chile")
                {
                    bool resultExcel = (System.IO.File.Exists(path + "\\TestResults" + "\\TestResult_Chile" + ".xlsx"));
                    if (resultExcel)
                    {
                        //Open excel and write result data
                        Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResults" + "\\TestResult_Chile" + ".xlsx");
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 20] = res;
                        r1.Cells[row, 21] = msg;
                        w1.Save();
                        w1.Close();
                    }
                    else
                    {
                        //Copy excel file from backup folder
                        var sourcepath = path + "\\BackupFolder" + "\\TestResult_Chile" + ".xlsx";
                        var destpath = path + "\\TestResults" + "\\TestResult_Chile" + ".xlsx";
                        File.Copy(sourcepath, destpath);
                        //Open excel and write result data
                        Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResults" + "\\TestResult_Chile" + ".xlsx");
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 20] = res;
                        r1.Cells[row, 21] = msg;
                        w1.Save();
                        w1.Close();
                    }
                }
            }
            else
            {
                //Create the result Directory
                DirectoryInfo di = Directory.CreateDirectory(path + "\\TestResults");

                if (region == "Chile")
                {
                    var source = path + "\\BackupFolder" + "\\TestResult_Chile" + ".xlsx";
                    var destfile = path + "\\TestResult" + "\\TestResult_Chile" + ".xlsx";
                    File.Copy(source, destfile);
                    //Open the excel file
                    Excel.Workbook w1 = x1.Workbooks.Open(destfile);
                    Excel._Worksheet s1 = w1.Sheets[1];
                    Excel.Range r1 = s1.UsedRange;
                    r1.Cells[row, 20] = res;
                    r1.Cells[row, 21] = msg;
                    w1.Save();
                    w1.Close();
                }
            }
        }
    }
}
