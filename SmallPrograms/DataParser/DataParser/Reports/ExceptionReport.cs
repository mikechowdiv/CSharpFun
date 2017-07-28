using DataParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Reports
{
   public class ExceptionReport
    {
        public void GenExceptionReport(ReportModel r1, ReportModel r2, ReportModel r3, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine("diff in sales");
                sw.WriteLine($"Report1 vs Report2: {(r1.TotalSales - r2.TotalSales).ToString("N3")}");
                sw.WriteLine($"Report1 vs Report3: {(r1.TotalSales - r3.TotalSales).ToString("N3")}");
                sw.WriteLine("--------------------------------------------");

                sw.WriteLine("diff in GST");
                sw.WriteLine($"Report1 vs Report2: {(r1.TotalGST - r2.TotalGST).ToString("N3")}");
                sw.WriteLine($"Report1 vs Report3: {(r1.TotalGST - r3.TotalGST).ToString("N3")}");
                sw.WriteLine("--------------------------------------------");

                sw.WriteLine("diff in QTY");
                sw.WriteLine($"Report1 vs Report2: {(r1.TotalQTY - r2.TotalQTY).ToString("N3")}");
                sw.WriteLine($"Report1 vs Report3: {(r1.TotalQTY - r3.TotalQTY).ToString("N3")}");
                sw.WriteLine("--------------------------------------------");
            }
        }
    }
}
