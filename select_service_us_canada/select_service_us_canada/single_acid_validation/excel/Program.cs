using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;
using select_service_us_canada.single_acid_validation.Utilities;
using Excel = Microsoft.Office.Interop.Excel;

namespace select_service_us_canada.single_acid_validation.excel
{
    class Program
    {
        public static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\single_acid_validation");
        public static string region = "";
        public static void ExcelCode(string res, int row, string msg)
        {
           // DateTime dateTime = DateTime.UtcNow.Date;
            //string currentdate = dateTime.ToString("dd/MM/yyyy");
            string currentdate=DateTime.Now.ToString("dd-MM-yyyy"+ " "+" hh:mm:ss");
            Console.WriteLine(currentdate);
            Pause.WaitingForSomeTime();
            Excel.Application x1 = new Excel.Application();           
            region = SelectRegion();
            bool resultDirExists = (System.IO.Directory.Exists(path + "\\TestResults"));
            if(resultDirExists)
            {
                if(region=="Canada")
                {
                    bool resultExcel = (System.IO.File.Exists(path + "\\TestResults" + "\\ServiceLifeResult_Canada" + ".xlsx"));
                    if (resultExcel)
                    {
                        Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResults" + "\\ServiceLifeResult_Canada" + ".xlsx");
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        r1.Cells[1,3]= currentdate;
                        w1.Save();
                        w1.Close();
                    }
                    else
                    {
                        var sourcepath = path + "\\BackupFolder" + "\\ServiceLifeResult_Canada" + ".xlsx";
                        var destpath = path + "\\TestResults" + "\\ServiceLifeResult_Canada" + ".xlsx";
                        File.Copy(sourcepath, destpath);
                        //Open excel and write result data
                        Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResults" + "\\ServiceLifeResult_Canada" + ".xlsx");
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        r1.Cells[1, 3] = currentdate;
                        w1.Save();
                        w1.Close();
                    }
                }
                else if(region == "United States")
                {
                    bool resultExcel = (System.IO.File.Exists(path + "\\TestResults" + "\\ServiceLifeResult_US" + ".xlsx"));
                    if (resultExcel)
                    {
                        //Open excel and write result data
                        Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResults" + "\\ServiceLifeResult_US" + ".xlsx");
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        w1.Save();
                        w1.Close();
                    }
                    else
                    {
                        //Copy excel file from backup folder
                        var sourcepath = path + "\\BackupFolder" + "\\ServiceLifeResult_US" + ".xlsx";
                        var destpath = path+"\\TestResults"+ "\\ServiceLifeResult_US" + ".xlsx";
                        File.Copy(sourcepath,destpath);
                        //Open excel and write result data
                        Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResults" + "\\ServiceLifeResult_US" + ".xlsx");
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        w1.Save();
                        w1.Close();
                    }
                } 
                else if(region=="Mexico")
                {
                    bool resultExcel = (System.IO.File.Exists(path + "\\TestResults" + "\\ServiceLifeResult_Mexico" + ".xlsx"));
                    if (resultExcel)
                    {
                        //Open excel and write result data
                        Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResults" + "\\ServiceLifeResult_Mexico" + ".xlsx");
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        w1.Save();
                        w1.Close();
                    }
                    else
                    {
                        //Copy excel file from backup folder
                        var sourcepath = path + "\\BackupFolder" + "\\ServiceLifeResult_Mexico" + ".xlsx";
                        var destpath = path + "\\TestResults" + "\\ServiceLifeResult_Mexico" + ".xlsx";
                        File.Copy(sourcepath, destpath);
                        //Open excel and write result data
                        Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResults" + "\\ServiceLifeResult_Mexico" + ".xlsx");
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        w1.Save();
                        w1.Close();
                    }
                }
                else if (region == "Brazil")
                {
                    bool resultExcel = (System.IO.File.Exists(path + "\\TestResults" + "\\ServiceLifeResult_Brazil" + ".xlsx"));
                    if (resultExcel)
                    {
                        //Open excel and write result data
                        Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResults" + "\\ServiceLifeResult_Brazil" + ".xlsx");
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        w1.Save();
                        w1.Close();
                    }
                    else
                    {
                        //Copy excel file from backup folder
                        var sourcepath = path + "\\BackupFolder" + "\\ServiceLifeResult_Brazil" + ".xlsx";
                        var destpath = path + "\\TestResults" + "\\ServiceLifeResult_Brazil" + ".xlsx";
                        File.Copy(sourcepath, destpath);
                        //Open excel and write result data
                        Excel.Workbook w1 = x1.Workbooks.Open(path + "\\TestResults" + "\\ServiceLifeResult_Brazil" + ".xlsx");
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        w1.Save();
                        w1.Close();
                    }
                }
            }
            else
            {
                //Create the result Directory
                DirectoryInfo di = Directory.CreateDirectory(path + "\\TestResults");
                if(region=="Canada")
                {
                    var source = path + "\\BackupFolder" + "\\ServiceLifeResult_Canada" + ".xlsx";
                    var destfile = path + "\\TestResults" + "\\ServiceLifeResult_Canada" + ".xlsx";
                    Console.WriteLine(source);
                    Console.WriteLine(destfile);
                    File.Copy(source,destfile);
                    //Open the excel file
                    Excel.Workbook w1 = x1.Workbooks.Open(destfile);
                    Excel._Worksheet s1 = w1.Sheets[1];
                    Excel.Range r1 = s1.UsedRange;
                    r1.Cells[row, 15] = res;
                    r1.Cells[row, 16] = msg;
                    w1.Save();
                    w1.Close();
                }
                else if (region == "United States")
                {
                    var source = path + "\\BackupFolder" + "\\ServiceLifeResult_US" + ".xlsx";
                    var destfile = path + "\\TestResult" + "\\ServiceLifeResult_US" + ".xlsx";
                    File.Copy(source, destfile);
                    //Open the excel file
                    Excel.Workbook w1 = x1.Workbooks.Open(destfile);
                    Excel._Worksheet s1 = w1.Sheets[1];
                    Excel.Range r1 = s1.UsedRange;
                    r1.Cells[row, 15] = res;
                    r1.Cells[row, 16] = msg;
                    w1.Save();
                    w1.Close();
                }
                else if (region == "Mexico")
                {
                    var source = path + "\\BackupFolder" + "\\ServiceLifeResult_Mexico" + ".xlsx";
                    var destfile = path + "\\TestResult" + "\\ServiceLifeResult_Mexico" + ".xlsx";
                    File.Copy(source, destfile);
                    //Open the excel file
                    Excel.Workbook w1 = x1.Workbooks.Open(destfile);
                    Excel._Worksheet s1 = w1.Sheets[1];
                    Excel.Range r1 = s1.UsedRange;
                    r1.Cells[row, 15] = res;
                    r1.Cells[row, 16] = msg;
                    w1.Save();
                    w1.Close();
                }
                else if (region == "Brazil")
                {
                    var source = path + "\\BackupFolder" + "\\ServiceLifeResult_Brazil" + ".xlsx";
                    var destfile = path + "\\TestResult" + "\\ServiceLifeResult_Brazil" + ".xlsx";
                    File.Copy(source, destfile);
                    //Open the excel file
                    Excel.Workbook w1 = x1.Workbooks.Open(destfile);
                    Excel._Worksheet s1 = w1.Sheets[1];
                    Excel.Range r1 = s1.UsedRange;
                    r1.Cells[row, 15] = res;
                    r1.Cells[row, 16] = msg;
                    w1.Save();
                    w1.Close();
                }
            }          
        }
        public static string SelectRegion()
        {
            Excel.Application x1 = new Excel.Application();
            string regionvalue = "";
            Excel.Workbook w1 = x1.Workbooks.Open(path + "\\Features" + "\\ServiceLifeBrazilData" + ".xlsx");
            Excel._Worksheet s1 = w1.Sheets[1];
            Excel.Range r1 = s1.UsedRange;
            regionvalue = r1.Cells[15][3].Value;
            w1.Close();
            return regionvalue; 
        }
    }
}
