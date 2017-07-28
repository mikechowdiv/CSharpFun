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
                var salesFilePath = ConfigReader.SalesCsvPath;
                var itemsFilePath = ConfigReader.ItemsCsvPath;
                var journalsFilePath = ConfigReader.JournalsCsvPath;
                var exceptionReportPath = ConfigReader.ExceptionReportPath;

                var salesReport = new SalesReport().GetReport(salesFilePath);
                var itemsReport = new ItemsReport().GetReport(itemsFilePath);
                var journalsReport = new JournalsReport().GetReport(journalsFilePath);

                new ExceptionReport().GenerateExceptionReport(salesReport, itemsReport, journalsReport, exceptionReportPath);

                new SalesReport().ExportToDB(salesFilePath);
                new ItemsReport().ExportToDB(itemsFilePath);
                new JournalsReport().ExportToDB(journalsFilePath);
            }

            catch(Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
        }
    }
}
