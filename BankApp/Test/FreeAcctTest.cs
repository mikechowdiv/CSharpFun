using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BLL;
using Models;
using Models.Responses;

namespace Test
{
    [TestFixture]
    public class FreeAcctTest
    {
        [Test]
        public void CanLoadFreeAcctTestData()
        {
            AccountManager manager = Factory.Create();
            AcctLookupResponse resp = manager.LookupAcct("");

            Assert.IsNotNull(resp.Account);
            Assert.IsTrue(resp.Success);
            Assert.AreEqual("12345", resp.Account.AccountNumber);
        }
    }
}
