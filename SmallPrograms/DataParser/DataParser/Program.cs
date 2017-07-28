using DataParser.Reports;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                var p1 = ConfigReader.Path1;
                var p2 = ConfigReader.Path2;
                var p3 = ConfigReader.Path3;
                var exceptionReportPath = ConfigReader.ExceptionReportPath;

                var report1 = new Report1().GetReport(p1);
                var report2 = new Report2().GetReport(p2);
                var report3 = new Report3().GetReport(p3);

                new ExceptionReport().GenExceptionReport(report1, report2, report3, exceptionReportPath);

                new Report1().ExportToDB(p1);
                new Report2().ExportToDB(p2);
                new Report3().ExportToDB(p3);

            }
            catch(Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
        }
    }
}
