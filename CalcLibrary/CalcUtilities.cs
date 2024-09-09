

using System;
using System.Xml.Linq;

namespace CalcLibrary

{
    public class CalcUtilities
    {
        public static double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)

        {
            double result = 0;




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

                    if (argSecondNumber == 0)
                    {

                        result = 0.00;

                    }
                    else
                    {
                        result = argFirstNumber / argSecondNumber;

                    }



                    return result;


                    break;

                case "^":
                case "power":

                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    return result;

                    break;

                default:


                    return 0;
                    break;




            }

            return result;






        }
        public static bool IsValidOperator(string argoperation)
        {

            switch (argoperation.ToLower())
            {
                case "+":
                case "add":
                case "-":
                case "substract":
                case "*":
                case "multiply":
                case "/":
                case "division":
                case "^":
                case "power":

                    return true;

                default:

                    return false;



            }
        }
    }

}