using BLL.DepositRules;
using Models.Interfaces;
using Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class AccountManager
    {
        private IAccountRepo _acctRepo;

        public AccountManager(IAccountRepo acctRepo)
        {
            _acctRepo = acctRepo;
        }

        public AcctLookupResponse LookupAcct(string acctNumber)
        {
            AcctLookupResponse response = new AcctLookupResponse();
            response.Account = _acctRepo.LoadAcct(acctNumber);
            if (response.Account == null)
            {
                response.Success = false;
                response.Message = $"{acctNumber} is not a valid account.";
            }
            else
            {
                response.Success = true;           
            }
            return response;
        }

        public AccountDepositResponse Deposit(string acctNumber, decimal amt)
        {
            AccountDepositResponse response = new AccountDepositResponse();

            response.Acct = _acctRepo.LoadAcct(acctNumber);
            if (response.Acct == null)
            {
                response.Success = false;
                response.Message = $"{acctNumber} is not a valid account.";
            }
            else
            {
                response.Success = true;
            }

            IDeposit depositRule = DepositRuleFactory.Create(response.Acct.Type);
            response = depositRule.Deposit(response.Acct, amt);

            if (response.Success)
            {
                _acctRepo.SaveAcct(response.Acct);
            }

            return response;
        }
    }
}
