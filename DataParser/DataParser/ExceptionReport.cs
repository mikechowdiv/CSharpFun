using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
   public class ExceptionReport
    {
        public void GenerateExceptionReport(ReportModel salesReport, ReportModel itemsReport, ReportModel journalsReport, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine("Diff in total");
                sw.WriteLine("----------------------------------");
                sw.WriteLine($"Items vs Sales :  {(salesReport.TotalSales - itemsReport.TotalSales).ToString("N3")}");
                sw.WriteLine($"Items vs Journals :  {(journalsReport.TotalSales - itemsReport.TotalSales).ToString("N3")}");
                sw.WriteLine();

                sw.WriteLine("Diff in GST");
                sw.WriteLine("----------------------------------");
                sw.WriteLine($"Items vs Sales :  {(salesReport.TotalGST - itemsReport.TotalGST).ToString("N3")}");
                sw.WriteLine($"Items vs Journals :  {(journalsReport.TotalGST - itemsReport.TotalGST).ToString("N3")}");
                sw.WriteLine();

                sw.WriteLine("Diff in QTY");
                sw.WriteLine("----------------------------------");
                sw.WriteLine($"Items vs Sales :  {(salesReport.TotalQuantity - itemsReport.TotalQuantity).ToString("N3")}");
                sw.WriteLine($"Items vs Journals :  {(journalsReport.TotalQuantity - itemsReport.TotalQuantity).ToString("N3")}");
                sw.WriteLine();
            }
        }
    }
}
