using System;
using CalcLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
       // private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUtilities.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUtilities.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);

        }


        [TestMethod]
        public void SubstractTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUtilities.Calculate("substract", number1, number2);
            Assert.AreEqual(-1, result);

        }


        [TestMethod]
        public void SubstractTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUtilities.Calculate("-", number1, number2);
            Assert.AreEqual(-1, result);

        }

        [TestMethod]
        public void MultiplyTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUtilities.Calculate("multiply", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void MultiplyTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUtilities.Calculate("*", number1, number2);
            Assert.AreEqual(2, result);

        }

        [TestMethod]
        public void DivideTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUtilities.Calculate("division", number1, number2);
            Assert.AreEqual(0.5, result);

        }

        [TestMethod]
        public void DivideTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUtilities.Calculate("/", number1, number2);
            Assert.AreEqual(0.5, result);

        }

        [TestMethod]
        public void PowerTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUtilities.Calculate("power", number1, number2);
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void PowerTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalcUtilities.Calculate("^", number1, number2);
            Assert.AreEqual(1, result);

        }
    }
}
