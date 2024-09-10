using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        //private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            bool convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber,out double ConvertResult);
            Assert.IsTrue(convertedNumber);
            Assert.AreEqual(5, ConvertResult);
        }

        [TestMethod]
        public void FailsToConvertsInvalidStringInputIntoDouble()
        {
            string inputNumber = "five";
           bool convertedNumber = InputConverter.ConvertInputToNumeric(inputNumber,out double ConvertResult);
            Assert.IsFalse(convertedNumber);
           Assert.AreNotEqual(5, ConvertResult);
          
        }
    }
}
