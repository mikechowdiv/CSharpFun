using Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public static class Factory
    {
        public static AccountManager Create()
        {
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();
            switch (mode)
            {
                case "FreeTest":
                    return new AccountManager(new FreeAcctTestRepo());
                default:
                    throw new Exception("Mode value in add config is not valid");
            }
        }
    }
}
