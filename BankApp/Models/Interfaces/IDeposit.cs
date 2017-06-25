using Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
   public interface IDeposit
    {
        AccountDepositResponse Deposit(Account acct, decimal amt);
       

    }
}
