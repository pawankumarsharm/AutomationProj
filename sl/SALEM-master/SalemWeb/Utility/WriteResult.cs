using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace SalemWeb.Utility
{
    class WriteResult
    {
        public static readonly string _rootPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\TestResult");

        public static void writeResultToExcel(string _res, string _msg, int _row, string _filename, int _colNumber, int _sheet)
        {

            Excel.Application x1 = new Excel.Application();
              ExplicitWaiting.waitForTime(2000);
            bool _resDirExists = Directory.Exists(_rootPath);
            if (_resDirExists)
            {
                bool _fileExists = System.IO.File.Exists(_rootPath + _filename + ".xlsx");
                if (_fileExists)
                {
                    Excel.Workbook _workbook = x1.Workbooks.Open(_rootPath + _filename + ".xlsx");
                    Excel._Worksheet _worksheet = _workbook.Sheets[_sheet];
                    Excel.Range _range = _worksheet.UsedRange;
                    _range.Cells[_row, 11] = _res;
                    _range.Cells[_row, 12] = _msg;
                    _workbook.Save();
                    _workbook.Close();
                  

                }
                else
                {
                    Console.WriteLine("Output file does not exists........");
                }

            }
            else
            {
                DirectoryInfo _newDir = Directory.CreateDirectory(_rootPath);
                //ToDo code for copy file from backup directory.
            }
           
        }
    }
}