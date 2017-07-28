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
                return ConfigurationManager.ConnectionStrings["Test1"].ConnectionString;
            }
        } 

        public static string Path1
        {
            get
            {
                return ConfigurationManager.AppSettings["Path1"];
            }
        }
        
        public static string Path2
        {
            get
            {
                return ConfigurationManager.AppSettings["Path2"];
            }
        }

        public static string Path3
        {
            get
            {
                return ConfigurationManager.AppSettings["Path3"];
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
