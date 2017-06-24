using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculater;

namespace Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertValidStringIntoDouble()
        {
            string inputNumber = "5";
            double convertedNum = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(convertedNum, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Expected a numeric value")]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNum = _inputConverter.ConvertInputToNumeric(inputNumber);

        }

    }
}
