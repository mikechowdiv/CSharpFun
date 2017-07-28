using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
   public abstract class ReportBase
    {
        public virtual void ExportToDB(string filePath)
        {

        }

        public ReportModel GetReport(string filePath)
        {
            ReportModel report = new ReportModel();
            var dataTable = new CsvParser().ReadCsvFile(filePath);

            report.TotalSales = GetTotal(dataTable, "Sales");
            report.TotalGST = GetTotal(dataTable, "GST");
            report.TotalQuantity = GetTotal(dataTable,  "Quantity");

            return report;
        }

        //method to get the sum total of the 3 columns in the csv files
        private static double GetTotal(DataTable db, string columnName)
        {
            var total = db.AsEnumerable().Sum(r =>
            {
                double val = 0;
                double.TryParse(r.Field<string>(columnName), out val);
                return val;
            });
            return total;
        }
    }
}
