using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Reports
{
   public class Report2 : ReportBase
    {
        public override void ExportToDB(string filePath)
        {
            var dataTable = new CSVParser().ReadCSVFile(filePath);

            using (var bulkCopy = new SqlBulkCopy(ConfigReader.ConnectionString))
            {
                bulkCopy.BulkCopyTimeout = 600;
                bulkCopy.DestinationTableName = "report2";
                bulkCopy.WriteToServer(dataTable);
            }

            base.ExportToDB(filePath);
        }
    }
}
