using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser
{
   public class CsvParser
    {
        public DataTable ReadCsvFile(string filePath)
        {
            DataTable dtCsv = new DataTable();
            string FullTest;
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    FullTest = sr.ReadToEnd().ToString();
                    string[] rows = FullTest.Split('\n');
                    for (int i = 0; i < rows.Count() - 1; i++)
                    {
                        string[] rowValues = rows[i].Split(',');
                        {
                            if (i == 0)
                            {
                                for (int j = 0; j < rowValues.Count(); j++)
                                {
                                    dtCsv.Columns.Add(rowValues[j]);
                                }
                            }
                            else
                            {
                                DataRow dr = dtCsv.NewRow();
                                var length = rowValues.Count() > dtCsv.Columns.Count ? dtCsv.Columns.Count : rowValues.Count();
                                for (int k = 0; k < length; k++)
                                {
                                    dr[k] = rowValues[k].ToString();
                                }
                                dtCsv.Rows.Add(dr);
                            }
                        }                     
                    }
                }
            }
            return dtCsv;
        } 
    }
}
