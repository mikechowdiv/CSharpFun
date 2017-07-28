using DataParser.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Reports
{
   public class ReportBase
    {
        public virtual void ExportToDB(string filePath)
        {

        }

        public ReportModel GetReport(string filePath)
        {
            ReportModel report = new ReportModel();
            var db = new CSVParser().ReadCSVFile(filePath);

            report.TotalSales = GetTotal(db, "Sales");
            report.TotalGST = GetTotal(db, "GST");
            report.TotalQTY = GetTotal(db, "QTY");

            return report;
        }

        private static double GetTotal(DataTable db, string colName)
        {
            var total = db.AsEnumerable().Sum(s =>
            {
                double val = 0;
                double.TryParse(s.Field<string>(colName), out val);
                return val;
            });

            return total;
        }
    }
}
