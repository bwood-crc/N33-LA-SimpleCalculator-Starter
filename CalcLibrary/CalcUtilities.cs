

using System;
using System.Xml.Linq;

namespace CalcLibrary

{
    public class CalcUtilities
    {
        public static double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)

        {
            double result = 0;

            {

                switch (argOperation.ToLower())
                {
                    case "+":
                    case "add":



                        result = argFirstNumber + argSecondNumber;

                        return result; ;

                        break;

                    case "-":
                    case "substract":

                        result = argFirstNumber - argSecondNumber;

                        return result;

                        break;

                    case "*":
                    case "multiply":

                        result = argFirstNumber * argSecondNumber;

                        return result;

                        break;

                    case "/":
                    case "division":

                        result = argFirstNumber / argSecondNumber;
                        return result;


                        break;

                    case "^":
                    case "power":

                        result = Math.Pow(argFirstNumber, argSecondNumber);
                        return result;

                        break;

                    default:

                        throw new ArgumentException();




                }

                return result;


            }
        }
    }
}