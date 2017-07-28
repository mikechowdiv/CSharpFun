using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
   public class JournalsReport : ReportBase
    {
        public override void ExportToDB(string filePath)
        {
            var dataTable = new CsvParser().ReadCsvFile(filePath);

            using (var bulkCopy = new SqlBulkCopy(ConfigReader.ConnectionString))
            {
                bulkCopy.BulkCopyTimeout = 600;
                bulkCopy.DestinationTableName = "Journals";
                bulkCopy.WriteToServer(dataTable);
            }

                base.ExportToDB(filePath);
        }
    }
}
