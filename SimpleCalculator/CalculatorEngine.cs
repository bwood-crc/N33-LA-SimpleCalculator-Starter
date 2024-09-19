using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation.Equals("+") || argOperation.ToLower().Equals("add")) {
                result = argFirstNumber + argSecondNumber;
            }
            if (argOperation.Equals("-") || argOperation.ToLower().Equals("subtract"))
            {
                result = argFirstNumber - argSecondNumber;
            }
            if (argOperation.Equals("*") || argOperation.ToLower().Equals("multiply"))
            {
                result = argFirstNumber * argSecondNumber;
            }

            if (argOperation.Equals("/") || argOperation.ToLower().Equals("divide"))
            {
                result = argFirstNumber / argSecondNumber;
            }
            //this method will calculate the exponent
            if (argOperation.Equals("exp"))
            {
                result = Math.Pow(argFirstNumber, argSecondNumber);
            }
            return result;
        }
    }
}
