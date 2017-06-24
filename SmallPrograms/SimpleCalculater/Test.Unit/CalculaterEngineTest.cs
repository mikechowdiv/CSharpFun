using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculater;

namespace Test.Unit
{
    [TestClass]
    public class CalculaterEngineTest
    {
        private readonly CalculaterEngine _calEng = new CalculaterEngine();


        [TestMethod]
        public void AddTwpNumbersAndReturnValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calEng.Calculate("add", number1, number2);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void AddTwpNumbersAndReturnValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calEng.Calculate("+", number1, number2);
            Assert.AreEqual(result, 3);
        }
    }
}
