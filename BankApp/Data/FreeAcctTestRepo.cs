using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data
{
    public class FreeAcctTestRepo : IAccountRepo
    {
        private static Account _acct = new Account
        {
            Name = "Free Account",
            Balance = 100.00M,
            AccountNumber = "12345",
            Type = AccountType.Free
        };

        public Account LoadAcct(string AcctNum)
        {
            return _acct;
        }

        public void SaveAcct(Account acct)
        {
            _acct = acct;
        }
    }
}
