using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputConverter;
namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = Converter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertsInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = Converter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(2, convertedNumber);
        }
        [TestMethod]
        public void ValidInputTest() {
            string inputNumber = "";
            bool test = Converter.ValidInput(inputNumber);
            Assert.AreEqual(false, test);
        
        
        }
        [TestMethod]
        public void ValidatesOperationString() {
            string operation = "+";
            bool ret = Converter.operationValidator(operation);
            Assert.AreEqual(true, ret);
        
        }
        [TestMethod]
        public void InvalidatesOperationNumber()
        {
            string operation = "reuthoagiy";
            bool ret = Converter.operationValidator(operation);
            Assert.AreEqual(false, ret);




        }
        }
}
