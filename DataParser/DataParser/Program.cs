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

            }
            catch(Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
        }
    }
}
