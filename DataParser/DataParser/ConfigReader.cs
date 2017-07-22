using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
   public class ConfigReader
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SalesDB"].ConnectionString;
            }
        }

        public static string SalesCsvPath
        {
            get
            {
                return ConfigurationManager.AppSettings["SalesCsvPath"];
            }
        }

        public static string ItemsCsvPath
        {
            get
            {
                return ConfigurationManager.AppSettings["ItemsCsvPath"];
            }
        }

        public static string JournalsCsvPath
        {
            get
            {
                return ConfigurationManager.AppSettings["JournalsCsvPath"];
            }
        }

        public static string ExceptionReportPath
        {
            get
            {
                return ConfigurationManager.AppSettings["ExceptionReportPath"];
            }
        }

    }
}
