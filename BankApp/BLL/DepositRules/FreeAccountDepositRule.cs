using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Responses;

namespace BLL.DepositRules
{
    public class FreeAccountDepositRule : IDeposit
    {
        public AccountDepositResponse Deposit(Account acct, decimal amt)
        {
            AccountDepositResponse resp = new AccountDepositResponse();

            if (acct.Type != AccountType.Free)
            {
                resp.Success = false;
                resp.Message = "Error: a non free account hit the Free Deposit Rule.  Contact IT";
                return resp;
            }
            if(amt > 100)
            {
                resp.Success = false;
                resp.Message = "Free account cannot deposit more than $100 at a time";
                return resp;
            }
            if (amt <= 0)
            {
                resp.Success = false;
                resp.Message = "Deposit amount must be greater than zero";
                return resp;
            }
            resp.OldBalance = acct.Balance;
            acct.Balance += amt;
            resp.Acct = acct;
            resp.Amount = amt;
            resp.Success = true;

            return resp;
        }
    }
}
