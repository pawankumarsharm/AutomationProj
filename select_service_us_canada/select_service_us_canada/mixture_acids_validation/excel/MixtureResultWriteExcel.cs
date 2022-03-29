using select_service_us_canada.mixture_acids_validation.StepDefinations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace select_service_us_canada.mixture_acids_validation.excel
{
    class MixtureResultWriteExcel
    {
        public static Excel.Application x1 = new Excel.Application();
        public static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\mixture_acids_validation");
        public static string region = SelectRegion();
        
        
        public static void ExcelCode(string res, int row, string msg)
        {
            Console.WriteLine(path);
            //Check if TestResult Directory exists or not
            
            string resultDir = path + "\\TestResults";
            bool DirExists = System.IO.Directory.Exists(resultDir);
            //if exists, check if result file exists or not
            if(DirExists)
            {
                //Check if region is United States or Canada
                if(region=="Canada")
                {
                    //Check if file exists, if not copy from backup folder and then open
                    string dest = resultDir + "\\ServiceLifeResult_Canada(Mixture)" + ".xlsx";
                    bool fileExists = System.IO.File.Exists(dest);
                    if(fileExists)
                    {
                        //Open file and write data
                        Excel.Workbook w1 = x1.Workbooks.Open(dest);
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        w1.Save();
                        w1.Close();
                    }
                    else
                    {
                        //copy from the backup folder and then open it.
                        string source = path + "\\BackupFolder" + "\\ServiceLifeResult_Canada(Mixture)" + ".xlsx";
                        string destCan = resultDir + "\\ServiceLifeResult_Canada(Mixture)" + ".xlsx";
                        File.Copy(source, destCan);
                        //Open file and write data
                        Excel.Workbook w1 = x1.Workbooks.Open(destCan);
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        w1.Save();
                        w1.Close();
                    }
                }
                else if(region=="United States")
                {
                    //Check if file exists, if not copy from the backup folder and then open it.
                    string dest = resultDir + "\\ServiceLifeResult_US(Mixture)" + ".xlsx";
                    bool fileExists = System.IO.File.Exists(dest);
                    if (fileExists)
                    {
                        //Open file and write data
                        //Now open the file to write the data

                        Excel.Workbook w1 = x1.Workbooks.Open(dest);
                        Excel._Worksheet s1 = w1.Sheets[1];
                        Excel.Range r1 = s1.UsedRange;
                        r1.Cells[row, 15] = res;
                        r1.Cells[row, 16] = msg;
                        w1.Save();
                        w1.Close();
                    }
                    else
                    {
                        //copy from the backup folder and then open it.
                        string source = path + "\\BackupFolder" + "\\ServiceLifeResult_US(Mixture)" + ".xlsx";
                        string destCan = resultDir + "\\ServiceLifeResult_US(Mixture)" + ".xlsx";
                        File.Copy(source, destCan);
                        //Now open the file to write the data

                        Excel.Workbook w1 = x1.Workbooks.Open(destCan);
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
                //Create the result directory, since it does not exists
                DirectoryInfo di = Directory.CreateDirectory(resultDir);
                //Check the region, copy the file and open it
                if(region=="Canada")
                {
                    //Copy the canada file from the backup folder
                    string source = path + "\\BackupFolder" + "\\ServiceLifeResult_Canada(Mixture)" + ".xlsx";
                    string dest = resultDir + "\\ServiceLifeResult_Canada(Mixture)" + ".xlsx";
                    File.Copy(source, dest);
                    //Now open the file to write the data

                    Excel.Workbook w1 = x1.Workbooks.Open(dest);
                    Excel._Worksheet s1 = w1.Sheets[1];
                    Excel.Range r1 = s1.UsedRange;
                    r1.Cells[row, 15] = res;
                    r1.Cells[row, 16] = msg;
                    w1.Save();
                    w1.Close();
                }
                else if(region=="United States")
                {
                    //Copy the United States file from the backup folder
                    string source = path + "\\BackupFolder" + "\\ServiceLifeResult_US(Mixture)" + ".xlsx";
                    string dest = resultDir + "\\ServiceLifeResult_US(Mixture)" + ".xlsx";
                    File.Copy(source, dest);
                    //Now open the file to write the data

                    Excel.Workbook w1 = x1.Workbooks.Open(dest);
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
            Excel.Workbook w1 = x1.Workbooks.Open(path + "\\Features" + "\\mixture_input" + ".xlsx");
            Excel._Worksheet s1 = w1.Sheets[1];
            Excel.Range r1 = s1.UsedRange;
            regionvalue = r1.Cells[15][2].Value;
            w1.Close();
            x1.Quit();
            MixtureAcidValidationsSteps._logger.Info("Selecting the region as " + regionvalue);
            return regionvalue;
        }
    }
}










//  ReadData.excelClose();


