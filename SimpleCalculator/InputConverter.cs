using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            double input = 0;
            int tester = 1;
            do
            {
                try
                {
                    input = Convert.ToDouble(argTextInput);
                    tester = 0;
                    if (tester == 0)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Enter a number's numerical value not something else!");
                    tester = 1;
                }
                Console.WriteLine("Enter the number's numerical value: ");
                argTextInput = Console.ReadLine();

            } while (tester != 0);
            return input;
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

                        Console.WriteLine("Enter standard operator in numeric format or in letter format such as + / add, - / substract, x / multiply, " +
                    "(/) / division, ^ / power ");
                        operation = Console.ReadLine();
                        break;

                }

            }
            return operation.ToLower();
        } 
        }
    }

