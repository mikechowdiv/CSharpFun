using Models;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DepositRules
{
   public class DepositRuleFactory
    {
        public static IDeposit Create(AccountType type)
        {
            switch (type)
            {
                case AccountType.Free:
                    return new FreeAccountDepositRule();

            }
            throw new Exception("Account type is not supported");
        }
    }
}
