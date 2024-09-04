using System;

namespace SimpleCalculator
{
    public class CalculatorLibrary
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            //There is two cases per switch to be able to take in the symbol and the word
            //Addition
            switch (argOperation)
            {
                case "add":
                case "+":


                    result = argFirstNumber + argSecondNumber;
                    break;

                //Minus
                case "minus":
                case "-":


                    result = argFirstNumber - argSecondNumber;
                    break;
                //Multiplication
                case "multiply":
                case "*":

                    result = argFirstNumber * argSecondNumber;
                    break;
                //Division
                case "divide":
                case "/":

                    result = argFirstNumber / argSecondNumber;
                    break;
                //Calculating the percentage of the first number
                case "percent":
                case "%":

                    result = (argFirstNumber / 100) * argSecondNumber;
                    break;
            }
            //Giving back the awnser
            return result;
        }
    }
}
