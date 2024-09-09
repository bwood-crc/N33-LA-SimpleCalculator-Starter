using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static bool ConvertInputToNumeric(string argTextInput, out double ConvertedResult)
        {
            bool isTrue = false;
            double input = 0;

            try
            {
                input = Convert.ToDouble(argTextInput);
                ConvertedResult = input;
                isTrue = true;
            }
            catch (Exception ex)
            {
                ConvertedResult = 0;
                isTrue = false;
            }
            return isTrue;

        }
        public static string OperationConverter(string operation)
        {
            Boolean isvalid = false;


            while (!isvalid)
            {

                switch (operation.ToLower())
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

                        isvalid = true;

                        break;

                    default:

                        Console.WriteLine("Enter standard operator in numeric format or in letter format such as + or add, - or substract, x or multiply, " +
                    "/ or division, ^ or power: ");
                        operation = Console.ReadLine();
                        break;

                }

            }
            return operation.ToLower();
        } 
        }
    }

