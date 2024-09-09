using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcTools;
using SimpleCalculator;
namespace SimpleCalculator.Test.Unit

{
    [TestClass]
    public class CalcToolsTest
    {

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUti.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUti.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void SubstractsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 1;
            double result = CalcUti.Calculate("minus", number1, number2);
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void SubstractsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 1;
            double result = CalcUti.Calculate("-", number1, number2);
            Assert.AreEqual(1, result);

        }
        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 2;
            double result = CalcUti.Calculate("multiply", number1, number2);
            Assert.AreEqual(4, result);

        }

        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 2;
            int number2 = 2;
            double result = CalcUti.Calculate("*", number1, number2);
            Assert.AreEqual(4, result);

        }
        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 4;
            int number2 = 2;
            double result = CalcUti.Calculate("divide", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 4;
            int number2 = 2;
            double result = CalcUti.Calculate("/", number1, number2);
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void PercentTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 100;
            int number2 = 10;
            double result = CalcUti.Calculate("percent", number1, number2);
            Assert.AreEqual(10, result);

        }

        [TestMethod]
        public void PercentTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 100;
            int number2 = 10;
            double result = CalcUti.Calculate("%", number1, number2);
            Assert.AreEqual(10, result);

        }
    }
}
