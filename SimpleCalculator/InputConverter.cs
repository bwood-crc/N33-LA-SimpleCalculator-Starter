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
                argTextInput=Console.ReadLine();

            }while (tester != 0);
            return input;
        }
    }
}
