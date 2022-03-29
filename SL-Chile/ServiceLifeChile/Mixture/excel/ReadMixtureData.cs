using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ServiceLife_Chile.mixture_acids_validation.excel
{
    class ReadMixtureData
    {
        static Excel.Workbook w1;
        static Excel.Range r1;


        public static void excel()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Mixture");            
            string excelsourcepath = path + "\\BackupFolder" + "\\Servicelife_Testcase_Chile-Mixture" + ".xlsx";
            //string destinationpath = path + "\\Features" + "\\TestResults";
            string destinationFile = path + "\\Features" + "\\Servicelife_Testcase_Chile-Mixture" + ".xlsx";
            bool fileExists = (System.IO.File.Exists(destinationFile) ? true : false);
            if (fileExists)
            {
                Console.WriteLine("File already exists");
            }
            else
            {
                File.Copy(excelsourcepath, destinationFile);
            }
            Excel.Application x1 = new Excel.Application();
            w1 = x1.Workbooks.Open(destinationFile);
            Excel._Worksheet s1 = w1.Sheets[1];
            r1 = s1.UsedRange;
        }
        public static void excelClose()
        {
            w1.Close();
        }
        public static string getdata(int col, int row)
        {
            var value = r1.Cells[col][row].Value;
            string final = value.ToString();
            return final;
        }
    }
}
